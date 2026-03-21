
using System.Text.Json.Serialization;
public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; } = new();
}

public class Feature
{
    public EarthquakeProperties Properties { get; set; } = new();
}

public class EarthquakeProperties
{
  // Change 'double' to 'double?' to handle nulls in the JSON
    public double? Mag { get; set; } 
    public string Place { get; set; } = string.Empty;
}