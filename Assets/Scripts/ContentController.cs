using UnityEngine;
using UnityEngine.Animations;

public class ContentController : MonoBehaviour
{

    public API api;
    public int NotActive = 0;
    public RuntimeAnimatorController AC;

    public void LoadContent(string name)
    {
        if (NotActive == 0)
        {
            api.GetBundleObject(name, OnContentLoaded, transform);
            NotActive = 1;
        }
    }

    void OnContentLoaded(GameObject content)
    {
        Debug.Log("Loaded: " + content.name);
     
        content.AddComponent<Animator>();
        content.GetComponent<Animator>().runtimeAnimatorController = AC;
    }
}