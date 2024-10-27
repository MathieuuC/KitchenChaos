using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ContainerCounter : BaseCounter {

    public EventHandler OnPlayerGrabbedobject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    
    public override void Interact(Player player){
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

            OnPlayerGrabbedobject?.Invoke(this, EventArgs.Empty);
        }
       
    }

   


