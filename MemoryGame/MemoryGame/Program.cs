using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Stap 1: Woorden array maken
        string[] words = CreateWordArray();

        // Stap 2: Mogelijke gridformaten genereren
        int[,] formats = GenerateAllPossibleFormats(words);

        // Stap 3: Gridformaat laten kiezen door de speler
        int[] chosenFormat = ChooseMemoryGridDimensions(formats);
        int numberOfRows = chosenFormat[0];
        int numberOfColumns = chosenFormat[1];

        // Stap 4: Woorden verdubbelen
        string[] dubbleWordArray = DuplicateWordsInArray(words);

        // Stap 5: Woorden schudden
        ShuffleArray(dubbleWordArray);

        // Stap 6: Memory Grid initialiseren
        string[,] memoryGrid = FillGridWithArray(dubbleWordArray, numberOfRows, numberOfColumns);

        // Stap 7: Gevonden-status bijhouden
        bool[,] isWordFound = new bool[numberOfRows, numberOfColumns];

        // Start de game loop
        while (!AreAllValuesTrue(isWordFound))
        {
            // Stap 8: Toon Memory Grid
            ShowMemoryGrid(memoryGrid, isWordFound);

            // Stap 9: Vraag om coördinaten
            Console.WriteLine("Kies de eerste kaart:");
            int[] coord1 = PromptCoordinates(numberOfRows, numberOfColumns);
            Console.Clear();

            // Stap 10: Toon de gekozen coördinaten aan de gebruiker 
            ShowTempWordsAndMemoryGrid(memoryGrid, isWordFound, coord1);
            Console.WriteLine("Kies de tweede kaart:");
            int[] coord2 = PromptCoordinates(numberOfRows, numberOfColumns);

            // Toon tijdelijk de kaarten (overloaded method)
            Console.Clear();
            ShowTempWordsAndMemoryGrid(memoryGrid, isWordFound, coord1, coord2);

            // Controleer of er een match is
            if (memoryGrid[coord1[0], coord1[1]].Equals(memoryGrid[coord2[0], coord2[1]]))
            {
                // Bewaar in de isWordFound array dat de woorden met de gegeven coördinaten niet meer gevonden moeten worden
                Console.WriteLine("Match gevonden!");
                isWordFound[coord1[0], coord1[1]] = true;
                isWordFound[coord2[0], coord2[1]] = true;
            }
            else
            {
                Console.WriteLine("Geen match. Probeer opnieuw.");
            }

            Console.WriteLine("Druk op een toets om verder te gaan...");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("Gefeliciteerd, je hebt alle paren gevonden!");
    }

    // Stap 1: Woordenarray maken
    static string[] CreateWordArray()
    {
        throw new NotImplementedException();
    }

    // Stap 2: Mogelijke gridformaten genereren
    static int[,] GenerateAllPossibleFormats(string[] singleWordArray)
    {
        throw new NotImplementedException();
    }

    // Stap 3: Gridformaat kiezen
    static int[] ChooseMemoryGridDimensions(int[,] formats)
    {
        throw new NotImplementedException();
    }

    // Stap 4: Woorden verdubbelen
    static string[] DuplicateWordsInArray(string[] words)
    {
        throw new NotImplementedException();

    }

    // Stap 5: Woorden schudden
    static void ShuffleArray(string[] array)
    {
        throw new NotImplementedException();
    }

    // Stap 6: Grid vullen
    static string[,] FillGridWithArray(string[] words, int rows, int cols)
    {
        throw new NotImplementedException();
    }

    // Stap 7: Alle kaarten gevonden?
    static bool AreAllValuesTrue(bool[,] isFound)
    {
        throw new NotImplementedException();
    }

    // Stap 8: Memory grid tonen
    static void ShowMemoryGrid(string[,] grid, bool[,] isFound)
    {
        throw new NotImplementedException();
    }

    // Stap 9: Vraag om coördinaten
    static int[] PromptCoordinates(int rows, int cols)
    {
        throw new NotImplementedException();
    }

    // Stap 10: Tijdelijke woorden tonen
    static void ShowTempWordsAndMemoryGrid(string[,] grid, bool[,] isFound, int[] coord1, int[] coord2)
    {
        throw new NotImplementedException();
    }
    // Stap 10
    static void ShowTempWordsAndMemoryGrid(string[,] grid, bool[,] isFound, int[] coord1)
    {
        throw new NotImplementedException();
    }
}