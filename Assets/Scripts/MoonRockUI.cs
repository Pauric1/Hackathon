using UnityEngine;
using TMPro;

public class MoonRockUI : MonoBehaviour
{
    //reference to collecibles script
    public MoonRockCollectibles moonRockCollectibles;

    //ref to the counter text
    public TMP_Text rockCounterText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //show starting counter amount
        rockCounterText.text = moonRockCollectibles.moonRocks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //update ROCK counter when collecting mon rocks
        rockCounterText.text = moonRockCollectibles.moonRocks.ToString();
    }
}
