using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DynamicProgramming
{
  public class symphony
  {
    public static void Main(String[] args)
    {

      string format = "xml";
      //write code to
      //1. instantiate a Thing
      Thing thing = new Thing((new int[] { 1, 2, 3, 4 }), format);
      //2. Create serialized string representing instance
      var serialized = thing.serialize(thing);
      Console.WriteLine(serialized);
      //3. Create a new Thing from serialized instance
      Thing deserialized = Thing.deserialize(serialized, format);
      //4. Verify two Thing instances have equal contents
      if (thing.nums.SequenceEqual(deserialized.nums))
      {
        Console.WriteLine("The instances content are same");
      }
      else
      {
        Console.WriteLine("The instances content are different");
      }
    }
  }

  public class Thing
  {

    public List<int> nums { get; set; }

    //To keep track of format. This property will be ignored in serialized string.
    [JsonIgnore]
    [XmlIgnore]
    private string format { get; set; } = "json";

    public Thing()
    {

    }
    public Thing(IEnumerable<int> nums, string format)
    {
      this.nums = nums.ToList();
      this.format = format;
    }

    public string serialize(Thing thing)
    {
      // fill out method
      string result = string.Empty;
      if (thing.format == "xml")
      {


        StringWriter writer = new StringWriter();
        XmlSerializer serializer = new XmlSerializer(typeof(Thing));
        serializer.Serialize(writer, thing);
        result = writer.ToString();
        return result;
      }
      else
      {
        result = JsonSerializer.Serialize(thing);
        return result;
      }
      // string format not specified - must work with deserialize method
    }


    //The other way to write deserialize function is to check the "serialized_thing" parameter
    //is a valid json or xml etc. and then perform the deserialization. Here we are taking the desired format as a parameter
    public static Thing deserialize(string serialized_thing, string? format = "")
    {

      // string format not specified - this function should recognize format used by serialize method
      Thing result = new Thing();

      if (!string.IsNullOrEmpty(serialized_thing))
      {
        if (format == "json" || format == "")

        {
          result = JsonSerializer.Deserialize<Thing>(serialized_thing);
        }
        else
        {

          TextReader tr = new StringReader(serialized_thing);
          System.Xml.XmlReader reader = System.Xml.XmlReader.Create(tr);
          XmlSerializer serializer = new XmlSerializer(typeof(Thing));
          if (serializer.CanDeserialize(reader))
          {
            result = (Thing)serializer.Deserialize(reader);
          }

        }
      }
      return result;
    }

  }

}
