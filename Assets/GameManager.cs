using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Transform rightcap;
    public Transform leftcap;
    public GameObject[] enemy;
    

    public static float NumRestEnemy;

    public int enemyball = 0;
    public GameObject player;
    public AudioSource destsound;
    public void Start()
    {/******************1 st intantiate ******************************/

        instantiateGO();



    }

    public void FixedUpdate()
    {

        if (NumRestEnemy <= 1)
        {
            instantiateGO();
        }

        /********************** the enemy 1 destroying *****************************/
        RaycastHit hit;
        Vector3 direction = (leftcap.position - rightcap.position).normalized;
        Ray ray = new Ray(rightcap.position, direction);



        var maxdist = Vector3.Distance(rightcap.position, leftcap.position);



        if (Physics.Linecast(rightcap.position, leftcap.position, out hit))
        {

            Debug.DrawLine(rightcap.position, leftcap.position);

            if (hit.transform.tag == "enemy")
            {
                Debug.Log(hit.transform.name);

                NumRestEnemy--;
                score_manager.Score++;
                
                destsound.Play();
                Destroy(hit.transform.gameObject);
                

            }


        }


    }


    /***************intantiatian*******************/
    public void instantiateGO()
    {
        float RandomX, RandomZ;
        int RandomE = Random.Range(0,2);

        for (int i = 0; i < 3; i++)
        {
            RandomX = Random.Range(-18, 18);
            RandomZ = Random.Range(-10f, 10f);
            Vector3 randompos = new Vector3(RandomX, 1.2f, RandomZ);
            Instantiate(enemy[RandomE], randompos, Quaternion.identity);

        }
        NumRestEnemy += 3;

    }


}