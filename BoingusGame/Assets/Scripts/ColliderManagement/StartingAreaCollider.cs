using UnityEngine;


//this will manage the starting area collision of the box
public class StartingAreaCollider : MonoBehaviour
{
    [SerializeField] private GameObject wallDivider;
    [SerializeField] private GameObject playerTryLeaveOtherPlayerTrigger;
    [SerializeField] private GameObject playerTryLeaveOtherPlayerCollider;
    [SerializeField] private GameObject cinemachineCameraSwitchTrigger;
    [SerializeField] private GameObject startingBox;
    [SerializeField] private GameObject playerCollider;
    [SerializeField] private GameObject playerStopWall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("StartingBox"))
        {
            wallDivider.SetActive(false);
            playerTryLeaveOtherPlayerTrigger.SetActive(false);
            playerTryLeaveOtherPlayerCollider.SetActive(false);
            startingBox.SetActive(false);
            playerCollider.SetActive(true);
            playerStopWall.SetActive(true);
            cinemachineCameraSwitchTrigger.SetActive(true);

            //Sound play
            SoundManager.PlaySound(SoundType.OBJECTINBASKET);
        }
    }
}
