using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    

    public override void Interact(Player player) {

        if(!HasKitchenObject()) {
            //There is no KitchenObject on the Clearcounter
            if(player.HasKitchenObject()) {
                //Player is carrying smthing
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {
                //Player is carrying nothing
            }
        } else {
            //There is a KitchenObject on the Clearcounter
            if(player.HasKitchenObject()) {
                //Player got something

            } else {
                //Player is carrying nothing
                GetKitchenObject().SetKitchenObjectParent(player);

            }
        }

    }

}

    

