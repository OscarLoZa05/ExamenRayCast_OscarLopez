using UnityEngine;
using UnityEngine.InputSystem;

public class RayCast : MonoBehaviour
{

    private InputAction _lookAction;
    public Vector2 _moveValue;
    private InputAction _clickAction;

    void Awake()
    {

       _lookAction = InputSystem.actions["Look"]; 
       _clickAction = InputSystem.actions["Attack"];

    }

    // Update is called once per frame
    void Update()
    {
        _moveValue = _lookAction.ReadValue<Vector2>();
        
        if(_clickAction.WasPressedThisFrame() && GameManager.instance.youClick == false)
        {
            ShootRayCast();
        }
        
    }

    void ShootRayCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(_moveValue);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.transform.tag == "1")
            {
                GameManager.instance.youClick = true;
                Debug.Log("Cubo1");
                StartCoroutine(GameManager.instance.Bucles(1));
            }
        
            if(hit.transform.tag == "2")
            {
                GameManager.instance.youClick = true;
                Debug.Log("Cubo2");
                StartCoroutine(GameManager.instance.Bucles(2));
            }
        
            if(hit.transform.tag == "3")
            {
                GameManager.instance.youClick = true;
                Debug.Log("Esfera3");
                StartCoroutine(GameManager.instance.Bucles(3));
            }
        }
    }


}
