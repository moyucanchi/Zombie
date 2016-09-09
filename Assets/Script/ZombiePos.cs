using UnityEngine;
using System.Collections;

public class ZombiePos : MonoBehaviour {
    private float coolTime = 5f;
    private float timeCount = 0f;
    public GameObject prefab;
    public GameObject zombiePos;
    private float zombieCount = 0f;
    private float zombieMax = 5f;


    void Start () {
	
	}
	
	void Update () {
       
        if (timeCount < coolTime)
        {
            timeCount += Time.deltaTime;
        }
        else
        {
            if (zombieCount < zombieMax)
            {
                timeCount = 0f;
                zombieCount += 1f;
                Vector3 pos = new Vector3();
                pos.y = 4.231f;
                pos.x = Random.Range(zombiePos.transform.position.x - 5f, zombiePos.transform.position.x + 5f);
                pos.z = Random.Range(zombiePos.transform.position.z - 5f, zombiePos.transform.position.z + 5f);
                float angle = Random.Range(0f, 360f);
                Instantiate(prefab, pos, Quaternion.AngleAxis(angle, Vector3.up));
            }
           
        }
       
	}
}
