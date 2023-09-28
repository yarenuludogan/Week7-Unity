using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sections : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool createSection = false;
    public int secNum;
    void Update()
    { if(createSection == false)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }
        
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(2);
        createSection = false;
    }


}
