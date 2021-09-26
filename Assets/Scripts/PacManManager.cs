using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManManager : MonoBehaviour
{
    public AudioSource NoEat;
    [SerializeField]
    public Animator PacMan;
    private Tweener tweener;
    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 endPos1=new Vector3(-12f,12.5f,0.0f);
    private Vector3 endPos2=new Vector3(-12f,6.5f,0.0f);
    private Vector3 endPos3=new Vector3(-7.0f,6.5f,0.0f);
    private Vector3 endPos4=new Vector3(-7.0f,9.0f,0.0f);
    private Vector3 endPos5=new Vector3(-1.0f,9.0f,0.0f);
    private Vector3 endPos6;
    private float duration;
    private List<Vector3> endPosList;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        tweener=GetComponent<Tweener>();
        startPos=PacMan.transform.position;
        endPos6=PacMan.transform.position;
        endPos=endPos5;
        endPosList=new List<Vector3>();
        endPosList.Add(endPos5);
        endPosList.Add(endPos4);
        endPosList.Add(endPos3);
        endPosList.Add(endPos2);
        endPosList.Add(endPos1);
        endPosList.Add(endPos6);
        i=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if((int)Time.time>=5)
        {
            if(Vector3.Distance(PacMan.transform.position,endPos)>0.0f)
            {
                if(!NoEat.isPlaying)
                {
                    NoEat.Play();
                }
                duration=Vector3.Distance(startPos,endPos)/3.0f;
                tweener.AddTween(PacMan.transform,startPos,endPos,duration);
            }
            else
            {
                if(i>5)
                {
                    i=0;
                }
                else
                {
                    endPos=endPosList[i];
                    startPos=PacMan.transform.position;
                    switch (i)
                    {
                        case 0:PacMan.Play("PacManDown");
                        break;
                        case 1:PacMan.Play("PacManLeft");
                        break;
                        case 2:PacMan.Play("PacManDown");
                        break;
                        case 3:PacMan.Play("PacManLeft");
                        break;
                        case 4:PacMan.Play("PacManUp");
                        break;
                        case 5:PacMan.Play("PacManRight");
                        break;
                        default:break;
                    }
                    i++;
                }
            }
        }
        
    }
}
