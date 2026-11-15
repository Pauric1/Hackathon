using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Entrance : MonoBehaviour
{
    //number of moon rocks needed 6
    public int requiredMoonRocks = 6;

    //name of the next level
    public string nextLevelName = "Lv3Mars";

    //called when the player enters the gate
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if the wolf entered
        MoonRockCollectibles moonRockCollectibles = collision.GetComponent<MoonRockCollectibles>();

        if (moonRockCollectibles != null)
        {
            //check if all collectibles have been collected
            if (moonRockCollectibles.moonRocks >= requiredMoonRocks)
            {
                Debug.Log("Player ENTERED LEVEL 3!");

                //load the second level
                SceneManager.LoadScene(nextLevelName);
            }
        }
    }
}