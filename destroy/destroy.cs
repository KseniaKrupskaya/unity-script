using System.Collections; //импорт библиотек 
using System.Collections.Generic;
using UnityEngine; //импорт основного модуля unity

public class destroy : MonoBehaviour //объявление класса destroy - наследника MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject); //уничтожение игрового объекта gameObject
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
