using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform Player;

    float CameraSmooth = 5f;
    Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = new Vector3(0.0f, 1.36f, -10.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Player)
        {
            Vector3 targetPosition = Player.position + cameraOffset;
            Vector3 SmoothedVector = Vector3.Lerp(transform.position, targetPosition, CameraSmooth * Time.deltaTime);
            transform.position = SmoothedVector;
        }
    }
}
