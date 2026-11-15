using UnityEngine;

public class MarsSoilCollectibles : MonoBehaviour
{
    //number of mars rock samples colected
    public int marsSoil = 0;

    public void collectMarsJars()
    {
        //increase counter by 1,++
        marsSoil++;

        //display in console
        Debug.Log("Mars Jars: " + marsSoil);
    }
}