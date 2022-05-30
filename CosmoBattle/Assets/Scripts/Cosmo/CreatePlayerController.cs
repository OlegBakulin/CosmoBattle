using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerController : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        GameObject gameObject = Instantiate<GameObject>(player);

        gameObject.transform.position = new Vector3(random.Next(-100, 100), random.Next(-100, 100), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
