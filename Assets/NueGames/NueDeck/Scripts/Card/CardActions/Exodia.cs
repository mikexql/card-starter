// Exodia.cs
using System.Collections.Generic;
using System.Linq;

public static class Exodia
{
    private static readonly HashSet<string> PlayedThisTurn = new HashSet<string>();
    private static readonly string[] Required = { "Exodia_H","Exodia_LA","Exodia_RA","Exodia_LL","Exodia_RL" };

    public static void ResetTurn() => PlayedThisTurn.Clear();
    public static void Mark(string id) { if (!string.IsNullOrEmpty(id)) PlayedThisTurn.Add(id); }
    public static bool Complete() => Required.All(PlayedThisTurn.Contains);
}
