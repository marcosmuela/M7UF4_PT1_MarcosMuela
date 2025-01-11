using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Scale : MonoBehaviour
{
    public float scaleTime = 2f;
    private float scale = 1f;
    public float scaleAmount = 0.005f;
    public float rotateAmount = 2f;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(ScaleObject());
    }
    void FixedUpdate()
    {
        transform.Rotate(0, rotateAmount, 0);
        transform.localScale += new Vector3(1, 1f, 1f) * scale * scaleAmount;
    }

    private IEnumerator ScaleObject()
    {
        yield return new WaitForSeconds(scaleTime);
        scale = -scale;
        yield return ScaleObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
