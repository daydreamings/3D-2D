using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




    public class SwitchCamera : MonoBehaviour
{
    public GameObject Camera_1;
    public GameObject Camera_2;
    public CustomButton yourCustomeButton; // UI-Button
    public GameObject Player;
    private int Manager = 0;
    
    void Start()
    {
        if (yourCustomeButton != null)
        {
            if(yourCustomeButton != null)
            {
                yourCustomeButton.OnButtonClicked += ManagerCamera;
            }
        }
    }



    public void ChangeCamera()
    {
        GetComponent<Animator>().SetTrigger("Change");
    }

    public void ManagerCamera()
    {
        if (Manager == 0)
        {
            Cam_2();
            Manager = 1;
        }
        else
        {
            Cam_1();
            Manager = 0;
        }
    }
   
    void Cam_1()
    {
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
        EnableADKeys(true);
        
    }

    void Cam_2()
    {
        Camera_1.SetActive(false);
        Camera_2.SetActive(true);
        EnableADKeys(false);
      
       
    }

  

    void EnableADKeys(bool enable)
    {
        // Hier kannst du die Logik implementieren, um die Tasten A und D zu aktivieren/deaktivieren
        // Zum Beispiel:
        if (enable)
        {
            Debug.Log("Tasten A und D aktiviert");
            // Deine Logik zum Aktivieren der Tasten
        }
        else
        {
            Debug.Log("Tasten A und D deaktiviert");
            // Deine Logik zum Deaktivieren der Tasten
        }
        
    }
}


