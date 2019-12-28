using UnityEngine;
using System.Collections;
using UnityEngine;
public class Player : MonoBehaviour {
    // 需要unity中设置速度
    public float m_move_seed = 3; // 移动速度

    private SpriteRenderer m_sr;
    public Sprite[] m_tank_sprite; //坦克图片数组

    private void Awake()
    {
        m_sr = GetComponent<SpriteRenderer>();
    }
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    private void FixedUpdate()
    {
        // h获取玩家输入的h的数据
        float h = Input.GetAxisRaw("Horizontal");

        if (h < 0)
        {
            m_sr.sprite = m_tank_sprite[3];
        }
        else if (h > 0)
        {
            m_sr.sprite = m_tank_sprite[1];
        }
        //移动位置
        transform.Translate(Vector3.right * h * m_move_seed * Time.deltaTime, Space.World);

        // w
        float v = Input.GetAxisRaw("Vertical");
        if (v < 0)
        {
            m_sr.sprite = m_tank_sprite[2];
        }
        else if (v > 0)
        {
            m_sr.sprite = m_tank_sprite[0];
        }
        transform.Translate(Vector3.up * v * m_move_seed * Time.deltaTime, Space.World);

        print("update h =" + h + "v = " + v);
    }
}
