using NUnit.Framework;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public class Human : MonoBehaviour
    {
        public string name;
        public int age;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Human man = new Human();
        man.age = 20;

        Human man2 = new Human();
        man2.name = "맨맨";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
