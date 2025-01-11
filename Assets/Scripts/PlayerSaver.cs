using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaver : MonoBehaviour
{
    public string nombredeguardado = "PuntoDeGuardado"; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuardadoDeProgreso(other.gameObject);
        }
    }
    void GuardadoDeProgreso(GameObject player)
    {
        // Guardar el estado del jugador
        Vector3 playerPosition = player.transform.position;
        PlayerPrefs.SetFloat(nombredeguardado + "_PosX", playerPosition.x);
        PlayerPrefs.SetFloat(nombredeguardado + "_PosY", playerPosition.y);
        PlayerPrefs.SetFloat(nombredeguardado + "_PosZ", playerPosition.z);
        Quaternion playerRotation = player.transform.rotation;
        PlayerPrefs.SetFloat(nombredeguardado + "_RotX", playerRotation.eulerAngles.x);
        PlayerPrefs.SetFloat(nombredeguardado + "_RotY", playerRotation.eulerAngles.y);
        PlayerPrefs.SetFloat(nombredeguardado + "_RotZ", playerRotation.eulerAngles.z);

        List<string> collectedItems = GetCollectedItems(player);
        PlayerPrefs.SetInt(nombredeguardado + "_ItemsCount", collectedItems.Count);
        for (int i = 0; i < collectedItems.Count; i++)
        {
            PlayerPrefs.SetString(nombredeguardado + "_Item_" + i, collectedItems[i]);
        }

        PlayerPrefs.Save(); // Guardardo los cambios
        Debug.Log("Estado guardado en el checkpoint: " + nombredeguardado);
    }
    List<string> GetCollectedItems(GameObject player)
    {
        return new List<string> { "Orb", "Coin", "Item" }; 
    }
}
