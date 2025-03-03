using UnityEngine;
 using TMPro;

public class EventManager : MonoBehaviour
{
[SerializeField] private float score = 0;
 	[SerializeField] private TextMeshProUGUI scoreText;
	private CoinTrigger[] coinTriggers;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinTriggers = FindObjectsByType<CoinTrigger>(FindObjectsInactive.Include,
		 FindObjectsSortMode.None);
	 foreach (CoinTrigger coin in coinTriggers)
	 {
	 coin.OnCoinCollect.AddListener(IncrementScore);
	 }
	 	

    }//	
	private void IncrementScore()
	 {
	 score++;

 	scoreText.text = $"Score: {score}";
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
