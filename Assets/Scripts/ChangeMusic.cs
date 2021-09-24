using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    public Animator BlueController;
    public Animator GreenController;
    public Animator RedController;
    public Animator YellowController;

    public AudioSource BackGround;
    public AudioSource StartMusic;
    public AudioSource GhostInDangerMusic;
    bool GameStart=false;
    bool GhostInDanger=false;
    // Start is called before the first frame update
    void Start()
    {
        StartMusic.Stop();
        BackGround.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameStart)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.RightArrow))
            {
                BackGround.Stop();
                StartMusic.Play();
                GameStart=true;
            }
        }
        else
        {
            
            Debug.Log(BackGround.isPlaying);
        }
        
    }

    void ChangeMusicToGhostInDanger()
    {
        if(BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerRight"||BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerUp"||
        BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerDown"||BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="BlueDangerLeft")
        {
            GhostInDanger=true;
        }
        else
        {
            GhostInDanger=false;
        }  
        if(GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerRight"||GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerUp"||
        GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerDown"||GreenController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="GreenDangerLeft")
        {
            GhostInDanger=true;
        }
        else
        {
            GhostInDanger=false;
        }
        if(RedController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerRight"||RedController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerUp"||
        BlueController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerDown"||RedController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="RedDangerLeft")
        {
            GhostInDanger=true;
        }
        else
        {
            GhostInDanger=false;
        }
        if(YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerRight"||YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerUp"||
        YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerDown"||YellowController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="YellowDangerLeft")
        {
            GhostInDanger=true;
        }
        else
        {
            GhostInDanger=false;
        }
        if(GhostInDanger)
        {
            StartMusic.Stop();
            GhostInDangerMusic.Play();
        }
    }
}
