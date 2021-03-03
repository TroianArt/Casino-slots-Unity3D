using System.Linq;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    public SpinReel[] reels;

    public void InitiateMotion(SymbolType[] symbols)
    {

        for (int i = 0; i < reels.Length; i++)
        {
            reels[i].StartRotation(symbols[i]);
        }
    }

    public bool AreReelsSpinning()
    {
        return reels.Aggregate(false, (acc, r) => acc || r.IsSpinning());
    }
}
