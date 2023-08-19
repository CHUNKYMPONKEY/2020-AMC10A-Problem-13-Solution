using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class move : MonoBehaviour
{
    public info info;
    public float startx;
    public float starty;
    public float verticex;
    public float verticey;
    public float direction;
    public float speed;
    public float xmin;
    public float ymin;
    public float xmax;
    public float ymax;
    // Start is called before the first frame update
    void Start()
    {
        startx = transform.position.x;
        starty = transform.position.y;
         
        direction = Mathf.Round(Random.Range(0, 4));
    }

    // Update is called once per frame
    void Update()
    {
        verticex = transform.position.x;
        verticey = transform.position.y;
        

        
        if (direction == 1)
        {
            transform.position = new Vector3(verticex, verticey + 2);
            direction = Mathf.Round(Random.Range(0, 4));
        }
        else
        {
            if (direction == 2)
            {
                transform.position = new Vector3(verticex + 2, verticey);
                direction = Mathf.Round(Random.Range(0, 4));
            }
            else
            {
                if (direction == 3)
                {
                    transform.position = new Vector3(verticex, verticey - 2);
                    direction = Mathf.Round(Random.Range(0, 4));
                }
                else
                {
                    if (direction == 0 || direction == 4)
                    {
                        transform.position = new Vector3(verticex - 2, verticey);
                        direction = Mathf.Round(Random.Range(0, 4));
                    }
                }

            }
        }
        if (transform.position.x >= xmax || transform.position.x <= xmin)
        {
            gotostart();
            info.vertical += 1;

        }
        if (transform.position.y >= ymax || transform.position.y <= ymin)
        {
            gotostart();
            info.horizontal += 1;

        }
        if (transform.position.y >= ymax || transform.position.y <= ymin && transform.position.x >= xmax || transform.position.x <= xmin)
        {
            info.horizontal -= 1;
            info.vertical -= 1;
        }




    }
    private void OnCollision2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            info.vertical = info.vertical + 1;
            transform.position = new Vector3(startx, starty);
        }
        if (collision.gameObject.layer == 6)
        {
            info.horizontal = info.horizontal + 1;
            transform.position = new Vector3(startx, starty);
        }
    }
    [ContextMenu("gotostart")]
    public void gotostart()
    {
        transform.position = new Vector3(startx, starty);
    }
}
