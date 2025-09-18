using TMPro;
using UnityEngine;

public class TriggerScorePlayerTwo : MonoBehaviour
{
    [SerializeField] private GameObject playableAreaWall;
    [SerializeField] private TextMeshProUGUI playerTwoScore;

    [SerializeField] private GameObject playerTwoScoreScreen;

    [SerializeField] private PlayerMovement playerMovement;

    private int playerTwoScoreInt = 0;

    [SerializeField] private int ScoreToWin = 2;

    private void Awake()
    {
        playerTwoScore.text = playerTwoScoreInt.ToString();
    }

    private void Update()
    {
        if (playerTwoScoreInt == ScoreToWin)
        {
            playerTwoScoreScreen.SetActive(true);
            playerMovement.gameObject.SetActive(false);
            SoundManager.PlaySound(SoundType.VOICEGAMEWINPLAYERONE);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            playerTwoScoreInt++;
            playerTwoScore.text = playerTwoScoreInt.ToString();
            SoundManager.PlaySound(SoundType.OBJECTINBASKET);
        }
    }
}
