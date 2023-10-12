using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : NPC
{ 
    // Start is called before the first frame update
    void Move()
    { 

        //goalie tracks the ball
        Vector3 wishDir = myTarget.transform.position - transform.position;
        Debug.DrawRay(transform.position, wishDir, Color.green, 1f);
        //normalize the force so we can mutiply by our own speed
        wishDir = wishDir.normalized;

        //put some code in here to make sure the goalie
        //stays close to the goal to block shot attempts
        //add force finally
        myRB.AddForce(wishDir * NPCspeed, ForceMode.Acceleration);
    }
}
