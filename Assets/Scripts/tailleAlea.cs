using UnityEngine;
using UnityEngine.SocialPlatforms;

public class tailleAlea : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private Vector3 aleaScale;
    void Start()
    {
       Vector3 aleaScale = transform.localScale;

float randomValue = Random.Range(1f, 2f);

aleaScale = new Vector3(randomValue, randomValue, randomValue);

transform.localScale = aleaScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
