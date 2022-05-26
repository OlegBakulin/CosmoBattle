using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.StartGenerateScripts.Enums
{
    /*
     
    Звезды
    Звезды генерируются случайным образом по карте так, 
    чтобы их границы были не ближе чем 50 единиц и не дальше чем 100 единиц.
    Звезды имеют три размерных вида: 
    Карлики. Диаметр 8-12 единиц
    Средние. Диаметр 15-25 единиц
    Гиганты.  Диаметр 30-50 единиц
    Конкретные размеры случайно определяются в рамках диапазона. 
    Распределение частоты генерации звезд по виду следующее: 
    Карлики  35%
    Средние 50%
    Гиганты 15%

     
    */
    enum StarsNamesEnum
    {
        StarMed,
        StarKar,
        StarGig
    }
    enum StarsChansEnum
    {
        StarMed = 50,
        StarKar = 85,
        StarGig = 100
    }
    enum StarsMinDiamEnum
    {
        StarMed = 15,
        StarKar = 8,
        StarGig = 30
    }
    enum StarsMaxDiamEnum
    {
        StarMed = 25,
        StarKar = 12,
        StarGig = 50
    }

    class ChanseStar
    {
        public string nameStar;
        public int chanceRand;
        public int minDiametr;
        public int maxDiametr;



        public static List<ChanseStar> AllChanseParamStars()
        {
            List<ChanseStar> allStars = new List<ChanseStar>();

            allStars.Add(new ChanseStar()
            {
                nameStar = StarsNamesEnum.StarMed.ToString(),
                chanceRand = ((int)StarsChansEnum.StarMed),
                minDiametr = ((int)StarsMinDiamEnum.StarMed),
                maxDiametr = ((int)StarsMaxDiamEnum.StarMed)
            });

            allStars.Add(new ChanseStar()
            {
                nameStar = StarsNamesEnum.StarKar.ToString(),
                chanceRand = ((int)StarsChansEnum.StarKar),
                minDiametr = ((int)StarsMinDiamEnum.StarKar),
                maxDiametr = ((int)StarsMaxDiamEnum.StarKar)
            });

            allStars.Add(new ChanseStar()
            {
                nameStar = StarsNamesEnum.StarGig.ToString(),
                chanceRand = ((int)StarsChansEnum.StarGig),
                minDiametr = ((int)StarsMinDiamEnum.StarGig),
                maxDiametr = ((int)StarsMaxDiamEnum.StarGig)
            });
            return allStars;
        }

    }



}