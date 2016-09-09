using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {
    private NavMeshAgent _Nma;
    public float closeDistance = 2f;
    private Animator _animator;
    public AudioSource music;

   

    void Start () {
        _Nma = this.GetComponent<NavMeshAgent>();
        _animator = this.GetComponent<Animator>();
       
    }
	
	void Update () {
        //动画
        if (_Nma.enabled)
        {
            _Nma.destination = GameObject.Find("Player").transform.position;
            if (Vector3.Distance(this.transform.position, GameObject.Find("Player").transform.position)< closeDistance)
            {
                _Nma.Stop();
               
                transform.LookAt(new Vector3( GameObject.Find("Player").transform.position.x,transform.position.y, GameObject.Find("Player").transform.position.z));
                _animator.SetBool("Attack", true);//开始攻击动画

            }else
            {
                _Nma.Resume();//继续寻路
                _animator.SetBool("Attack", false);//停止攻击动画
                _Nma.destination = GameObject.Find("Player").transform.position;
                
            }
        }
        //音效
        if (!music.isPlaying)
        {
            if (_animator.GetBool("Attack"))
            {
                music.Play();//播放攻击音效             
            }

        }
        else
        {
            if (!_animator.GetBool("Attack"))
            {
                music.Stop();//暂停播放攻击音效
            }
        }
    }
  
}
