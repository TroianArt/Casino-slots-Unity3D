using System.Collections.Generic;
using UnityEngine;

public static class Symbol
{
    public static readonly Dictionary<SymbolType, int> SymbolMetadata =
        new Dictionary<SymbolType, int>()
        {
            {SymbolType.Type1, 0},
            {SymbolType.Type2, 60},
            {SymbolType.Type3, 120},
            {SymbolType.Type4, 180},
            {SymbolType.Type5, 240},
            {SymbolType.Type6, 300}
        };

    public static SymbolType PickRandomSymbol()
    {
        return (SymbolType)Random.Range(0, 5);
    }
}
