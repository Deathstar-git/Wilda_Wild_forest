using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    public Button Attack_Button;
    private Hero hero;

    void Start() {
        hero = GetComponent<Hero>();
        Debug.Log(hero);
    }
    public void OnAttack() {
        // hero.Attack();
    }
}
