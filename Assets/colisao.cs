using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colisao : MonoBehaviour
{
    public TMP_Text txt;
    int cont;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        cont = 0;
       // txt = GetComponent<TextMeshProUGUI>();
        txt.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (cont ==16)
        {
            SceneManager.LoadScene("scenes/mainscene");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        source.Play();
        if (collision.gameObject.CompareTag("target")) {  
            cont++;
            txt.text = cont.ToString();
            Destroy(collision.gameObject);
        
        }
       

    }
}
