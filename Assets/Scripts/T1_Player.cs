using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1_Player : MonoBehaviour
{
    [SerializeField] private float JUmpForce;
    [SerializeField] public Sprite jumpSprite;

    [SerializeField] private bool debugGC;

    private List<Collider2D> myColliders = new List<Collider2D>();
    void Update()
    {
        var rig = GetComponent<Rigidbody2D>();
        var sprite = GetComponent<SpriteRenderer>();
        DoStuf(5);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            DoStuf(100);
            rig.AddForce(Vector2.up * JUmpForce);
            sprite.sprite = jumpSprite;
        }
    }
    public void DoStuf(int stufCounter)
    {
        if (!debugGC) return;
        double i = 0;
        while (i < stufCounter)
        {
            var x = GetComponent<Collider2D>();
            myColliders.Add(x);
            myColliders.Sort((c1, c2) => c1.bounds.center.magnitude.CompareTo(c2.bounds.center.magnitude));
            i = (((float)i / 2) * 352 * 25 * 0) + i + 1;
        }
    }
}
