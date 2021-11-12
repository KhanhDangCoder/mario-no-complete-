using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m : MonoBehaviour
{
    public float VanToc;
    private float tocdo=0;
    private bool duiat=true;
    private bool chuyenhuong=false;
    private Rigidbody2D r2d;

    private Animator HoatHoa;
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        HoatHoa = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HoatHoa.SetFloat("tocdo", tocdo);
        HoatHoa.SetBool("duiat", duiat);
        HoatHoa.SetBool("chuyenhuong", chuyenhuong);
    }
    private void FixedUpdate()
    {
        DiChuyen();
    }

    void DiChuyen()
    {
        float phimpt = Input.GetAxis("Horizontal");
        r2d.velocity = new Vector2(VanToc*phimpt, r2d.velocity.y);
        tocdo = VanToc * phimpt;
    }
}
