using UnityEngine;

public class MoonRockCollectibles : MonoBehaviour
{
    //number of moon rock samples colected
    public int moonRocks = 0;

    public void collectMoonRocks()
    {
        //increase counter by 1,++
        moonRocks++;

        //display in console
        Debug.Log("Moon Rocks: " + moonRocks);
    }
}