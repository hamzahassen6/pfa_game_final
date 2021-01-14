using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class cube_enemy : MonoBehaviour
{
    public int enemyball = 0;
    
    public void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {

        if (enemyball == 4)
        {
             GameManager.NumRestEnemy--;
            score_manager.Score+=2;
           
            Debug.Log(GameManager.NumRestEnemy);
            Destroy(gameObject);
           

        }
    }
}
