using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    public void Load (int level)
    {
        SceneManager.LoadScene(level);
    }
}
