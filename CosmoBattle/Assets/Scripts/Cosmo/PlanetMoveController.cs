using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMoveController : MonoBehaviour
{
    public float speedPlanet = 1;
    public float orbita;
    int rx;
    // Start is called before the first frame update
    void Start()
    {
        System.Random ra = new System.Random();
        rx = ra.Next(0, 2) < 1 ? -1 : 1;
        orbita = 0.1f;
        this.gameObject.transform.position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(
                                            (gameObject.transform.position.x + rx * orbita * Mathf.Cos(Mathf.PI * Time.unscaledTime * speedPlanet)), 
                                            (gameObject.transform.position.y + orbita * Mathf.Sin(Mathf.PI * Time.unscaledTime * speedPlanet)), 0);
    }


}
