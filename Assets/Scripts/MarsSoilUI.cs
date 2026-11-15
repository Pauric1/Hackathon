using UnityEngine;
using TMPro;

public class MarsSoilUI : MonoBehaviour
{
    //reference to collecibles script
    public MarsSoilCollectibles marsSoilCollectibles;

    //ref to the counter text
    public TMP_Text jarsCounterText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //show starting counter amount
        jarsCounterText.text = marsSoilCollectibles.marsSoil.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //update ROCK counter when collecting mon rocks
        jarsCounterText.text = marsSoilCollectibles.marsSoil.ToString();
    }
}
