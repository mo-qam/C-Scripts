using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawn : MonoBehaviour
{
    public GameObject ammo; //GameObject To Spawn

    public int xPos; //Position on X axis
    public int zPos; //Position on Z axis
    public int yPos; //Position on y axis
    public int ammoCount; //ammo count integer

    private void Start() //On Start of Scene
    {
        StartCoroutine(AmmoDrop()); //Game Starts Couroutine Timer to drop gameobject (ammo)
    }

    IEnumerator AmmoDrop() //Ammo Drop IEnumerator
    {
        while (ammoCount < 30) // Max gameobject drop on scene is 30, while below 30 the IEnumerator will generate ammo on given axis positions
        {
            xPos = Random.Range(50, 140);
            zPos = Random.Range(60, 113);
            yPos = Random.Range(1, 3);
            Instantiate(ammo, new Vector3(xPos, yPos, zPos), Quaternion.identity); // Instantiates ammo randomly at given axis positions
            yield return new WaitForSeconds(3f); // Couroutine will drop the gameobject every x amount of seconds
            ammoCount += 2; // 2 gameobjects (ammo) will be dropped every 3 seconds on given positions
        }
    }
    // Add script to empty gameobject within scene 
    // Drag in desired gameobject to spawn within your given axis positions
    // Change ammo count and WaitForSeconds as desired

}
