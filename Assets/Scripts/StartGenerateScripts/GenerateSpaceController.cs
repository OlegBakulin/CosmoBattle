using UnityEngine;

public class GenerateSpaceController : MonoBehaviour
{
    public int minColSpaceNull = 4;
    public int maxColSpaceNull = 8;
    public GameObject spaceNullObject;

    public int minSizeSpaceNull = 50;
    public int maxSizeSpaceNull = 100;
    void Start()
    {
        System.Random random = new System.Random();
        int colSpaceNull = random.Next(minColSpaceNull, maxColSpaceNull);
        for (int i = 0; i < colSpaceNull; i++)
        {
            GameObject gameObject = Instantiate<GameObject>(spaceNullObject);
            gameObject.transform.position = new Vector3(random.Next(-300, 300), random.Next(-300, 300), 0);
            gameObject.transform.rotation = new Quaternion(0, 0, random.Next(0, 90), 90);
            gameObject.transform.localScale = new Vector3(random.Next(minSizeSpaceNull, maxSizeSpaceNull), random.Next(minSizeSpaceNull, maxSizeSpaceNull), 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
