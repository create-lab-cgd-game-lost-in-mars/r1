using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestActivation : MonoBehaviour
{
    public Rigidbody2D player;
    public GameObject textStart;
    public Dialogue myDialogue;

    void Start()
    {
        player.velocity = new Vector2(5f, 0f);
        Dialogue myDialogue = textStart.GetComponent<Dialogue>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Enemy")
        {
            myDialogue.StartDialogue();
            print("collosion");
        }
    }
}
