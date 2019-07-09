using UnityEngine;

public class button : MonoBehaviour
{
    public string LevelName;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>() == null)
            return;
        LevelManager.Instance.GotoNextLevel(LevelName);
    }
}
