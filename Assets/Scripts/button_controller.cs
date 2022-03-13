using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_controller : MonoBehaviour
{
    //public Animator Enemy_Animation_Controller;
    public Animator Enemy_Animator;
    private SpriteRenderer SR;
    public Color pressed_color;
    public Color default_color;
    private score_tracker ST;
    private Health_tracker HT;
    private multiplier_tracker MT;
    [Range(1,3)]
    public int multiplier = 1;

    public KeyCode Attack_Key;
    public KeyCode Parry_Key;
    public int Game_Over_Level;
    

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponentInParent<SpriteRenderer>();
        ST = GameObject.FindGameObjectWithTag("ScoreTracker").transform.GetComponent<score_tracker>();
        HT = GameObject.FindGameObjectWithTag("HealthTracker").transform.GetComponent<Health_tracker>();
        MT = GameObject.FindGameObjectWithTag("MultiplierTracker").transform.GetComponent<multiplier_tracker>();
        Enemy_Animator = GameObject.FindGameObjectWithTag("enemy").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        input_check(Parry_Key, "parry");
        input_check(Attack_Key, "attack");

        input_release(Parry_Key);
        input_release(Attack_Key);

        if (HT.HP <= 0)
        {
            StartCoroutine(GameOver(0));
        }
    }

    void input_check(KeyCode key, string correct_tag)
    {
        if (Input.GetKeyDown(key))
        {
            SR.color = pressed_color;
            RaycastHit CheckRay;
            if (Physics.SphereCast(transform.position, 0.5f, -transform.forward, out CheckRay))
            {
                if (CheckRay.transform.CompareTag(correct_tag))
                {
                    CheckRay.transform.gameObject.SetActive(false);
                    
                    multiplier += 1;
                    Debug.Log("Hit");
                    ST.UpdateText(10 * multiplier);
                    HT.UpdateHealth(5);
                    MT.UpdateMultiplier(multiplier);
                }
                else
                {
                    Enemy_Animator.SetTrigger("parry");
                    multiplier = 1;
                    CheckRay.transform.GetComponent<SphereCollider>().enabled=false;
                    CheckRay.transform.GetComponent<SpriteRenderer>().enabled = false;
                    Debug.Log("Miss");
                    ST.UpdateText(-1);
                    HT.UpdateHealth(-10);
                    MT.UpdateMultiplier(1);
                }
            }
            else
            {
                multiplier = 1;
                Debug.Log("Miss");
                ST.UpdateText(-1);
                HT.UpdateHealth(-5);
                MT.UpdateMultiplier(1);
            }
        }
    }

    void input_release(KeyCode key)
    {
        if (Input.GetKeyUp(key))
        {
            SR.color = default_color;
        }
    }

    

    IEnumerator Waiter(float waitTime)
    {
        Debug.Log("Waiting");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Waited");
        yield return null;
    }

    IEnumerator GameOver(float transition_time)
    {
        yield return new WaitForSeconds(transition_time);
        SceneManager.LoadScene(Game_Over_Level);
        yield return null;
    }

}
