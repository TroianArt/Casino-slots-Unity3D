using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject[] effectWin;
    public MotionController motionController;
    public Transform pointEffectWin;
    public Button spinBtn;
    private bool win = false;
    private void Start()
    {
        spinBtn.onClick.AddListener((UnityEngine.Events.UnityAction)this.Spin);
    }
    public void Update()
    {
        if (win && CanSpin)
        {
            foreach(var ps in effectWin)
            {
                Instantiate(ps, pointEffectWin);
            }
            win = false;
        }
    }
    public void Spin()
    {

        if (CanSpin)
        {
            SymbolType leftReelSymbol;
            SymbolType midReelSymbol;
            SymbolType rightReelSymbol;

            leftReelSymbol = Symbol.PickRandomSymbol();
            midReelSymbol = Symbol.PickRandomSymbol();
            rightReelSymbol = Symbol.PickRandomSymbol();
            
            
            if (leftReelSymbol == midReelSymbol && leftReelSymbol == rightReelSymbol)
            {
                win = true;
            }
            motionController.InitiateMotion(new []{leftReelSymbol, midReelSymbol, rightReelSymbol});
        }
    }
    private bool CanSpin => !motionController.AreReelsSpinning();

}
