using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
  CharacterController playerController;

  void Start()
  {
    playerController = transform.parent.GetComponent<CharacterController>();
  }
  void Update()
  {
    RaycastHit hit;
    if(Physics.Raycast(transform.position, Vector3.down, out hit, 1))
    {
      OnInteractableHit(hit);
    }
  }
  void OnInteractableHit(RaycastHit hit)
  {
    Collider other = hit.collider;
    if(other.tag == "Interactable")
    {
      if(Input.GetKeyDown(KeyCode.E))
      {
        float interactRange = 2F;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
          Debug.Log(collider);
        }
      }
    }
  }
}
