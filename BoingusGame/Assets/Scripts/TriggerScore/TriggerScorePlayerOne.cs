using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TriggerScorePlayerOne : MonoBehaviour
{
    [SerializeField] private GameObject playableAreaWall;
    [SerializeField] private TextMeshProUGUI playerOneScore;

    [SerializeField] private GameObject playerOneScoreScreen;

    [SerializeField] private PlayerMovement playerMovement;

    private int playerOneScoreInt = 0;

    [SerializeField] private int ScoreToWin = 2;

    private void Awake()
    {
        playerOneScore.text = playerOneScoreInt.ToString();
    }

    private void Update()
    {
        if (playerOneScoreInt == ScoreToWin)
        {
            playerOneScoreScreen.SetActive(true);
            playerMovement.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            playerOneScoreInt++;
            playerOneScore.text = playerOneScoreInt.ToString();
            SoundManager.PlaySound(SoundType.OBJECTINBASKET);
        }
    }
}
