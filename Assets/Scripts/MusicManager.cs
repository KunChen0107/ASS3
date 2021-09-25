using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public Animator BlueController;
    public Animator GreenController;
    public Animator RedController;
    public Animator YellowController;
    public Animator PacMan;

    public AudioSource IntroductionMusic;
    public AudioSource StartMusic;
    public AudioSource GhostInDangerMusic;
    bool GhostInDanger=false;

    // Start is called before the first frame update
    void Start()
    {
        GhostInDangerMusic.Stop();
        StartMusic.Stop();
        IntroductionMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if((int)Time.time==5)
        {
            IntroductionMusic.Stop();
            if(!IntroductionMusic.isPlaying)
            {
                if(!StartMusic.isPlaying)
                {
                    StartMusic.Play();
                }  
            }    
        }   
    }

    void ChangeMusicToGhostInDanger()
    {
        if(BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerRight"||BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerUp"||
        BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerDown"||BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerLeft"||
        YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerRight"||YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerUp"||
        YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerDown"||YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerLeft"||
        GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerRight"||GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerUp"||
        GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerDown"||GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerLeft"||
        RedController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerRight"||RedController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerUp"||
        BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerDown"||RedController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerLeft")
        {
            GhostInDanger=true;
        }
        else
        {
            GhostInDanger=false;
        }  
        if(GhostInDanger)
        {
            if(!GhostInDangerMusic.isPlaying)
            {
                StartMusic.Stop();
                GhostInDangerMusic.Play();
                Debug.Log("Sound Changed");
            }
            else
            {
                Debug.Log("dont need to change");
            }  
        }
        else
        {
            if(!StartMusic.isPlaying)
            {
                GhostInDangerMusic.Stop();
                StartMusic.Play();
                Debug.Log("Out of Danger");
            }
        }
    }
}
