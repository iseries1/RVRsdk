using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVR
{
    class Commands
    {
        public Message sleep()
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.sleep, SpheroRvrTargets.primary);

            return m;
        }

        public Message wake()
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.wake, SpheroRvrTargets.primary);

            return m;
        }

        public Message get_battery_voltage_state()
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.get_battery_voltage_state, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message on_will_sleep_notify()
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.will_sleep_notify, SpheroRvrTargets.primary);

            return m;
        }
        public Message get_battery_percentage()
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.get_battery_percentage, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_battery_voltage_in_volts(byte readingtype)
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.get_battery_voltage_in_volts, SpheroRvrTargets.primary);
            m.request_response(true);
            m.Pack(readingtype);

            return m;
        }

        public Message enable_battery_voltage_state_change_notify(bool is_enabled)
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.enable_battery_voltage_state_change_notify, SpheroRvrTargets.primary);
            m.Pack(is_enabled);

            return m;
        }

        public Message get_battery_voltage_state_thresholds()
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.get_battery_voltage_state_thresholds, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_current_sense_amplifier_current(byte amplifier_id)
        {
            Message m = new Message(DevicesEnum.power, CommandsEnum.get_current_sense_amplifier_current, SpheroRvrTargets.primary);
            m.request_response(true);
            m.Pack(amplifier_id);

            return m;
        }

        public Message set_all_leds(UInt32 led_group, UInt32[] led_brightness_values)
        {
            Message m = new Message(DevicesEnum.io, CommandsEnum.set_all_leds, SpheroRvrTargets.primary);

            m.Pack(led_group);

            for (int i=0;i<led_brightness_values.Length;i++)
            {
                m.PackColor(led_brightness_values[i]);
            }

            return m;
        }

        public Message get_active_color_palette()
        {
            Message m = new Message(DevicesEnum.io, CommandsEnum.get_active_color_palette, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message set_active_color_palette(byte[] rbg_index_bytes)
        {
            Message m = new Message(DevicesEnum.io, CommandsEnum.set_active_color_palette, SpheroRvrTargets.primary);

            for (int i = 0; i < rbg_index_bytes.Length; i++)
                m.Pack(rbg_index_bytes[i]);

            return m;
        }

        public Message get_color_identification_report(byte red, byte green, byte blue, byte confidence_threshold)
        {
            Message m = new Message(DevicesEnum.io, CommandsEnum.get_color_identification_report, SpheroRvrTargets.primary);
            m.request_response(true);
            m.Pack(red);
            m.Pack(green);
            m.Pack(blue);
            m.Pack(confidence_threshold);

            return m;
        }

        public Message load_color_palette(byte palette_index)
        {
            Message m = new Message(DevicesEnum.io, CommandsEnum.get_color_identification_report, SpheroRvrTargets.primary);
            m.Pack(palette_index);

            return m;
        }

        public Message save_color_palette(byte palette_index)
        {
            Message m = new Message(DevicesEnum.io, CommandsEnum.save_color_palette, SpheroRvrTargets.primary);
            m.Pack(palette_index);

            return m;
        }

        public Message release_led_requests()
        {
            Message m = new Message(DevicesEnum.io, CommandsEnum.release_led_requests, SpheroRvrTargets.primary);

            return m;
        }

        public Message get_bluetooth_advertising_name()
        {
            Message m = new Message(DevicesEnum.connection, CommandsEnum.get_bluetooth_advertising_name, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_main_application_version()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_main_application_version, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_bootloader_version()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_bootloader_version, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_board_revision()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_board_revision, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_mac_address()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_mac_address, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_stats_id()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_stats_id, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_processor_name()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_processor_name, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_sku()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_sku, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message get_core_up_time_in_milliseconds()
        {
            Message m = new Message(DevicesEnum.system_info, CommandsEnum.get_core_up_time_in_milliseconds, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message raw_motors(byte left_mode, byte left_speed, byte right_mode, byte right_speed)
        {
            Message m = new Message(DevicesEnum.drive, CommandsEnum.raw_motors, SpheroRvrTargets.secondary);
            m.Pack(left_mode);
            m.Pack(left_speed);
            m.Pack(right_mode);
            m.Pack(right_speed);

            return m;
        }

        public Message reset_yaw()
        {
            Message m = new Message(DevicesEnum.drive, CommandsEnum.reset_yaw, SpheroRvrTargets.secondary);

            return m;
        }

        public Message drive_with_heading(byte speed, Int16 heading, byte flags)
        {
            Message m = new Message(DevicesEnum.drive, CommandsEnum.drive_with_heading, SpheroRvrTargets.secondary);
            m.Pack(speed);
            m.Pack(heading);
            m.Pack(flags);

            return m;
        }

        public Message enable_motor_stall_notify(bool is_enabled)
        {
            Message m = new Message(DevicesEnum.drive, CommandsEnum.enable_motor_stall_notify, SpheroRvrTargets.secondary);
            m.Pack(is_enabled);

            return m;
        }

        public Message enable_motor_fault_notify(bool is_enabled)
        {
            Message m = new Message(DevicesEnum.drive, CommandsEnum.enable_motor_fault_notify, SpheroRvrTargets.secondary);
            m.Pack(is_enabled);

            return m;
        }

        public Message get_motor_fault_state()
        {
            Message m = new Message(DevicesEnum.drive, CommandsEnum.get_motor_fault_state, SpheroRvrTargets.secondary);
            m.request_response(true);

            return m;
        }

        public Message enable_gyro_max_notify(bool is_enabled)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.enable_gyro_max_notify, SpheroRvrTargets.secondary);
            m.Pack(is_enabled);

            return m;
        }

        public Message reset_locator_x_and_y()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.reset_locator_x_and_y, SpheroRvrTargets.secondary);

            return m;
        }

        public Message set_locator_flags(byte flags)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.set_locator_flags, SpheroRvrTargets.secondary);
            m.Pack(flags);

            return m;
        }

        public Message get_bot_to_bot_infrared_readings()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.get_bot_to_bot_infrared_readings, SpheroRvrTargets.secondary);
            m.request_response(true);

            return m;
        }

        public Message get_rgbc_sensor_values()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.get_rgbc_sensor_values, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message start_robot_to_robot_infrared_broadcasting(byte far_code, byte near_code)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.start_robot_to_robot_infrared_broadcasting, SpheroRvrTargets.secondary);
            m.Pack(far_code);
            m.Pack(near_code);

            return m;
        }

        public Message start_robot_to_robot_infrared_following(byte far_code, byte near_code)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.start_robot_to_robot_infrared_following, SpheroRvrTargets.secondary);
            m.Pack(far_code);
            m.Pack(near_code);

            return m;
        }

        public Message stop_robot_to_robot_infrared_broadcasting()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.stop_robot_to_robot_infrared_broadcasting, SpheroRvrTargets.secondary);

            return m;
        }

        public Message get_ambient_light_sensor_value()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.get_ambient_light_sensor_value, SpheroRvrTargets.primary);
            m.request_response(true);

            return m;
        }

        public Message stop_robot_to_robot_infrared_following()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.start_robot_to_robot_infrared_following, SpheroRvrTargets.secondary);

            return m;
        }

        public Message start_robot_to_robot_infrared_evading(byte far_code, byte near_code)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.start_robot_to_robot_infrared_evading, SpheroRvrTargets.secondary);
            m.Pack(far_code);
            m.Pack(near_code);

            return m;
        }

        public Message stop_robot_to_robot_infrared_evading()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.stop_robot_to_robot_infrared_evading, SpheroRvrTargets.secondary);

            return m;
        }

        public Message enable_color_detection_notify(bool is_enabled, UInt16 interval, byte minimum_confidence_threshold)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.enable_color_detection_notify, SpheroRvrTargets.primary);
            m.Pack(is_enabled);
            m.Pack(interval);
            m.Pack(minimum_confidence_threshold);

            return m;
        }

        public Message get_current_detected_color_reading()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.get_current_detected_color_reading, SpheroRvrTargets.primary);

            return m;
        }

        public Message enable_color_detection(bool is_enabled)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.enable_color_detection, SpheroRvrTargets.primary);
            m.Pack(is_enabled);

            return m;
        }

        public Message configure_streaming_service(byte token, byte[] configuration, byte target)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.configure_streaming_service, target);
            m.Pack(token);
            m.Pack(configuration);

            return m;
        }

        public Message start_streaming_service(UInt16 period, byte target)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.start_streaming_service, target);
            m.Pack(period);

            return m;
        }

        public Message stop_streaming_service(byte target)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.stop_streaming_service, target);

            return m;
        }

        public Message clear_streaming_service(byte target)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.clear_streaming_service, target);

            return m;
        }

        public Message enable_robot_infrared_message_notify(bool is_enabled)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.enable_robot_infrared_message_notify, SpheroRvrTargets.secondary);
            m.Pack(is_enabled);

            return m;
        }

        public Message send_infrared_message(byte infrared_code, byte front_strength, byte left_strength, byte right_strength, byte rear_strength)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.send_infrared_message, SpheroRvrTargets.secondary);
            m.Pack(infrared_code);
            m.Pack(front_strength);
            m.Pack(left_strength);
            m.Pack(right_strength);
            m.Pack(rear_strength);

            return m;
        }

        public Message get_motor_temperature(byte motor_index)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.get_motor_temperature, SpheroRvrTargets.secondary);
            m.request_response(true);
            m.Pack(motor_index);

            return m;
        }

        public Message get_motor_thermal_protection_status()
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.get_motor_thermal_protection_status, SpheroRvrTargets.secondary);
            m.request_response(true);

            return m;
        }

        public Message enable_motor_thermal_protection_status_notify(bool is_enabled)
        {
            Message m = new Message(DevicesEnum.sensor, CommandsEnum.enable_motor_thermal_protection_status_notify, SpheroRvrTargets.secondary);
            m.Pack(is_enabled);

            return m;
        }

    }
}
