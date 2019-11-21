using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVR
{
    public class Message
    {
        Header header;
        byte[] body = new byte[256];
        int bindex = 0;

        public Message()
        {
            header = new Header();
        }

        public Message(byte[] b)
        {
            header = new Header();
            from_buffer(b);
        }

        public Message(byte did, byte cid, byte target)
        {
            header = new Header();

            this.did(did);
            this.cid(cid);
            this.target(target);
        }
        public bool is_response()
        {
            return header.is_response();
        }

        public void is_response(bool answer)
        {
            header.is_response(answer);
        }

        public bool request_response()
        {
            return header.request_response();
        }

        public void request_response(bool answer)
        {
            header.request_response(answer);
        }

        public bool request_err_response()
        {
            return header.request_error_response();
        }

        public void request_err_response(bool answer)
        {
            header.request_error_response(answer);
        }

        public bool is_activity()
        {
            return header.is_activity();
        }

        public void is_activity(bool answer)
        {
            header.is_activity(answer);
        }

        public bool has_target()
        {
            return header.has_target();
        }

        public void has_target(bool answer)
        {
            header.has_target(answer);
        }

        public bool has_source()
        {
            return header.has_source();
        }

        public void has_source(bool answer)
        {
            header.has_source(answer);
        }

        public bool has_extended_flags()
        {
            return header.has_extended_flags();
        }

        public void has_extended_flags(bool answer)
        {
            header.has_extended_flags(answer);
        }

        public byte did()
        {
            return header.did;
        }

        public void did(byte device)
        {
            header.did = device;
        }

        public byte cid()
        {
            return header.cid;
        }

        public void cid(byte command)
        {
            header.cid = command;
        }

        public byte seq()
        {
            return header.seq;
        }

        public void seq(byte sequence)
        {
            header.seq = sequence;
        }

        public byte target()
        {
            return header.target();
        }

        public void target(byte address)
        {
            header.target(address);
        }

        public byte target_port()
        {
            return header.target_port();
        }

        public void target_port(byte port)
        {
            header.target_port(port);
        }

        public byte target_node()
        {
            return header.target_node();
        }

        public void target_node(byte node)
        {
            header.target_node(node);
        }

        public byte source()
        {
            return header.source();
        }

        public void source(byte address)
        {
            header.source(address);
        }

        public byte source_port()
        {
            return header.source_port();
        }

        public void source_port(byte port)
        {
            header.source_port(port);
        }

        public byte source_node()
        {
            return header.source_node();
        }

        public void source_node(byte node)
        {
            header.source_node(node);
        }

        public byte err()
        {
            return header.err();
        }

        public void err(byte errorCode)
        {
            header.err(errorCode);
        }

        public byte[] serialize()
        {
            int index = 0;

            byte[] b = new byte[512];

            byte[] x = header.serialize();

            for (int i = 0; i < x.Length; i++)
                b[index++] = x[i];

            for (int i = 0; i < bindex; i++)
                b[index++] = body[i];

            b[index++] = (byte)(checksum(b, index) ^ 0xff);

            b = escape_buffer(b);
            byte[] r = new byte[256];

            r[0] = Packet.START_OF_PACKET;
            for (int i = 0; i < index; i++)
                r[i + 1] = b[i];
            r[index+1] = Packet.END_OF_PACKET;

            return r;
        }

        public void Pack(byte b)
        {
            body[bindex++] = b;
        }

        public void Pack(bool b)
        {
            if (b == true)
                body[bindex++] = 0x01;
            else
                body[bindex++] = 0x00;
        }

        public void Pack(Int16 i)
        {
            body[bindex++] = (byte)(i >> 8);
            body[bindex++] = (byte)(i & 0xff);
        }

        public void Pack(UInt16 i)
        {
            body[bindex++] = (byte)(i >> 8);
            body[bindex++] = (byte)(i & 0xff);
        }

        public void PackColor(UInt32 c)
        {
            body[bindex++] = (byte)(c >> 16);
            body[bindex++] = (byte)(c >> 8);
            body[bindex++] = (byte)(c & 0xff);
        }

        public void Pack(UInt32 i)
        {
            body[bindex++] = (byte)(i >> 24);
            body[bindex++] = (byte)(i >> 16);
            body[bindex++] = (byte)(i >> 8);
            body[bindex++] = (byte)(i & 0xff);
        }

        public void Pack(string s)
        {
            char[] c = s.ToArray();

            for (int i = 0; i < c.Length; i++)
                body[bindex++] = (byte)c[i];
        }

        public void Pack(float f)
        {
            byte[] b = BitConverter.GetBytes(f);
            body[bindex++] = b[3];
            body[bindex++] = b[2];
            body[bindex++] = b[1];
            body[bindex++] = b[0];
        }

        public void Pack(byte[] b)
        {
            for (int i = 0; i < b.Length; i++)
                body[bindex++] = b[i];
        }

        private byte checksum(byte[] b, int x)
        {
            byte s = 0;

            for (int i = 0; i < x; i++)
                s += b[i];
            return s;
        }

        private byte[] escape_buffer(byte[] raw)
        {
            int index = 0;

            byte[] ot = new byte[512];

            for (int i=0;i<256;i++)
            {
                if (raw[i] == Packet.START_OF_PACKET)
                {
                    ot[index++] = Packet.ESCAPE;
                    ot[index++] = Packet.ESCAPED_START;
                    continue;
                }

                if (raw[i] == Packet.END_OF_PACKET)
                {
                    ot[index++] = Packet.ESCAPE;
                    ot[index++] = Packet.ESCAPED_END;
                    continue;
                }

                if (raw[i] == Packet.ESCAPE)
                {
                    ot[index++] = Packet.ESCAPE;
                    ot[index++] = Packet.ESCAPED_ESCAPED;
                }

                ot[index++] = raw[i];
            }

            return ot;
        }

        public byte[] unpack_bytes()
        {
            return body;
        }

        public byte unpack_byte()
        {
            return body[bindex++];
        }

        public bool unpack_bool()
        {
            if (body[bindex++] == 0)
                return false;
            else
                return true;
        }

        public int unpack_int16()
        {
            int v = (Int16)(body[bindex++] << 8) | (Int16)(body[bindex++]);

            return v;
        }

        public UInt32 unpack_color(byte[] c, byte p)
        {
            UInt32 color = new UInt32();

            color = (UInt32)(c[p + 0]) << 16 | (UInt32)(c[p + 1]) << 8 | (UInt32)(c[p + 2]);

            return color;
        }

        public int unpack_int32()
        {
            int p = bindex;

            int v = (int)(body[p]) << 24 | (int)(body[p + 1]) << 16 | (int)(body[p + 2]) << 8 | (int)body[p + 3];

            bindex = bindex + 4;

            return v;
        }

        public uint unpack_uint32()
        {
            int p = bindex;

            uint v = (uint)(body[p]) << 24 | (uint)(body[p + 1]) << 16 | (uint)(body[p + 2]) << 8 | (uint)body[p + 3];

            bindex = bindex + 4;

            return v;
        }

        public UInt64 unpack_uint64()
        {
            int p = bindex;

            UInt64 v = (UInt64)(body[p]) << 56 | (UInt64)(body[p + 1]) << 48 | (UInt64)(body[p + 2]) << 40 | (UInt64)(body[p + 3]) << 32;
            v |= (UInt64)(body[p + 4]) << 24 | (UInt64)(body[p + 5]) << 16 | (UInt64)(body[p + 6]) << 8 | (UInt64)(body[p + 7]);

            p = p + 8;

            return v;
        }

        public float unpack_float()
        {
            byte[] b = new byte[4];

            b[3] = body[bindex++];
            b[2] = body[bindex++];
            b[1] = body[bindex++];
            b[0] = body[bindex++];

            return BitConverter.ToSingle(b, 0);
        }

        public string unpack_string()
        {
            int end = 1;

            for (int i = bindex; i < body.Length; i++)
            {
                if (body[i] == 0)
                {
                    end = i;
                    break;
                }
            }

            string x = Encoding.UTF8.GetString(body, bindex, end);
            bindex = end + 1;

            return x;
        }

        public void from_buffer(byte[] m)
        {
            byte v;
            int index;

            byte[] d = new byte[m.Length - 2];
            for (int i = 0; i < m.Length - 2; i++)
                d[i] = m[i+1];

            v = this.checksum(d, d.Length);
            if (v != 0xff)
                return;

            index = header.from_buffer(d);
            v = 0;
            for (int i = index; i < d.Length - 1; i++)
                body[v++] = d[i];
        }
    }

}
