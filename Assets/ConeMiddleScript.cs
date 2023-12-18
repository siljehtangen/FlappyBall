using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConeMiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicManagerScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.layer == 3)
        {
            logic.addScore(1);

        }
    
    }


}
