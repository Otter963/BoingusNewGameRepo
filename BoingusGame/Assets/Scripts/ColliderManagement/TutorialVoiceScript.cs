using UnityEngine;

public class TutorialVoiceScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.PlaySound(SoundType.TUTORIALVOICEONE);
        }
    }
}
