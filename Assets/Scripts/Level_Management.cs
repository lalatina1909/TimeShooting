using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Management : MonoBehaviour
{
    public Count_EK count;
    private int nextScene;
    int soluong = 2;
    Animator anim;
    [SerializeField] GameObject cubes;


    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        count = GameObject.FindGameObjectWithTag("Mng").GetComponent<Count_EK>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(count.number==soluong){
            cubes.SetActive(true);
            StartCoroutine(RunNormal());  
        }
        else{
            cubes.SetActive(false);
        }
    }

    IEnumerator RunNormal()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(nextScene);
    }

}
