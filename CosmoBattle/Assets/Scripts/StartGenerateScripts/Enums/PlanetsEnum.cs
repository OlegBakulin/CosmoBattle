using System;
using System.Collections.Generic;
using UnityEngine;

public class Planet
{
    public GameObject TypePlanet;
    public float ChansePlanets;
    public float radiysOrbit;
    public float radiysPlanet;


    public GameObject[] RemovePlanet(List<GameObject> VariantPlanets, List<int> Chanse,
                                            int minRadOrbPlan, int maxRadOrbPlan,
                                            int minDiaPlan, int maxDiaPlan, int kolPlanets)
    {
        System.Random random = new System.Random();
        GameObject[] listPlanets = new GameObject[kolPlanets];

        for (int kol = 0; kol < kolPlanets; kol++)
        {
        ChansePlanets = (random.Next(100, 9999)) / 100;

            #region Вид
            GameObject TypePlanet = VariantPlanets[VariantPlanets.Count - 1];
            float NowChancePlanet = 0;
            for (int i = 0; i < VariantPlanets.Count; i++)
            {
                NowChancePlanet = NowChancePlanet + Chanse[i];
                if (NowChancePlanet >= ChansePlanets)
                {
                    listPlanets[kol] = GameObject.Instantiate(VariantPlanets[i]);
                    break;
                }
            }
            #endregion

            #region Расположение на орбите
            radiysOrbit = (random.Next(minRadOrbPlan * 100, maxRadOrbPlan * 100)) / 100;
            int XplusORminus = (random.Next(0, 2000) > 1000) ? 1 : -1;
            int YplusORminus = (random.Next(0, 2000) > 1000) ? 1 : -1;

            float X = (random.Next(minRadOrbPlan * 100, ((int)radiysOrbit) * 100) / 100) * XplusORminus;

            listPlanets[kol].transform.position = new Vector3(X, (float)Math.Sqrt((Convert.ToDouble((radiysOrbit * radiysOrbit) - (X * X)))) * YplusORminus, 0);
            #endregion

            #region Диаметр планеты
            radiysPlanet = (random.Next(minDiaPlan * 100, maxDiaPlan * 100)) / 100;
            listPlanets[kol].transform.localScale = new Vector3(radiysPlanet, radiysPlanet, 0);
            #endregion

            //listPlanets[kol] = TypePlanet;
        }
        return listPlanets;
    }

}
