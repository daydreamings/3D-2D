using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thickblock : MonoBehaviour
{
    public GameObject cube; // Ziehe deinen Cube hier im Inspektor rein
    public Button yourButton; // Ziehe deinen Button hier im Inspektor rein
    public float scaleFactor = 1.1f; // Der Faktor, um den der Cube skaliert wird
    private bool isScaled = false;
    // Start is called before the first frame update
    void Start()
    {
        yourButton.onClick.AddListener(ToggleScale);
    }
    void ToggleScale()
    {
        Vector3 scale = cube.transform.localScale;

        if (isScaled)
        {
            scale.x /= scaleFactor;
        }
        else
        {
            scale.x *= scaleFactor;
        }

        cube.transform.localScale = scale;
        isScaled = !isScaled;
    }
}

