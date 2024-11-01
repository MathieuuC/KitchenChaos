using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ContainerCounter : BaseCounter {

    public EventHandler OnPlayerGrabbedobject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    
    public override void Interact(Player player){
        if(!player.HasKitchenObject()){
            // Player is not carrying anything
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
            OnPlayerGrabbedobject?.Invoke(this, EventArgs.Empty);
        } else {

        }
       
    }

}

   


