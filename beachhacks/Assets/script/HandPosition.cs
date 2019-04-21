using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class HandPosition : MonoBehaviour {

    Controller controller;
    float palmPosition1 = 200;
    float palmPosition2 = 200;

// Use this for initialization
    void Start () {
            controller = new Controller();
	}
	
	// Update is called once per frame
	void Update () {
        Frame frame = controller.Frame(); // controller is a Controller object
        if (frame.Hands.Count > 0)
        {
            List<Hand> hands = frame.Hands;
            Hand firstHand = hands[0];
            // print(firstHand.PalmPosition);
            palmPosition2 = firstHand.PalmPosition[1];
            if ((palmPosition2 - palmPosition1) > 2)
            {
                swimming.value = 1;
                // print("upward");
            }
            else if((palmPosition2 - palmPosition1) < -2)
            {
                swimming.value = -1;
                // print("downward");
            }
            else
            {
                swimming.value = 0;
                // print("unchanged");
            }
            palmPosition1 = palmPosition2;
        }
        
    }
}
