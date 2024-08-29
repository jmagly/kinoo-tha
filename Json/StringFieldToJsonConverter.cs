namespace Kinoo.THA.Json;

// Would prefer to get the json field in the set formatted correctly but I have an error in here, I'm not sure what it is.
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class StringFieldToJsonConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(string);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.Value is string jsonString && IsValidJson(jsonString))
        {
            return JObject.Parse(jsonString);
        }

        return JObject.Parse("{}");
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString());
    }

    private bool IsValidJson(string jsonString)
    {
        try
        {
            JObject.Parse(jsonString);
            return true;
        }
        catch (JsonReaderException)
        {
            return false;
        }
    }
}