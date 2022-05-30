using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float attack = 10;
    private float AttackInput;
    private Animator anim;
    public GameObject bullet;
    public Transform Shoot_point;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            anim.Play("attack1");
        }
    }
    void Attack() {
            Instantiate(bullet, Shoot_point.position, transform.rotation);
    }
}
