using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    //number of mars jars needed 7
    public int requiredMarsJars = 7;

    //name of the next level
    public string nextLevelName = "MainMenu";

    //called when the player enters the gate
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if the wolf entered
        MarsSoilCollectibles marsSoilCollectibles = collision.GetComponent<MarsSoilCollectibles>();

        if (marsSoilCollectibles != null)
        {
            //check if all collectibles have been collected
            if (marsSoilCollectibles.marsSoil >= requiredMarsJars)
            {
                Debug.Log("Player ENTERED Main menu!");

                //load the second level
                SceneManager.LoadScene(nextLevelName);
            }
        }
    }
}
