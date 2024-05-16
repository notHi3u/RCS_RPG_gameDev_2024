using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    public Text nameText;
    public Text levelText;
    public Text curentMP;
    public Slider hpSlider;
    public Slider mpSlider;

    public void SetHUD(Units unit)
    {
        nameText.text = unit.unitName;
        levelText.text = unit.unitLevel.ToString();
        hpSlider.maxValue = unit.unitMaxHp;
        hpSlider.value = unit.unitCurrentHp;
        mpSlider.maxValue = unit.unitMp;
        mpSlider.value = unit.unitCurrentMp;
    }
    public void SetHP(int HP)
    {
        hpSlider.value= HP;
    }
    public void SetMP(int MP)
    {
        mpSlider.value = MP;
    }
}
