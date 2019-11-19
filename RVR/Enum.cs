using System;
using System.Collections.Generic;
using System.Text;

namespace RVR
{
    class Flags
    {
        public const byte packet_is_response = 1;
        public const byte packet_requests_response = 2;
        public const byte packet_requests_response_if_error = 4;
        public const byte packet_is_activity = 8;
        public const byte packet_has_target = 16;
        public const byte packet_has_source = 32;
        public const byte packet_unused_flag_bit = 64;
        public const byte packet_has_more_flags = 128;
    }

    class Packet
    {
        public const byte START_OF_PACKET = 0x8d;
        public const byte END_OF_PACKET = 0xd8;
        public const byte ESCAPE = 0xab;
        public const byte ESCAPED_START = 0x05;
        public const byte ESCAPED_END = 0x50;
        public const byte ESCAPED_ESCAPED = 0x23;
    }
    class ErrorCode
    {
        public const byte success = 0x00;
        public const byte bad_did = 0x01;
        public const byte bad_cid = 0x02;
        public const byte not_yet_implemented = 0x03;
        public const byte restricted = 0x04;
        public const byte bad_data_length = 0x05;
        public const byte failed = 0x06;
        public const byte bad_data_value = 0x07;
        public const byte busy = 0x08;
        public const byte bad_tid = 0x09;
        public const byte target_unavailable = 0x0A;
    }

    class Colors
    {
        public const uint red = 0xFF0000;
        public const uint green = 0x00FF00;
        public const uint blue = 0x0000FF;
        public const uint off = 0x000000;
        public const uint white = 0xFFFFFF;
        public const uint yellow = 0xFF9000;
        public const uint purple = 0xFF00FF;
        public const uint orange = 0xFF2000;
        public const uint pink = 0xFF66B2;
    }

    class InfraredCodes
    {
        public const byte zero = 0;
        public const byte one = 1;
        public const byte two = 2;
        public const byte three = 3;
        public const byte four = 4;
        public const byte five = 5;
        public const byte six = 6;
        public const byte seven = 7;
    }

    class CommandsEnum
    {
        // io did=0x1a
        public const byte set_all_leds = 0x1A;
        public const byte get_active_color_palette = 0x44;
        public const byte set_active_color_palette = 0x45;
        public const byte get_color_identification_report = 0x46;
        public const byte load_color_palette = 0x47;
        public const byte save_color_palette = 0x48;
        public const byte release_led_requests = 0x4E;
        // drive did=0x16
        public const byte raw_motors = 0x01;
        public const byte reset_yaw = 0x06;
        public const byte drive_with_heading = 0x07;
        public const byte enable_motor_stall_notify = 0x25;
        public const byte motor_stall_notify = 0x26;
        public const byte enable_motor_fault_notify = 0x27;
        public const byte motor_fault_notify = 0x28;
        public const byte get_motor_fault_state = 0x29;
        // power did=0x13
        public const byte sleep = 0x01;
        public const byte wake = 0x0D;
        public const byte get_battery_percentage = 0x10;
        public const byte did_awake_notify = 0x11;
        public const byte get_battery_voltage_state = 0x17;
        public const byte will_sleep_notify = 0x19;
        public const byte did_sleep_notify = 0x1A;
        public const byte enable_battery_voltage_state_change_notify = 0x1B;
        public const byte battery_voltage_state_change_notify = 0x1C;
        public const byte get_battery_voltage_in_volts = 0x25;
        public const byte get_battery_voltage_state_thresholds = 0x26;
        public const byte get_current_sense_amplifier_current = 0x27;
        // system did=0x11
        public const byte get_main_application_version = 0x00;
        public const byte get_bootloader_version = 0x01;
        public const byte get_board_revision = 0x03;
        public const byte get_mac_address = 0x06;
        public const byte get_stats_id = 0x13;
        public const byte get_processor_name = 0x1F;
        public const byte get_sku = 0x38;
        public const byte get_core_up_time_in_milliseconds = 0x39;
        // connections did=0x19
        public const byte get_bluetooth_advertising_name = 0x05;
        // api did=0x10
        public const byte echo = 0x00;
        // sensors did=0x18
        public const byte enable_gyro_max_notify = 0x0F;
        public const byte gyro_max_notify = 0x10;
        public const byte reset_locator_x_and_y = 0x13;
        public const byte set_locator_flags = 0x17;
        public const byte get_bot_to_bot_infrared_readings = 0x22;
        public const byte get_rgbc_sensor_values = 0x23;
        public const byte start_robot_to_robot_infrared_broadcasting = 0x27;
        public const byte start_robot_to_robot_infrared_following = 0x28;
        public const byte stop_robot_to_robot_infrared_broadcasting = 0x29;
        public const byte robot_to_robot_infrared_message_received_notify = 0x2C;
        public const byte get_ambient_light_sensor_value = 0x30;
        public const byte stop_robot_to_robot_infrared_following = 0x32;
        public const byte start_robot_to_robot_infrared_evading = 0x33;
        public const byte stop_robot_to_robot_infrared_evading = 0x34;
        public const byte enable_color_detection_notify = 0x35;
        public const byte color_detection_notify = 0x36;
        public const byte get_current_detected_color_reading = 0x37;
        public const byte enable_color_detection = 0x38;
        public const byte configure_streaming_service = 0x39;
        public const byte start_streaming_service = 0x3A;
        public const byte stop_streaming_service = 0x3B;
        public const byte clear_streaming_service = 0x3C;
        public const byte streaming_service_data_notify = 0x3D;
        public const byte enable_robot_infrared_message_notify = 0x3E;
        public const byte send_infrared_message = 0x3F;
        public const byte get_motor_temperature = 0x42;
        public const byte get_motor_thermal_protection_status = 0x4B;
        public const byte enable_motor_thermal_protection_status_notify = 0x4C;
        public const byte motor_thermal_protection_status_notify = 0x4D;
    }

    class DevicesEnum
    {
        public const byte api_and_shell = 0x10;
        public const byte system_info = 0x11;
        public const byte power = 0x13;
        public const byte drive = 0x16;
        public const byte sensor = 0x18;
        public const byte connection = 0x19;
        public const byte io = 0x1A;
    }

    class SpecdrumsColorPaletteIndiciesEnum
    {
        public const byte Default = 0;
        public const byte midi = 1;

    }

    class RawMotorModesEnum
    {
        public const byte off = 0;
        public const byte forward = 1;
        public const byte reverse = 2;
    }

    class MotorIndexesEnum
    {
        public const byte left_motor_index = 0;
        public const byte right_motor_index = 1;
    }

    class ThermalProtectionStatusEnum
    {
        public const byte ok = 0;
        public const byte warn = 1;
        public const byte critical = 2;
    }

    class StreamingDataSizesEnum
    {
        public const byte eight_bit = 0x00;
        public const byte sixteen_bit = 0x01;
        public const byte thirty_two_bit = 0x02;
    }

    class GyroMaxFlagsBitmask
    {
        public const byte none = 0;
        public const byte max_plus_x = 1;
        public const byte max_minus_x = 2;
        public const byte max_plus_y = 4;
        public const byte max_minus_y = 8;
        public const byte max_plus_z = 16;
        public const byte max_minus_z = 32;
    }

    class LocatorFlagsBitmask
    {
        public const byte none = 0;
        public const byte auto_calibrate = 1;
    }

    class InfraredSensorLocationsBitmask
    {
        public const uint none = 0;
        public const uint front_left = 0x000000FF;
        public const uint front_right = 0x0000FF00;
        public const uint back_right = 0x00FF0000;
        public const uint back_left = 0xFF000000;
    }

    class DriveFlagsBitmask
    {
        public const byte none = 0;
        public const byte drive_reverse = 1;
        public const byte boost = 2;
        public const byte fast_turn = 4;
        public const byte left_direction = 8;
        public const byte right_direction = 16;
        public const byte enable_drift = 32;
    }

    class BatteryVoltageStatesEnum
    {
        public const byte unknown = 0;
        public const byte ok = 1;
        public const byte low = 2;
        public const byte critical = 3;
    }

    class BatteryVoltageReadingTypesEnum
    {
        public const byte calibrated_and_filtered = 0;
        public const byte calibrated_and_unfiltered = 1;
        public const byte uncalibrated_and_unfiltered = 2;
    }

    class AmplifierIdsEnum
    {
        public const byte left_motor = 0;
        public const byte right_motor = 1;
    }

    class SpheroRvrTargets
    {
        public const byte primary = 1;
        public const byte secondary = 2;
    }

    class SpheroRvrLedBitmasks
    {
        public const uint right_headlight_red = 0x00000001;
        public const uint right_headlight_green = 0x00000002;
        public const uint right_headlight_blue = 0x00000004;
        public const uint left_headlight_red = 0x00000008;
        public const uint left_headlight_green = 0x00000010;
        public const uint left_headlight_blue = 0x00000020;
        public const uint left_status_indication_red = 0x00000040;
        public const uint left_status_indication_green = 0x00000080;
        public const uint left_status_indication_blue = 0x00000100;
        public const uint right_status_indication_red = 0x00000200;
        public const uint right_status_indication_green = 0x00000400;
        public const uint right_status_indication_blue = 0x00000800;
        public const uint battery_door_rear_red = 0x00001000;
        public const uint battery_door_rear_green = 0x00002000;
        public const uint battery_door_rear_blue = 0x00004000;
        public const uint battery_door_front_red = 0x00008000;
        public const uint battery_door_front_green = 0x00010000;
        public const uint battery_door_front_blue = 0x00020000;
        public const uint power_button_front_red = 0x00040000;
        public const uint power_button_front_green = 0x00080000;
        public const uint power_button_front_blue = 0x00100000;
        public const uint power_button_rear_red = 0x00200000;
        public const uint power_button_rear_green = 0x00400000;
        public const uint power_button_rear_blue = 0x00800000;
        public const uint left_brakelight_red = 0x01000000;
        public const uint left_brakelight_green = 0x02000000;
        public const uint left_brakelight_blue = 0x04000000;
        public const uint right_brakelight_red = 0x08000000;
        public const uint right_brakelight_green = 0x10000000;
        public const uint right_brakelight_blue = 0x20000000;
        public const uint undercarriage_white = 0x40000000;
    }

    class RvrLedGroups
    {
        public const uint status_indication_left = SpheroRvrLedBitmasks.left_status_indication_red |
            SpheroRvrLedBitmasks.left_status_indication_green |
            SpheroRvrLedBitmasks.left_status_indication_blue;
        public const uint status_indication_right = SpheroRvrLedBitmasks.right_status_indication_red |
            SpheroRvrLedBitmasks.right_status_indication_green |
            SpheroRvrLedBitmasks.right_status_indication_blue;
        public const uint headlight_left = SpheroRvrLedBitmasks.left_headlight_red |
            SpheroRvrLedBitmasks.left_headlight_green |
            SpheroRvrLedBitmasks.left_headlight_blue;
        public const uint headlight_right = SpheroRvrLedBitmasks.right_headlight_red |
            SpheroRvrLedBitmasks.right_headlight_green |
            SpheroRvrLedBitmasks.right_headlight_blue;
        public const uint battery_door_front = SpheroRvrLedBitmasks.battery_door_front_red |
            SpheroRvrLedBitmasks.battery_door_front_green |
            SpheroRvrLedBitmasks.battery_door_front_blue;
        public const uint battery_door_rear = SpheroRvrLedBitmasks.battery_door_rear_red |
            SpheroRvrLedBitmasks.battery_door_rear_green |
            SpheroRvrLedBitmasks.battery_door_rear_blue;
        public const uint power_button_front = SpheroRvrLedBitmasks.power_button_front_red |
            SpheroRvrLedBitmasks.power_button_front_green |
            SpheroRvrLedBitmasks.power_button_front_blue;
        public const uint power_button_rear = SpheroRvrLedBitmasks.power_button_rear_red |
            SpheroRvrLedBitmasks.power_button_rear_green |
            SpheroRvrLedBitmasks.power_button_rear_blue;
        public const uint brakelight_left = SpheroRvrLedBitmasks.left_brakelight_red |
            SpheroRvrLedBitmasks.left_brakelight_green |
            SpheroRvrLedBitmasks.left_brakelight_blue;
        public const uint brakelight_right = SpheroRvrLedBitmasks.right_brakelight_red |
            SpheroRvrLedBitmasks.right_brakelight_green |
            SpheroRvrLedBitmasks.right_brakelight_blue;
        public const uint all_lights = status_indication_left |
            status_indication_right |
            headlight_left |
            headlight_right |
            battery_door_front |
            battery_door_rear |
            power_button_front |
            power_button_rear |
            brakelight_left |
            brakelight_right;
    }

    class RvrStreamingServices
    {
        public RVRSensors color_detection = new RVRSensors("ColorDetection", 1, 0x03, SpheroRvrTargets.primary, StreamingDataSizesEnum.eight_bit);
        public RVRSensors ambient_light = new RVRSensors("AmbientLight", 2, 0x0a, SpheroRvrTargets.primary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors quaternion = new RVRSensors("Quaternion", 1, 0x00, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors imu = new RVRSensors("IMU", 1, 0x01, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors accelerometer = new RVRSensors("Accelerometer", 1, 0x02, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors gyroscope = new RVRSensors("Gyroscope", 1, 0x04, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors locator = new RVRSensors("Locator", 2, 0x06, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors velocity = new RVRSensors("Velocity", 2, 0x07, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors speed = new RVRSensors("Speed", 2, 0x08, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors core_time_1 = new RVRSensors("CoreTime 1", 3, 0x09, SpheroRvrTargets.primary, StreamingDataSizesEnum.thirty_two_bit);
        public RVRSensors core_time_2 = new RVRSensors("CoreTime 2", 3, 0x09, SpheroRvrTargets.secondary, StreamingDataSizesEnum.thirty_two_bit);
    }

    class RVRSensors
    {
        public string Name;
        public byte Token;
        public Int16 ID;
        public byte Processor;
        public byte Size;

        public RVRSensors(string name, byte token, Int16 id, byte processor, byte size)
        {
            Name = name;
            Token = token;
            ID = id;
            Processor = processor;
            Size = size;
        }

        public byte[] Packet()
        {
            byte[] b = new byte[3];

            b[0] = (byte)(ID << 8);
            b[1] = (byte)(ID & 0xff);
            b[2] = Size;
            return b;
        }
    }
}
