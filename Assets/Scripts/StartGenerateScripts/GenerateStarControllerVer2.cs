using Assets.Scripts.StartGenerateScripts.Enums;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Assets.Scripts.StartGenerateScripts
{
    public class StarNewClass
    {
        public string nameNowStar;
        public Vector3 positionNowStar;
        public int diametrNowStar;
        public Color32 colorNowStar;
    }

    public class GenerateStarControllerVer2 : MonoBehaviour
    {
        public int minRadiys = 50;
        public int maxRadiys = 100;
        GameObject[] enemy;
        System.Random random;
        public List<GameObject> GeneratStars(GameObject variantStar)
        {
            List<ChanseStar> listVariantStars = ChanseStar.AllChanseParamStars();
            List<GameObject> STARS = new List<GameObject>();
            /*
            for (int s = 0; s < kol; s++)
            {
                // variantStar;
                int ran = random.Next(100) - 1;
                Vector3 starXYZ = new Vector3(random.Next(-350, 350), random.Next(-350, 350), 0);
                StarNew nowStar = new StarNew();
                bool cikl = true;

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
                            STARS.Add(gameObject);

                            gameObject.transform.localScale = new Vector3(ran, ran, ran);
                            gameObject.name = listVariantStars[i].nameStar;
                            gameObject.transform.position = starXYZ;
                            gameObject.GetComponent<SpriteRenderer>().color = new Color32(((byte)random.Next(10, 240)), ((byte)random.Next(10, 240)), ((byte)random.Next(10, 240)), ((byte)255));
                        }
                        break;
                    }
                }
                //Instantiate(variantStar);

                //nowStar = SearchFirstStar(nowStar);
            
            }*/
            return STARS;
        }
        private void RecursGenerateStar(GameObject variantStar, List<ChanseStar> listVariantStars, Vector3 coordinateStar)
        {
            if (coordinateStar.x < -350 || coordinateStar.x > 350 || coordinateStar.y < -350 || coordinateStar.y > 350)
            {
                return;
            }
            else
            {
                int ran = random.Next(100) - 1;
                for (int i = 0; i < listVariantStars.Count(); i++)
                {
                    if (listVariantStars[i].chanceRand >= ran)
                    {


                        ran = random.Next(listVariantStars[i].minDiametr, listVariantStars[i].maxDiametr);
                        if (SearchFirstStar(coordinateStar, ran))
                        {
                            GameObject gameObject = Instantiate(variantStar);

                            gameObject.transform.localScale = new Vector3(ran, ran, ran);
                            gameObject.name = listVariantStars[i].nameStar;
                            gameObject.transform.position = coordinateStar + new Vector3(ran, ran, 0);
                            gameObject.GetComponent<SpriteRenderer>().color = new Color32(((byte)random.Next(10, 240)), ((byte)random.Next(10, 240)), ((byte)random.Next(10, 240)), ((byte)255));
                        }
                    }
                }
            }



        }

        bool SearchFirstStar(Vector3 starXYZ, int diametrs)
        {
            GameObject searcObject = new GameObject();
            searcObject.transform.position = starXYZ;
            searcObject.AddComponent<SphereCollider>();
            /*
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
            }*/

            return true;

        }

    }

}
