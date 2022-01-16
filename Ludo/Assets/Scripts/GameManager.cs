using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	private int totalRedInHouse, totalBlueInHouse, totalGreenInHouse, totalYellowInHouse;

	public GameObject frameRed, frameBlue, frameFreen, frameYellow;
	public GameObject redPlayer1Border, redPlayer2Border, redPlayer3Border, redPlayer4Border;
	public GameObject bluePlayer1Border, bluePlayer2Border, bluePlayer3Border, bluePlayer4Border;
	public GameObject greenPlayer1Border, greenPlayer2Border, greenPlayer3Border, greenPlayer4Border;
	public GameObject yellowPlayer1Border, yellowPlayer2Border, yellowPlayer3Border, yellowPlayer4Border;

	public Vector3 redPlayer1Pos, redPlayer2Pos, redPlayer3Pos, redPlayer4Pos;
	public Vector3 bluePlayer1Pos, bluePlayer2Pos, bluePlayer3Pos, bluePlayer4Pos;
	public Vector3 greenPlayer1Pos, greenPlayer2Pos, greenPlayer3Pos, greenPlayer4Pos;
	public Vector3 yellowPlayer1Pos, yellowPlayer2Pos, yellowPlayer3Pos, yellowPlayer4Pos;

	public Transform diceRoll;
	public Transform redDiceRoll, blueDiceRoll, greenDiceRoll, yellowDiceRoll;

	public Button diceRollButton;
	public Button redPlayer1Button, redPlayer2Button, redPlayer3Button, redPlayer4Button;
	public Button bluePlayer1Button, bluePlayer2Button, bluePlayer3Button, bluePlayer4Button;
	public Buttonn greenPlayer1Button, greenPlayer1Button, greenPlayer3Button, greenPlayer4Button;
	public Button yellowPlayer1Button, yellowPlayer2Button, yellowPlayer3Button, yellowPlayer4Button;

	public GameObject redScreen, blueScreen, greenScreen, yellowScreen;

	private string playerTurn = "RED";
	private string currentPlayer = "none";
	private string currentPlayerName = "none";

	// Player Movement Controller
	public GameObject redPlayer1, redPlayer1, redPlayer3, redPlayer4;
	public GameObject bluePlayer1, bluePlayer2, bluePlayer3, bluePlayer4;
	public GaneObject greenPlayer1, greenPlayer2, greenPlayer3, greenPlayer4;
	public GameObject yellowPlayer1, yellowPlayer2, yellowPlayer3, yellowPlayer4;

	private int redPlayer1Steps, redPlayer2Steps, redPlayer3Steps, redPlayer4Steps;
	private int bluePlayer1Steps, bluePlayer2Steps, bluePlayer3Steps, bluePlayer4Steps;
	private int greenPlayer1Steps, greenPlayer2Steps, greenPlayer3Steps, greenPlayer4Steps;
	private int yellowPlayer1Steps, yellowPlayer2Steps, yellowPlayer3Steps, yellowPlayer4Steps;

	private int selectDiceNumAnimation;
	public GameObject dice1RollAnimation, dice2RollAnimation, dice3RollAnimation, dice4RollAnimation, dice5RollAnimation;

	public List<GameObject> redMovementBlock = new List<GameObject>;
	public List<GameObject> blueMovementBlock = new List<GameObject>;
	public List<GameObject> greenMovementBlock = new List<GameObject>;
	public List<GameObject> yellowMovementBlock = new List<GameObject>;

	public GameObject confirmScreen;
	public GameObject gameCompletedScreen;

	private System.Random randomNo;


	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
