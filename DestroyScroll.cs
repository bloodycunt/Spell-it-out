using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScroll : MonoBehaviour
{
    public GameObject ScrollObj;

       // material shit
        public string[] Ingredients = {
        "Honey",
        "Sugar",
        "Salt",
        "Mushrooms",
        "Eggs",
        "Garlic",
        "Ginger",
        "Snake venom",
        "Dragon scales" };
        public int RandomNum1;
        public int RandomNum2;
        public int RandomNum3;
        public Renderer MatChangeScreen1;
        public Renderer MatChangeScreen2;
        public Renderer MatChangeScreen3;
        public Material Honey;
        public Material Sugar;
        public Material Salt;
        public Material Mushrooms;
        public Material Eggs;
        public Material Garlic;
        public Material Ginger;
        public Material SnakeVenom;
        public Material DragonScales;

  
    public void Start()
    {

    }

    //Collision with the scroll
    void OnTriggerEnter(Collider col)
     {
         if (col.gameObject.name == "Scroll")
         {
             // Destroy
             Debug.Log("DESTROY");
             Destroy(ScrollObj);


            //randomize
            for (int x = 0; x <= Ingredients.Length; x++)
            {
                RandomNum1 = Mathf.RoundToInt(Random.Range(1f, 9f));
                RandomNum2 = Mathf.RoundToInt(Random.Range(1f, 9f));
                RandomNum3 = Mathf.RoundToInt(Random.Range(1f, 9f));

                if (RandomNum1 != RandomNum2 || RandomNum1 != RandomNum3 || RandomNum2 != RandomNum3)
                {

                    switch (RandomNum1)
                    {
                        case 1:
                            MatChangeScreen1.sharedMaterial = Honey;
                            break;
                        case 2:
                            MatChangeScreen1.sharedMaterial = Sugar;
                            break;
                        case 3:
                            MatChangeScreen1.sharedMaterial = Salt;
                            break;
                        case 4:
                            MatChangeScreen1.sharedMaterial = Mushrooms;
                            break;
                        case 5:
                            MatChangeScreen1.sharedMaterial = Eggs;
                            break;
                        case 6:
                            MatChangeScreen1.sharedMaterial = Garlic;
                            break;
                        case 7:
                            MatChangeScreen1.sharedMaterial = Ginger;
                            break;
                        case 8:
                            MatChangeScreen1.sharedMaterial = SnakeVenom;
                            break;
                        case 9:
                            MatChangeScreen1.sharedMaterial = DragonScales;
                            break;
                    }

                    switch (RandomNum2)
                    {
                        case 1:
                            MatChangeScreen2.sharedMaterial = Honey;
                            break;
                        case 2:
                            MatChangeScreen2.sharedMaterial = Sugar;
                            break;
                        case 3:
                            MatChangeScreen2.sharedMaterial = Salt;
                            break;
                        case 4:
                            MatChangeScreen2.sharedMaterial = Mushrooms;
                            break;
                        case 5:
                            MatChangeScreen2.sharedMaterial = Eggs;
                            break;
                        case 6:
                            MatChangeScreen2.sharedMaterial = Garlic;
                            break;
                        case 7:
                            MatChangeScreen2.sharedMaterial = Ginger;
                            break;
                        case 8:
                            MatChangeScreen2.sharedMaterial = SnakeVenom;
                            break;
                        case 9:
                            MatChangeScreen2.sharedMaterial = DragonScales;
                            break;
                    }

                    switch (RandomNum3)
                    {
                        case 1:
                            MatChangeScreen3.sharedMaterial = Honey;
                            break;
                        case 2:
                            MatChangeScreen3.sharedMaterial = Sugar;
                            break;
                        case 3:
                            MatChangeScreen3.sharedMaterial = Salt;
                            break;
                        case 4:
                            MatChangeScreen3.sharedMaterial = Mushrooms;
                            break;
                        case 5:
                            MatChangeScreen3.sharedMaterial = Eggs;
                            break;
                        case 6:
                            MatChangeScreen3.sharedMaterial = Garlic;
                            break;
                        case 7:
                            MatChangeScreen3.sharedMaterial = Ginger;
                            break;
                        case 8:
                            MatChangeScreen3.sharedMaterial = SnakeVenom;
                            break;
                        case 9:
                            MatChangeScreen3.sharedMaterial = DragonScales;
                            break;

                    }

                }
            }
        }


     }
     
}




