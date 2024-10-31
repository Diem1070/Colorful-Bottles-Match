using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // List stores bottles that user can see it
    public List<GameObject> topRowBottles;

    // List stores bottles that user can't see it
    public List<GameObject> hiddenRowBottles;

    // 2 swapped bottles
    private GameObject selectedBottle1 = null;
    private GameObject selectedBottle2 = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Method to disorder bottles
    void ShuffleBottles()
    {

    }

    // Method to select bottle when a mouse click is on a bottle of top row
    public void SelectBottle(GameObject bottle)
    {

    }

    // Method to swap position of 2 bottles
    void SwapBottles(GameObject bottle1, GameObject bottle2 )
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
