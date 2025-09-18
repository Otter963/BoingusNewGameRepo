using UnityEngine;

public class PlayerLeavingScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.PlaySound(SoundType.PLAYERLEAVEVOICE);
        }
    }
}
