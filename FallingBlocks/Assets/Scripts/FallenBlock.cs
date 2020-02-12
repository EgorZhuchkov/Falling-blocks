using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenBlock : MonoBehaviour
{
    [SerializeField] Vector2 speedMinMax;
    private float speed;
    private void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
    }
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if(transform.position.y < -(Camera.main.orthographicSize + transform.localScale.y))
        {
            Destroy(gameObject);
        }
    }
}
