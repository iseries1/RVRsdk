using System;
using System.Collections.Generic;
using System.Text;

namespace RVR
{
    enum rawMotorModes
    {
        off,
        forward,
        reverse,
        brake,
        ignore
    }

    class DriveControl
    {
        bool _isAiming;

        public void aimStart()
        {

        }

        public void aimStop()
        {

        }

        public bool isAiming()
        {
            return true;
        }

        public void resetHeading()
        {

        }

        public void rollStart(UInt16 heading, Int16 speed)
        {

        }

        public void rollStop(UInt16 heading)
        {

        }

        public void setHeading(UInt16 heading)
        {

        }

        public void setRawMotors(rawMotorModes leftMode, Byte leftSpeed, rawMotorModes rightMode, Byte rightSpeed)
        {

        }
    }
}
