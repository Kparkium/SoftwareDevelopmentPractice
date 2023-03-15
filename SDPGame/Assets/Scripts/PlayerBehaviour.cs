using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDmg(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerRecovery(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }

    //Player takes damage
    private void PlayerTakeDmg(int dmg) => GameManager.gameManager._playerHealth.DamageUnit(dmg);


    //Player receives healing
    private void PlayerRecovery(int heal) => GameManager.gameManager._playerHealth.HealUnit(heal);
}
