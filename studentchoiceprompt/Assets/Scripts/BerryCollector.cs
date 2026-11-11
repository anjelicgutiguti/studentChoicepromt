using UnityEngine;

public class BerryCollector : MonoBehaviour
{
    public int berryCount;
    public int maxBerry;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(berryCount);

        if (Input.GetKey(KeyCode.E)) 
        {
            PlayerPickup();
        }
    }

    public void PlayerPickup()
    {
        // check if player is looking at berry 
        // if they are deestroy berry
        PickupBerry();
    }
    public void PickupBerry()
    {
        berryCount++;
        if(berryCount >= maxBerry)
        {
            // win or something or update quest to get home
        }
    }
}
