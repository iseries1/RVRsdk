using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVR
{
    class Header
    {
        private byte flags;
        private byte _target;
        private byte _source;
        public byte did;
        public byte cid;
        public byte seq;
        private byte error;

        public bool is_response()
        {
            if ((flags & Flags.packet_is_response) == 0)
                return false;
            else
                return true;

        }

        public void is_response(bool answer)
        {
            if (answer)
            {
                flags |= Flags.packet_is_response;
                flags &= ~Flags.packet_requests_response & 0xff;
                flags &= ~Flags.packet_requests_response_if_error & 0xff;
            }
            else
            {
                flags &= ~Flags.packet_is_response & 0x0ff;
            }
        }

        public bool request_response()
        {
            if ((flags & Flags.packet_requests_response) == 0)
                return false;
            else
                return true;
        }

        public void request_response(bool answer)
        {
            if (answer)
                flags |= Flags.packet_requests_response;
            else
                flags &= ~Flags.packet_requests_response & 0xff;
        }

        public bool request_error_response()
        {
            if ((flags & Flags.packet_requests_response_if_error) == 0)
                return false;
            else
                return true;
        }

        public void request_error_response(bool answer)
        {
            if (answer)
            {
                flags |= Flags.packet_is_response;
                flags |= Flags.packet_requests_response_if_error;
            }
            else
                flags &= ~Flags.packet_requests_response_if_error & 0xff;
        }

        public bool is_activity()
        {
            if ((flags & Flags.packet_is_activity) == 0)
                return false;
            else
                return true;
        }

        public void is_activity(bool answer)
        {
            if (answer)
                flags |= Flags.packet_is_activity;
            else
                flags &= ~Flags.packet_is_activity & 0xff;
        }

        public bool has_target()
        {
            if ((flags & Flags.packet_has_target) == 0)
                return false;
            else
                return true;
        }

        public void has_target(bool answer)
        {
            if (answer)
                flags |= Flags.packet_has_target;
            else
            {
                flags &= ~Flags.packet_has_target & 0xff;
                _target = 0;
            }
        }

        public bool has_source()
        {
            if ((flags & Flags.packet_has_source) == 0)
                return false;
            else
                return true;
        }

        public void has_source(bool answer)
        {
            if (answer)
                flags |= Flags.packet_has_source;
            else
            {
                flags &= ~Flags.packet_has_source & 0xff;
                _source = 0;
            }
        }

        public bool has_extended_flags()
        {
            if ((flags & Flags.packet_has_more_flags) == 0)
                return false;
            else
                return true;
        }

        public void has_extended_flags(bool answer)
        {
            return;
        }

        public byte target()
        {
            return _target;
        }
        public void target(byte t)
        {
            _target = t;
            this.has_target(true);
        }

        public byte source()
        {
            return _source;
        }

        public void source(byte s)
        {
            _source = s;
            this.has_source(true);
        }

        public byte target_port()
        {
            return (byte)((_target >> 4) & 0x0f);
        }

        public byte source_port()
        {
            return (byte)((_source >> 4) & 0x0f);
        }

        public byte target_node()
        {
            return (byte)(_target & 0x0f);
        }

        public byte source_node()
        {
            return (byte)(_source & 0x0f);
        }

        public void target_port(byte p)
        {
            _target = (byte)(_target & 0xf0 | p);
        }

        public void source_port(byte p)
        {
            _source = (byte)(_source & 0xf0 | p);
        }

        public void target_node(byte n)
        {
            _target = (byte)(_target & 0x0f | (n << 4));
        }

        public void source_node(byte n)
        {
            _source = (byte)(_source & 0x0f | (n << 4));
        }

        public byte err()
        {
            return error;
        }

        public void err(byte value)
        {
            error = value;
            flags |= Flags.packet_is_response;
        }

        public byte[] serialize()
        {
            int index = 0;

            byte[] b = new byte[16];

            b[index++] = flags;
            if ((flags & Flags.packet_has_target) != 0)
                b[index++] = _target;

            if ((flags & Flags.packet_has_source) != 0)
                b[index++] = _source;

            b[index++] = did;
            b[index++] = cid;
            b[index++] = seq;

            if ((flags & Flags.packet_is_response) != 0)
                b[index++] = error;

            byte[] x = new byte[index];
            for (int i = 0; i < index; i++)
                x[i] = b[i];

            return x;
        }

        public int from_buffer(byte[] h)
        {
            int index = 0;

            flags = h[index++];

            if (this.has_target())
                _target = h[index++];

            if (this.has_source())
                _source = h[index++];

            this.did = h[index++];
            this.cid = h[index++];
            this.seq = h[index++];

            if (this.is_response())
                error = h[index++];

            return index;
        }
    }
}
