/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */
using Microsoft.VisualBasic.FileIO;
using System.Linq; // Required for sorting

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        
        // Skip the header row
        if (!reader.EndOfData) reader.ReadFields();

        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            
            // Handle potential empty or malformed strings in the points column
            if (int.TryParse(fields[8], out int points))
            {
                // If player exists, add to their total; otherwise, create a new entry
                if (players.ContainsKey(playerId))
                {
                    players[playerId] += points;
                }
                else
                {
                    players[playerId] = points;
                }
            }
        }

        // 1. Convert Dictionary to a List/Array
        // 2. Sort by value (Points) descending
        // 3. Take the top 10
        var topTen = players.OrderByDescending(p => p.Value)
                            .Take(10)
                            .ToList();

        // Display the results in a table format
        Console.WriteLine($"{"Player ID",-15} | {"Total Points",-10}");
        Console.WriteLine(new string('-', 30));
        
        foreach (var player in topTen)
        {
            Console.WriteLine($"{player.Key,-15} | {player.Value,-10}");
        }
    }
}