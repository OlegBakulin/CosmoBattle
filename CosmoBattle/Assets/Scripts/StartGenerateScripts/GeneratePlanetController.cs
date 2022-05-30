using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlanetController : MonoBehaviour
{
    public List<GameObject> VariantPlanets;
    public List<int> Chanse;
    public int minRadOrbPlan = 10;
    public int maxRadOrbPlan = 70;
    public int minDiaPlan = 3;
    public int maxDiaPlan = 5;

    class SortPlanet
    {
        public int CH;
        public GameObject PL;

        public SortPlanet(int CH, GameObject PL)
        {
            this.CH = CH;
            this.PL = PL;
        }
    }
// Start is called before the first frame update
void Start()
    {
        List<SortPlanet> sortPlanets = new List<SortPlanet>();
        for(int i = 0; i < VariantPlanets.Count; i++)
        {
            sortPlanets.Add(new SortPlanet(Chanse[i], VariantPlanets[i]));
        }

        sortPlanets.Sort((e1, e2) =>
        {
            return e1.CH.CompareTo(e2.CH);
        });

        for (int i = 0; i < sortPlanets.Count; i++) 
        {
            VariantPlanets[i] = sortPlanets[i].PL;
            Chanse[i] = sortPlanets[i].CH;
        }
        
        System.Random random = new System.Random();

        int kolPlanets = random.Next(100, 400) / 100;
        Planet planets = new Planet();
        GameObject[] listPlanets = planets.RemovePlanet(VariantPlanets, Chanse, minRadOrbPlan, maxRadOrbPlan, minDiaPlan, maxDiaPlan, kolPlanets);

        for (int i = 0; i < kolPlanets; i++)
        {
            listPlanets[i].transform.position = gameObject.transform.position + listPlanets[i].transform.position;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
