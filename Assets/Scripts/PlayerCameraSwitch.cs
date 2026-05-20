using Unity.Cinemachine;
using UnityEngine;

public class PlayerCameraSwitch : MonoBehaviour
{
    [SerializeField] private CinemachineCamera camera1;
    [SerializeField] private CinemachineCamera camera2;
    [SerializeField] private CinemachineCamera camera3;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("SwitchCamera"))
        {
            camera1.Priority = 0;
            camera2.Priority = 10;
            camera3.Priority = 0;
        }
        if (collision.gameObject.CompareTag("ShowCamera"))
        {
            camera1.Priority = 0;
            camera2.Priority = 0;
            camera3.Priority = 10;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SwitchCamera"))
        {
            camera1.Priority = 10;
            camera2.Priority = 0;
            camera3.Priority= 0;
        }
        if (collision.gameObject.CompareTag("ShowCamera"))
        {
            camera1.Priority = 10;
            camera2.Priority = 0;
            camera3.Priority = 0;
        }
    }

}
