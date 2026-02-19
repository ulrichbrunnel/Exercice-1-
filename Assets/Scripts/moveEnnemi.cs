using UnityEngine;

public class moveEnnemi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float startPosy;
    public float speed;
    void Start()
    {
        startPosy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (transform.position.x,transform.position.y - speed*Time.deltaTime,transform.position.z);
        if (transform.position.y< -5)
        {
            transform.position = new Vector3 (transform.position.x,startPosy,transform.position.z);
        }
        float scale = Mathf.PingPong(Time.time, 2f);

transform.localScale = new Vector3(scale, scale, scale);

    }
}
