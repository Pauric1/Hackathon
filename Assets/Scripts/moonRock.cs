using UnityEngine;

public class moonRock : MonoBehaviour
{
    //called whne player touches moon Rock
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MoonRockCollectibles moonRockCollectibles = collision.GetComponent<MoonRockCollectibles>();

        if(moonRockCollectibles != null)
        {
            //increase the moon token counter
            moonRockCollectibles.collectMoonRocks();

            //remove the token after collecting it
            Destroy(gameObject);
        }
    }
}
