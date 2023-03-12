using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Name { bear, chimpanzee, dog, elephant, horse, lion, tiger }
public class Animal : MonoBehaviour
{
  
    // Start is called before the first frame update

    public int level;
    public int charm;
    public int health;
    public int condition;
    public int satiety;

    public Name EName;
    public string Animal_name = "";
    public int[] animalMoney = new int[10];

    public static Animal instance;
    private void Awake()
    {
        Animal.instance = this;
    }

    void Start()
    {
        switch (EName)
        {
            case Name.bear:
                Animal_name = "bear";
                animalMoney[0] = 8000;
                animalMoney[1] = 13000;
                animalMoney[2] = 19000;
                animalMoney[3] = 28000;
                animalMoney[4] = 38000;
                animalMoney[5] = 48000;
                animalMoney[6] = 63000;
                animalMoney[7] = 78000;
                animalMoney[8] = 98000;
                animalMoney[9] = 148000;
                break;
            case Name.chimpanzee:
                Animal_name = "chimpanzee";
                animalMoney[0] = 3000;
                animalMoney[1] = 4000;
                animalMoney[2] = 6000;
                animalMoney[3] = 9000;
                animalMoney[4] = 12000;
                animalMoney[5] = 18000;
                animalMoney[6] = 25000;
                animalMoney[7] = 38000;
                animalMoney[8] = 50000;
                animalMoney[9] = 65000;
                break;
            case Name.dog:
                Animal_name = "dog";
                animalMoney[0] = 2000;
                animalMoney[1] = 2500;
                animalMoney[2] = 3000;
                animalMoney[3] = 6000;
                animalMoney[4] = 9000;
                animalMoney[5] = 13000;
                animalMoney[6] = 17000;
                animalMoney[7] = 25000;
                animalMoney[8] = 35000;
                animalMoney[9] = 45000;
                break;
            case Name.elephant:
                Animal_name = "elephant";
                animalMoney[0] = 10000;
                animalMoney[1] = 15000;
                animalMoney[2] = 21000;
                animalMoney[3] = 30000;
                animalMoney[4] = 40000;
                animalMoney[5] = 50000;
                animalMoney[6] = 65000;
                animalMoney[7] = 80000;
                animalMoney[8] = 100000;
                animalMoney[9] = 150000;
                break;
            case Name.horse:
                Animal_name = "horse";
                animalMoney[0] = 8000;
                animalMoney[1] = 13000;
                animalMoney[2] = 19000;
                animalMoney[3] = 28000;
                animalMoney[4] = 38000;
                animalMoney[5] = 48000;
                animalMoney[6] = 55000;
                animalMoney[7] = 65000;
                animalMoney[8] = 88000;
                animalMoney[9] = 118000;
                break;
            case Name.lion:
                Animal_name = "lion";
                animalMoney[0] = 15000;
                animalMoney[1] = 20000;
                animalMoney[2] = 25000;
                animalMoney[3] = 35000;
                animalMoney[4] = 45000;
                animalMoney[5] = 60000;
                animalMoney[6] = 80000;
                animalMoney[7] = 100000;
                animalMoney[8] = 150000;
                animalMoney[9] = 200000;
                break;
            case Name.tiger:
                Animal_name = "tiger";
                animalMoney[0] = 13000;
                animalMoney[1] = 18000;
                animalMoney[2] = 24000;
                animalMoney[3] = 33000;
                animalMoney[4] = 43000;
                animalMoney[5] = 53000;
                animalMoney[6] = 70000;
                animalMoney[7] = 85000;
                animalMoney[8] = 120000;
                animalMoney[9] = 175000;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int expectedProfit()
    {
        return animalMoney[level-1];
    }

}
