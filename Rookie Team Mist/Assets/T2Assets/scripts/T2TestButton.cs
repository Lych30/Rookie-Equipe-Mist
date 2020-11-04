using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T2TestButton : MonoBehaviour
{
    [SerializeField] Button[] Boutton;
    [SerializeField] Button[] Boutton2;
    [SerializeField] Button[] Boutton3;
    [SerializeField] GameObject SpawnPoint;
    [SerializeField] GameObject SpawnPoint2;
    [SerializeField] GameObject SpawnPoint3;
    [SerializeField] Button[] BouttonCree1;
    public int rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 4);
        switch (rand)
        {
            
            case 1:
                Instantiate(Boutton[0], SpawnPoint.transform.position, Quaternion.identity);
                GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                rand = Random.Range(2, 4);
                if(rand == 2)
                {
                    Instantiate(Boutton2[0], SpawnPoint2.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                    Instantiate(Boutton3[0], SpawnPoint3.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                }
                else
                {
                    Instantiate(Boutton2[0], SpawnPoint3.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                    Instantiate(Boutton3[0], SpawnPoint2.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                }

                break;
            case 2:
                Instantiate(Boutton[0], SpawnPoint2.transform.position, Quaternion.identity);
                GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                rand = Random.Range(2, 4);
                if (rand == 2)
                {
                    Instantiate(Boutton2[0], SpawnPoint.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                    Instantiate(Boutton3[0], SpawnPoint3.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                }
                else
                {
                    Instantiate(Boutton2[0], SpawnPoint3.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                    Instantiate(Boutton3[0], SpawnPoint.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                }

                break;
            case 3:
                Instantiate(Boutton[0], SpawnPoint3.transform.position, Quaternion.identity);
                GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                rand = Random.Range(2, 4);
                if (rand == 2)
                {
                    Instantiate(Boutton2[0], SpawnPoint2.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                    Instantiate(Boutton3[0], SpawnPoint.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                }
                else
                {
                    Instantiate(Boutton2[0], SpawnPoint.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                    Instantiate(Boutton3[0], SpawnPoint2.transform.position, Quaternion.identity);
                    GameObject.FindObjectOfType<Button>().transform.parent = gameObject.transform;
                }
                break;
        }

    }

}
