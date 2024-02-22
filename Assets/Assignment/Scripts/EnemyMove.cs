using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Vector2 newPosition = new Vector2(0, -4);
    Vector2 startPosition = new Vector2(0, 4);
    public float speed = 1f;
    float elapsedTime;
    public AnimationCurve enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lerpSpeed = enemySpeed.Evaluate(elapsedTime);
        elapsedTime += Time.deltaTime;
        //float distanceTravelled = elapsedTime / speed;
        transform.position = Vector2.Lerp(startPosition, newPosition, lerpSpeed);
    }
}
