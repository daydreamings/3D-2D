using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBlock : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cylinder.SetActive(false);
        cube.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // === Öffnen / schließen des Menüs -> Tastenabfrage für ESC ===
        if (Input.GetKeyDown(KeyCode.E))


            if (cylinder.activeInHierarchy == false)
            {
                cylinder.SetActive(true);
                cube.SetActive(false);
            }

            else
            {
                cylinder.SetActive(false);
                cube.SetActive(true);
            }

    }


}


    

