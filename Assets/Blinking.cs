using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        // Start is called before the first frame update
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}
