
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchWeapon : MonoBehaviour
{
    public int selectedWeapon = 0;
    private PlayerInput playerInput;
    [SerializeField] private GameObject P90;
    [SerializeField] private GameObject shotGun;

    // Start is called before the first frame update
    private void Awake()
    {
        SelectWeapon();
        shotGun.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        int previusSelectWeapon = selectedWeapon;

        if(playerInput.OnFoot.Weapon1.IsPressed())
        {
            selectedWeapon = 0;
            Debug.Log("switch weapon");
        }
        
        if(playerInput.OnFoot.Weapon2.IsPressed() && transform.childCount >=2)
        {
            selectedWeapon = 1;
            Debug.Log("switch weapon2");
        }



        if(previusSelectWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
        
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform )
        {
            if(i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i ++;
        }
    }
}
