using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
  void Start()
  {
      
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      Debug.Log(Input.GetKeyDown(KeyCode.E));
      SceneManager.LoadScene("Main", LoadSceneMode.Additive);
    }
  }

}