using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectForAcademy : MonoBehaviour
{
    [SerializeField] private int firstNumber;
    [SerializeField] private int lastNumber;

    void Start()
    {
        FindingCoefficient(5, 83); //Fonksiyon çağırma
    }

    void FindingCoefficient(int startNumber, int endNumber)
    {
        string divisibleBy2Numbers = ""; 
        string divisibleBy3Numbers = "";   //Tam bölünen sayıları tutmak için bir string
        string divisibleBy4Numbers = ""; 
        string divisibleBy5Numbers = ""; 

        while (startNumber <= endNumber)
        {
            if (startNumber % 2 == 0)
            {
                divisibleBy2Numbers += startNumber + "-";
            }

            if (startNumber % 3 == 0)
            {
                divisibleBy3Numbers += startNumber + "-";             //Mevcut sayı hangi sayıya tam bölünüyorsa sağ tarafına "-" işareti konarak memory'ye yazdırılır.
            }

            if (startNumber % 4 == 0)
            {
                divisibleBy4Numbers += startNumber + "-";
            }

            if (startNumber % 5 == 0)
            {
                divisibleBy5Numbers += startNumber + "-";
            }

            startNumber++;
        }

        if (divisibleBy2Numbers.Length > 0)
        {
            print("Exact divisible by 2: " + divisibleBy2Numbers);
        }

        if (divisibleBy3Numbers.Length > 0)
        {
            print("Exact divisible by 3: " + divisibleBy3Numbers);    //Memoryde tutulan sayılar sol tarafına "2/3/4/5'e tam bölünenler:" şeklinde açıklama ile birlikte çıktısı alınıyor.
        }

        if (divisibleBy4Numbers.Length > 0)
        {
            print("Exact divisible by 4: " + divisibleBy4Numbers);
        }

        if (divisibleBy5Numbers.Length > 0)
        {
            print("Exact divisible by 5: " + divisibleBy5Numbers);
        }
    }
}
