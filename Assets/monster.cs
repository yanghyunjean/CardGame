using System.Collections.Generic;
using UnityEngine;
using static NewMonoBehaviourScript;

public class monster : MonoBehaviour
{
    List<Human> humans = new List<Human>();

    void Start()
    {
        string[] texts = new string[10];
        List<int> testList = new List<int>();

        Human man2 = new Human();
        man2.name = "맨맨";

        humans.Add(man2);
        humans.Add(new Human());

        for (int i = 0; i < humans.Count; i++)
        {
            Debug.Log(humans[i].name);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.03f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 0.03f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 0.03f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 0.03f;
        }
    }

    public void invite(Human newUser)
    {
        humans.Add(newUser);
    }
}