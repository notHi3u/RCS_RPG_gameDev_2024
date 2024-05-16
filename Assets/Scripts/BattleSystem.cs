using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WIN, LOSE };

public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    // prefabs
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    //units
    Units playerUnits;
    Units enemyUnits;

    //spawn champs
    public Transform playerBattleStation;
    public Transform enemyBattleStation;




    //HUD
    public BattleHud playerHUD;
    public BattleHud enemyHUD;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnits = playerGO.GetComponent<Units>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnits = enemyGO.GetComponent<Units>();


        playerHUD.SetHUD(playerUnits);
        enemyHUD.SetHUD(enemyUnits);
    }
    
}
