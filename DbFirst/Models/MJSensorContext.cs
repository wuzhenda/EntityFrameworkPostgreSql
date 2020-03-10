using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst.Models
{
    public partial class MJSensorContext : DbContext
    {
        public MJSensorContext()
        {
        }

        public MJSensorContext(DbContextOptions<MJSensorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<DeviceInfo> DeviceInfo { get; set; }
        public virtual DbSet<DeviceStatus> DeviceStatus { get; set; }
        public virtual DbSet<EscalatorStatus> EscalatorStatus { get; set; }
        public virtual DbSet<KpiInfrared> KpiInfrared { get; set; }
        public virtual DbSet<KpiPower> KpiPower { get; set; }
        public virtual DbSet<KpiSensor> KpiSensor { get; set; }
        public virtual DbSet<KpiVibration> KpiVibration { get; set; }
        public virtual DbSet<MjsensorDatas> MjsensorDatas { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Readings> Readings { get; set; }
        public virtual DbSet<RtInfrared> RtInfrared { get; set; }
        public virtual DbSet<RtPower> RtPower { get; set; }
        public virtual DbSet<RtSensor> RtSensor { get; set; }
        public virtual DbSet<RtVibration> RtVibration { get; set; }
        public virtual DbSet<SensorConfig> SensorConfig { get; set; }
        public virtual DbSet<SensorStatus> SensorStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=10.0.0.155;Port=15432;Database=mjsensor;Username=postgres;Password=a123.456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("timescaledb");

            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasKey(e => e.BlogId);
            });

            modelBuilder.Entity<DeviceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("device_info");

                entity.Property(e => e.ApiVersion).HasColumnName("api_version");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.Manufacturer).HasColumnName("manufacturer");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.OsName).HasColumnName("os_name");
            });

            modelBuilder.Entity<DeviceStatus>(entity =>
            {
                entity.ToTable("device_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.HdVersion).HasColumnName("hd_version");

                entity.Property(e => e.Manufacturer).HasColumnName("manufacturer");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.SwVersion).HasColumnName("sw_version");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp(0) with time zone");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<EscalatorStatus>(entity =>
            {
                entity.ToTable("escalator_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrakingDistance).HasColumnName("braking_distance");

                entity.Property(e => e.BusbarVoltage).HasColumnName("busbar_voltage");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.HandrailSpeed).HasColumnName("handrail_speed");

                entity.Property(e => e.HighSpeedOperationTime).HasColumnName("high_speed_operation_time");

                entity.Property(e => e.IsAuto).HasColumnName("is_auto");

                entity.Property(e => e.IsBreakOn).HasColumnName("is_break_on");

                entity.Property(e => e.IsDownRunning).HasColumnName("is_down_running");

                entity.Property(e => e.IsEmergencyStop).HasColumnName("is_emergency_stop");

                entity.Property(e => e.IsFault).HasColumnName("is_fault");

                entity.Property(e => e.IsFaultStop).HasColumnName("is_fault_stop");

                entity.Property(e => e.IsFireControl).HasColumnName("is_fire_control");

                entity.Property(e => e.IsLowerCoverOpen).HasColumnName("is_lower_cover_open");

                entity.Property(e => e.IsNormalStop).HasColumnName("is_normal_stop");

                entity.Property(e => e.IsRunning).HasColumnName("is_running");

                entity.Property(e => e.IsSafetyLoopOn).HasColumnName("is_safety_loop_on");

                entity.Property(e => e.IsSuspend).HasColumnName("is_suspend");

                entity.Property(e => e.IsUpRunning).HasColumnName("is_up_running");

                entity.Property(e => e.IsUpperCoverOpen).HasColumnName("is_upper_cover_open");

                entity.Property(e => e.Loadrate).HasColumnName("loadrate");

                entity.Property(e => e.LowSpeedOperationTime).HasColumnName("low_speed_operation_time");

                entity.Property(e => e.OriginalFaultCode).HasColumnName("original_fault_code");

                entity.Property(e => e.Power).HasColumnName("power");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.StepMissingMeasurementSpeed).HasColumnName("step_missing_measurement_speed");

                entity.Property(e => e.TotalOperationTime).HasColumnName("total_operation_time");
            });

            modelBuilder.Entity<KpiInfrared>(entity =>
            {
                entity.ToTable("kpi_infrared");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmbientTempAvg).HasColumnName("ambient_temp_avg");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.InfraredIndex).HasColumnName("infrared_index");

                entity.Property(e => e.ObjTempAvg).HasColumnName("obj_temp_avg");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<KpiPower>(entity =>
            {
                entity.ToTable("kpi_power");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivePowerAAvg).HasColumnName("active_power_a_avg");

                entity.Property(e => e.ActivePowerAPeak).HasColumnName("active_power_a_peak");

                entity.Property(e => e.ActivePowerBAvg).HasColumnName("active_power_b_avg");

                entity.Property(e => e.ActivePowerBPeak).HasColumnName("active_power_b_peak");

                entity.Property(e => e.ActivePowerCAvg).HasColumnName("active_power_c_avg");

                entity.Property(e => e.ActivePowerCPeak).HasColumnName("active_power_c_peak");

                entity.Property(e => e.ActivePowerTotalAvg).HasColumnName("active_power_total_avg");

                entity.Property(e => e.ActivePowerTotalPeak).HasColumnName("active_power_total_peak");

                entity.Property(e => e.ApparentPowerTotalAvg).HasColumnName("apparent_power_total_avg");

                entity.Property(e => e.ApparentPowerTotalPeak).HasColumnName("apparent_power_total_peak");

                entity.Property(e => e.CurrentAAvg).HasColumnName("current_a_avg");

                entity.Property(e => e.CurrentAPeak).HasColumnName("current_a_peak");

                entity.Property(e => e.CurrentBAvg).HasColumnName("current_b_avg");

                entity.Property(e => e.CurrentBPeak).HasColumnName("current_b_peak");

                entity.Property(e => e.CurrentCAvg).HasColumnName("current_c_avg");

                entity.Property(e => e.CurrentCPeak).HasColumnName("current_c_peak");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.PowerFactorTotalAvg).HasColumnName("power_factor_total_avg");

                entity.Property(e => e.ReactivePowerTotalAvg).HasColumnName("reactive_power_total_avg");

                entity.Property(e => e.ReactivePowerTotalPeak).HasColumnName("reactive_power_total_peak");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp(0) with time zone");
            });

            modelBuilder.Entity<KpiSensor>(entity =>
            {
                entity.ToTable("kpi_sensor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.DigitalTemp1).HasColumnName("digital_temp1");

                entity.Property(e => e.DigitalTemp2).HasColumnName("digital_temp2");

                entity.Property(e => e.NoiseDbfsAvg).HasColumnName("noise_dbfs_avg");

                entity.Property(e => e.NoiseDbfsPeak).HasColumnName("noise_dbfs_peak");

                entity.Property(e => e.NoiseDbfsRms).HasColumnName("noise_dbfs_rms");

                entity.Property(e => e.PeopleCounter).HasColumnName("people_counter");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp(0) with time zone");
            });

            modelBuilder.Entity<KpiVibration>(entity =>
            {
                entity.ToTable("kpi_vibration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.ForwardAvg).HasColumnName("forward_avg");

                entity.Property(e => e.ForwardPeak).HasColumnName("forward_peak");

                entity.Property(e => e.ForwardRms).HasColumnName("forward_rms");

                entity.Property(e => e.LateralAvg).HasColumnName("lateral_avg");

                entity.Property(e => e.LateralPeak).HasColumnName("lateral_peak");

                entity.Property(e => e.LateralRms).HasColumnName("lateral_rms");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.VerticalAvg).HasColumnName("vertical_avg");

                entity.Property(e => e.VerticalPeak).HasColumnName("vertical_peak");

                entity.Property(e => e.VerticalRms).HasColumnName("vertical_rms");

                entity.Property(e => e.VibIndex).HasColumnName("vib_index");
            });

            modelBuilder.Entity<MjsensorDatas>(entity =>
            {
                entity.ToTable("MJSensorDatas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime).HasColumnName("dateTime");

                entity.Property(e => e.Deviceid).HasColumnName("deviceid");

                entity.Property(e => e.Kpidata)
                    .IsRequired()
                    .HasColumnName("kpidata");

                entity.Property(e => e.VibrationDatas).HasColumnName("vibrationDatas");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.HasIndex(e => e.BlogId);

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.BlogId);
            });

            modelBuilder.Entity<Readings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("readings");

                entity.HasIndex(e => e.Time)
                    .HasName("readings_time_idx")
                    .HasSortOrder(new[] { SortOrder.Descending });

                entity.HasIndex(e => new { e.DeviceId, e.Time })
                    .HasName("readings_device_id_time_idx")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Descending });

                entity.Property(e => e.BatteryLevel).HasColumnName("battery_level");

                entity.Property(e => e.BatteryStatus).HasColumnName("battery_status");

                entity.Property(e => e.BatteryTemperature).HasColumnName("battery_temperature");

                entity.Property(e => e.Bssid).HasColumnName("bssid");

                entity.Property(e => e.CpuAvg15min).HasColumnName("cpu_avg_15min");

                entity.Property(e => e.CpuAvg1min).HasColumnName("cpu_avg_1min");

                entity.Property(e => e.CpuAvg5min).HasColumnName("cpu_avg_5min");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.MemFree).HasColumnName("mem_free");

                entity.Property(e => e.MemUsed).HasColumnName("mem_used");

                entity.Property(e => e.Rssi).HasColumnName("rssi");

                entity.Property(e => e.Ssid).HasColumnName("ssid");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<RtInfrared>(entity =>
            {
                entity.ToTable("rt_infrared");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmbientTemp).HasColumnName("ambient_temp");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.InfraredIndex).HasColumnName("infrared_index");

                entity.Property(e => e.ObjTemp).HasColumnName("obj_temp");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<RtPower>(entity =>
            {
                entity.ToTable("rt_power");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivePowerA).HasColumnName("active_power_a");

                entity.Property(e => e.ActivePowerB).HasColumnName("active_power_b");

                entity.Property(e => e.ActivePowerC).HasColumnName("active_power_c");

                entity.Property(e => e.ActivePowerTotal).HasColumnName("active_power_total");

                entity.Property(e => e.ApparentPowerTotal).HasColumnName("apparent_power_total");

                entity.Property(e => e.CurrentA).HasColumnName("current_a");

                entity.Property(e => e.CurrentB).HasColumnName("current_b");

                entity.Property(e => e.CurrentC).HasColumnName("current_c");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.PowerConsumptionTotal).HasColumnName("power_consumption_total");

                entity.Property(e => e.PowerFactorTotal).HasColumnName("power_factor_total");

                entity.Property(e => e.ReactivePowerTotal).HasColumnName("reactive_power_total");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp(0) with time zone");

                entity.Property(e => e.VoltageA).HasColumnName("voltage_a");

                entity.Property(e => e.VoltageB).HasColumnName("voltage_b");

                entity.Property(e => e.VoltageC).HasColumnName("voltage_c");
            });

            modelBuilder.Entity<RtSensor>(entity =>
            {
                entity.ToTable("rt_sensor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.DigitalTemp1).HasColumnName("digital_temp1");

                entity.Property(e => e.DigitalTemp2).HasColumnName("digital_temp2");

                entity.Property(e => e.Noise).HasColumnName("noise");

                entity.Property(e => e.PeopleCounter).HasColumnName("people_counter");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp(0) with time zone");
            });

            modelBuilder.Entity<RtVibration>(entity =>
            {
                entity.ToTable("rt_vibration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.Forward).HasColumnName("forward");

                entity.Property(e => e.Lateral).HasColumnName("lateral");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Vertical).HasColumnName("vertical");

                entity.Property(e => e.VibIndex).HasColumnName("vib_index");
            });

            modelBuilder.Entity<SensorConfig>(entity =>
            {
                entity.ToTable("sensor_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.KpiInterval).HasColumnName("kpi_interval");

                entity.Property(e => e.Reserved).HasColumnName("reserved");
            });

            modelBuilder.Entity<SensorStatus>(entity =>
            {
                entity.ToTable("sensor_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DigitalTemp1).HasColumnName("digital_temp1");

                entity.Property(e => e.DigitalTemp2).HasColumnName("digital_temp2");

                entity.Property(e => e.Infrared1).HasColumnName("infrared1");

                entity.Property(e => e.Infrared2).HasColumnName("infrared2");

                entity.Property(e => e.Noise).HasColumnName("noise");

                entity.Property(e => e.Power).HasColumnName("power");

                entity.Property(e => e.Vibration1).HasColumnName("vibration1");

                entity.Property(e => e.Vibration10).HasColumnName("vibration10");

                entity.Property(e => e.Vibration2).HasColumnName("vibration2");

                entity.Property(e => e.Vibration3).HasColumnName("vibration3");

                entity.Property(e => e.Vibration4).HasColumnName("vibration4");

                entity.Property(e => e.Vibration5).HasColumnName("vibration5");

                entity.Property(e => e.Vibration6).HasColumnName("vibration6");

                entity.Property(e => e.Vibration7).HasColumnName("vibration7");

                entity.Property(e => e.Vibration8).HasColumnName("vibration8");

                entity.Property(e => e.Vibration9).HasColumnName("vibration9");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
