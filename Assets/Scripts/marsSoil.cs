using UnityEngine;

public class marsSoil : MonoBehaviour
{
    //called whne player touches moon Rock
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MarsSoilCollectibles marsSoilCollectibles = collision.GetComponent<MarsSoilCollectibles>();

        if(marsSoilCollectibles != null)
        {
            //increase the moon token counter
            marsSoilCollectibles.collectMarsJars();
            Debug.Log("Got jar");

            //remove the token after collecting it
            Destroy(gameObject);
        }
    }
}
