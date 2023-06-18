using UnityEngine;
using UnityEngine.UI;

public class TaxiSpot : MonoBehaviour
{
    public GameObject traveller; 
    public float distanceDiff = 2f; 
    public Button button; 

    void Update()
    {
        // to fidn the location of the obj
        float distance = Vector3.Distance(transform.position, traveller.transform.position);

        // is it close enough to interact?
        button.gameObject.SetActive(distance < distanceDiff);
    }
}
