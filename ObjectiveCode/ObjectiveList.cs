using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveList : MonoBehaviour, BattleEventListener
{
    //###MemberVariables###
    List<Objective> objectives;
    GameObject objectiveGameObject;
    GameObject listObject;
    BattleController BC;

    float yOffset = 0;

    //###Utilities###
    public void addObjective(Objective nObjectiveListElement)
    {
        nObjectiveListElement.addParent(GameObject.Instantiate(objectiveGameObject, this.gameObject.transform)).addOffset(yOffset);
        objectives.Add(nObjectiveListElement);
        nObjectiveListElement.setInfo(yOffset);
        nObjectiveListElement.setText();
        yOffset = yOffset - 80;
    }

    public void updateList()
    {
        foreach(Objective objective in objectives)
        {
            objective.setText();
        }
    }

    //Override from "BattleEventListener"
    public void hearEvent(BattleEvent nBattleEvent)
    {
        foreach (Objective objective in objectives.ToArray())
        {
            //Checks if BattleEvent matches with an Objective 
            if (objective.checkObjective(objective)
            {
                //Increments the int "Completed". Then checks If it's over the max completions neccesary and not already completed 
                if (objective.increment() && !objective.completed)
                {
                    //Sets it to completed, and notifies the BattleController so that i can trigger other events.  
                    objective.completed = true;
                    BC.objectiveComplete(objective.objectiveID);
                }
                updateList();
            }
        }
    }
    
    //###Initializer###
    public void initialize(BattleController nBattleController)
    {
        objectives = new List<Objective>();
        BC = nBattleController;
        objectiveGameObject = BattleUIController.getWindow("UIElements/uI_Objective_Parent");
    }
}
