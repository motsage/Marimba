using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{

    public GameObject[] highlighter;
    int countC, countD, countE, countA, countF, countG, countGG = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "C")
        {
            if (countC == 0)
            {
                hideMesh();
                highlighter[9].GetComponent<BoxCollider>().enabled = true;
                highlighter[9].GetComponent<MeshRenderer>().enabled = true;
                countC++;
            }
            else
            if (countC == 1)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
                countC++;
            }
            else
            if (countC == 2)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
                countC++;
            }
            else
            if (countC == 3)
            {
                hideMesh();
                highlighter[9].GetComponent<BoxCollider>().enabled = true;
                highlighter[9].GetComponent<MeshRenderer>().enabled = true;
                countC++;
            }
            else
            if (countC == 4)
            {
                hideMesh();

                highlighter[13].GetComponent<BoxCollider>().enabled = true;
                highlighter[13].GetComponent<MeshRenderer>().enabled = true;

                countC++;
            }
            else
            if (countC == 5)
            {
                hideMesh();
                highlighter[9].GetComponent<BoxCollider>().enabled = true;
                highlighter[9].GetComponent<MeshRenderer>().enabled = true;
                countC++;
            }
            else
            if (countC == 6)
            {
                hideMesh();
                highlighter[9].GetComponent<BoxCollider>().enabled = true;
                highlighter[9].GetComponent<MeshRenderer>().enabled = true;
                countC++;
            }

        }
        else if (other.name == "D")
        {
            if (countD == 0)
            {
                hideMesh();
                highlighter[10].GetComponent<BoxCollider>().enabled = true;
                highlighter[10].GetComponent<MeshRenderer>().enabled = true;
                countD++;
            }
            else if (countD == 1)
            {
                hideMesh();
                highlighter[10].GetComponent<BoxCollider>().enabled = true;
                highlighter[10].GetComponent<MeshRenderer>().enabled = true;
                countD++;
            }
            else if (countD == 2)
            {
                hideMesh();
                highlighter[5].GetComponent<BoxCollider>().enabled = true;
                highlighter[5].GetComponent<MeshRenderer>().enabled = true;
                countD++;
            }
            else if (countD == 2)
            {
                hideMesh();
                highlighter[5].GetComponent<BoxCollider>().enabled = true;
                highlighter[5].GetComponent<MeshRenderer>().enabled = true;
                countD++;
            }

        }
        else if (other.name == "E")
        {
            if (countE == 0)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
                countE++;
            }
            else if (countE == 1)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
                countE++;
            }
            else
            if (countE == 2)
            {
                hideMesh();
                highlighter[11].GetComponent<BoxCollider>().enabled = true;
                highlighter[11].GetComponent<MeshRenderer>().enabled = true;
                countE++;
            }
            else
            if (countE == 3)
            {
                hideMesh();
                highlighter[11].GetComponent<BoxCollider>().enabled = true;
                highlighter[11].GetComponent<MeshRenderer>().enabled = true;
                countE++;
            }
            else
            if (countE == 4)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
                countE++;
            }
            if (countE == 5)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
                countE++;
            }


        }
        else if (other.name == "F")
        {
            if (countF == 0)
            {
                hideMesh();
                highlighter[13].GetComponent<BoxCollider>().enabled = true;
                highlighter[13].GetComponent<MeshRenderer>().enabled = true;
                countF++;
            }
            else if (countF == 1)
            {
                hideMesh();
                highlighter[13].GetComponent<BoxCollider>().enabled = true;
                highlighter[13].GetComponent<MeshRenderer>().enabled = true;
                countF++;
            }
            else if (countF == 2)
            {
                hideMesh();
                highlighter[10].GetComponent<BoxCollider>().enabled = true;
                highlighter[10].GetComponent<MeshRenderer>().enabled = true;
                countF++;
            }
            else if (countF == 3)
            {
                hideMesh();
                highlighter[11].GetComponent<BoxCollider>().enabled = true;
                highlighter[11].GetComponent<MeshRenderer>().enabled = true;
                countF++;
            }
            else if (countF == 4)
            {
                hideMesh();
                highlighter[11].GetComponent<BoxCollider>().enabled = true;
                highlighter[11].GetComponent<MeshRenderer>().enabled = true;
                countF++;
            }

        }
        else if (other.name == "G")
        {
            if (countG == 0)
            {
                hideMesh();
                highlighter[10].GetComponent<BoxCollider>().enabled = true;
                highlighter[10].GetComponent<MeshRenderer>().enabled = true;
                countG++;
            }
            else if (countG == 1)
            {
                hideMesh();
                highlighter[13].GetComponent<BoxCollider>().enabled = true;
                highlighter[13].GetComponent<MeshRenderer>().enabled = true;
                countG++;
            }
            else if (countG == 2)
            {
                hideMesh();
                highlighter[14].GetComponent<BoxCollider>().enabled = true;
                highlighter[14].GetComponent<MeshRenderer>().enabled = true;
                countG++;
            }
            else if (countG == 3)
            {
                hideMesh();
                highlighter[11].GetComponent<BoxCollider>().enabled = true;
                highlighter[11].GetComponent<MeshRenderer>().enabled = true;
                countG++;
            }
            else if (countG == 4)
            {
                hideMesh();
                highlighter[14].GetComponent<BoxCollider>().enabled = true;
                highlighter[14].GetComponent<MeshRenderer>().enabled = true;
                countG++;
            }
            else if (countG == 5)
            {
                hideMesh();
                highlighter[11].GetComponent<BoxCollider>().enabled = true;
                highlighter[11].GetComponent<MeshRenderer>().enabled = true;
                countG++;
            }

        }
        else if (other.name == "A")
        {
            hideMesh();
            highlighter[13].GetComponent<BoxCollider>().enabled = true;
            highlighter[13].GetComponent<MeshRenderer>().enabled = true;
        }
        else if (other.name == "6")
        {
            if (countGG == 0)
            {
                hideMesh();
                highlighter[13].GetComponent<BoxCollider>().enabled = true;
                highlighter[13].GetComponent<MeshRenderer>().enabled = true;
            }
            else if (countGG == 1)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
            }
            else if (countGG == 2)
            {
                hideMesh();
                highlighter[8].GetComponent<BoxCollider>().enabled = true;
                highlighter[8].GetComponent<MeshRenderer>().enabled = true;
            }

        }

    }

    void hideMesh()
    {
        for (int x = 0; x < highlighter.Length; x++)
        {
            highlighter[x].GetComponent<BoxCollider>().enabled = false;
            highlighter[x].GetComponent<MeshRenderer>().enabled = false;
        }
    }
} 
