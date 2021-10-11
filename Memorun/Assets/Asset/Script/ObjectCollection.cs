//https://www.patreon.com/posts/25656838

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCollection : MonoBehaviour
{
    //[SerializeField] private string selectableTag = "GBA";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;
    public GameObject GBA, GBAIcon, Bear, BearIcon, Photo, PhotoIcon, Scarf, ScarfIcon, Ring, RingIcon, Bear1, GBA1, Photo1, Scarf1, Ring1;
    AudioSource audioData;
    //public GameObject GBAIcon;

    //for number add when object collect
    public int flag;
    public string newGameScene;

    private void Start()
    {
        GBAIcon.SetActive(false);
        BearIcon.SetActive(false);
        RingIcon.SetActive(false);
        ScarfIcon.SetActive(false);
        PhotoIcon.SetActive(false);
        //Bear1.SetActive(false);

        audioData = GetComponent<AudioSource>();

        flag = 0;
        
    }
    private void Update()
    {
        collecteObject("GBA", GBA, GBAIcon,GBA1);
        collecteObject("Ring", Ring, RingIcon, Ring1);
        collecteObject("Bear", Bear, BearIcon, Bear1);
        collecteObject("Photo", Photo, PhotoIcon, Photo1);
        collecteObject("Scarf", Scarf, ScarfIcon, Scarf1);

        
    }


    void collecteObject(string objectName, GameObject objectItself, GameObject objectIcon, GameObject object1)
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            //if (selection.CompareTag(objectName) && Input.GetMouseButtonDown(0))
                if (selection.CompareTag(objectName))
                {
                if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.E)) {
                    audioData.Play(0);
                    flag = flag + 1;
                    print(flag);
                    StartCoroutine(endGame());

                    Debug.Log("click");
                    objectItself.SetActive(false);
                    objectIcon.SetActive(true);
                    

                    var selectionRenderer = selection.GetComponent<Renderer>();


                    _selection = selection;
                    //displaySticker(Bear1);
                    StartCoroutine(displaySticker(object1));
                }
                
            }
        }
    }


    IEnumerator endGame()
    {
        if(flag == 5)
        {
            yield return new WaitForSeconds(10);
            print("Game End");
            NewGame();
        }
    }



    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }


    IEnumerator displaySticker(GameObject sticker)
    {
        sticker.SetActive(true);
        yield return new WaitForSeconds(10);
        sticker.SetActive(false);

    }


}
