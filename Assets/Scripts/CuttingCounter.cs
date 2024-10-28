using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CuttingCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;

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


    public override void InteractAlternate(Player player) {
        if(HasKitchenObject()) {
            // There a Kitchen Object here
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
}

}



