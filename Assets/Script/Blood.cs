using UnityEngine;
using System.Collections;

public class Blood : MonoBehaviour {
    public ParticleSystem blood;
    private Animator _animator;
    private GameObject OVR;
    // Use this for initialization
    void Start () {
        _animator = transform.GetComponent<Animator>();//获取父对象
		OVR = GameObject.Find("[CameraRig]");
        blood = OVR.GetComponentInChildren<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
    //飙血
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (_animator.GetBool("Attack"))
        {
            blood.Play();
        }
    }
}
