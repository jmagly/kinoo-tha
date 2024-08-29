namespace Kinoo.THA.Models;

using System;

using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;

using Kinoo.THA.Json;

public class WandEvent
{
    [Name("id")]
    public int Id { get; set; }

    [Name("event_id")]
    public int EventId { get; set; }

    [Name("wand_identifier")]
    public required string WandIdentifier { get; set; }

    [Name("source")]
    public required string Source { get; set; }

    [Name("source_identifier")]
    public string? SourceIdentifier { get; set; }

    [Name("action")]
    public required string Action { get; set; }

    [Name("action_data")]
    //[JsonConverter(typeof(StringFieldToJsonConverter))]
    public string? ActionData { get; set; }

    [Name("session_id")]
    public required string SessionId { get; set; }

    [Name("activity_id")]
    public string? ActivityId { get; set; }

    [Name("activity_session_id")]
    public required int ActivitySessionId { get; set; }

    [Name("firmware_version")]
    public required string FirmwareVersion { get; set; }

    [Name("hardware_version")]
    public required string HardwareVersion { get; set; }

    [Name("bi_version")]
    public required string BiVersion { get; set; }

    [Name("battery_capacity")]
    public required int BatteryCapacity { get; set; }

    [Name("maximum_calculated_capacity_mah")]
    public required int MaximumCalculatedCapacityMah { get; set; }

    [Name("current_capacity_mah")]
    public required int CurrentCapacityMah { get; set; }

    [Name("current_ma")]
    public required int CurrentMa { get; set; }

    [Name("rssi")]
    public required int Rssi { get; set; }

    [Name("mac_address")]
    public required string MacAddress { get; set; }

    [Name("log")]
    public required string Log { get; set; }

    [Name("micro_seconds_since_boot")]
    public required long MicroSecondsSinceBoot { get; set; }

    [Name("timestamp")]
    public required DateTime Timestamp { get; set; }

    [Name("inserted_at")]
    public required DateTime InsertedAt { get; set; }
}