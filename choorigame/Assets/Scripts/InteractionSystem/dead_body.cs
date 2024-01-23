using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class dead_body : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt{
        get{
            return _prompt;
        }
    }

    public string InteractionName{
        get{
            return "마에시마";
        }
    }

    public bool Interact (InteractionControllers interactor){
        Debug.Log("dead_body");
        return true;
    }
}