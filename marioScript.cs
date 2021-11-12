using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marioScript : MonoBehaviour
{
    public float tocdo;
    public bool duiat=true;
    public bool chuyenhuong=false;

    private Animator HoatHoa;
    // Start is called before the first frame update
    void Start()
    {
        HoatHoa = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
