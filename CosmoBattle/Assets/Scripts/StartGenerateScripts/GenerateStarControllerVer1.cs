using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Assets.Scripts.StartGenerateScripts.Enums;

namespace Assets.Scripts.StartGenerateScripts
{
    public class StarNew
    {
        public string nameNowStar;
        public Vector3 positionNowStar;
        public int diametrNowStar;
        public Color32 colorNowStar;
    }

    public class GenerateStarControllerVer1 : MonoBehaviour
    {
        public int minRadiys = 50;
        public int maxRadiys = 100;
        GameObject[] enemy;

        public void GeneratStars(GameObject variantStar)
        {

            List<ChanseStar> listVariantStars = ChanseStar.AllChanseParamStars();
            System.Random random = new System.Random();
            int kol = 100;
            for (int s = 0; s < kol; s++)
            {
                int ran = random.Next(100) - 1;
                Vector3 starXYZ = new Vector3(random.Next(-370, 370), random.Next(-370, 370), 0);

                for (int i = 0; i < listVariantStars.Count(); i++)
                {
                    if (listVariantStars[i].chanceRand >= ran)
                    {
                        ran = random.Next(listVariantStars[i].minDiametr, listVariantStars[i].maxDiametr);

                        try
                        {
                            enemy = GameObject.FindGameObjectsWithTag("Star");
                        }
                        catch (Exception)
                        {
                        }

                        if (SearchFirstStar(starXYZ, ran))
                        {
                            GameObject gameObject = Instantiate(variantStar);

                            gameObject.transform.localScale = new Vector3(ran, ran, ran);
                            gameObject.name = listVariantStars[i].nameStar;
                            gameObject.transform.position = starXYZ;
                            gameObject.GetComponent<SpriteRenderer>().color = new Color32(((byte)random.Next(10, 240)), ((byte)random.Next(10, 240)), ((byte)random.Next(10, 240)), ((byte)255));
                        }
                        break;
                    }
                }
            }
        }

        bool SearchFirstStar(Vector3 starXYZ, int diametrs)
        {
            if (enemy == null)
            {
                return true;
            }
            bool trueORfalse = true;
            foreach (GameObject boom in enemy)
            {
                Vector3 enotherStar = boom.transform.position - starXYZ;
                float enotherStarDistance = enotherStar.sqrMagnitude;
                if (
                    (enotherStarDistance < ((starXYZ.x + minRadiys + diametrs) * (starXYZ.x + minRadiys + diametrs)
                    + (starXYZ.y + minRadiys + diametrs) * (starXYZ.y + minRadiys + diametrs)
                    + (starXYZ.z + minRadiys + diametrs) * (starXYZ.z + minRadiys + diametrs)))

                    )
                {
                    return trueORfalse = true;
                }
                else
                {
                    return trueORfalse = false;
                }
            }
            return trueORfalse;

        }

    }

}

