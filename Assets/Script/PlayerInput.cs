using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float speed = 100;
    float inputX = 0;
    float inputY = 0;
    public SpriteRenderer playerSprite;
    public SpriteRenderer playerSpriteChildren;
    Vector2 direction;
    private Rigidbody2D rb;
    private Collider2D colTrigger;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
       
        //if(Input.GetKeyDown(KeyCode.A)) { playerSprite.flipX = true; }
        //if(Input.GetKeyDown(KeyCode.D)) { playerSprite.flipX = false; }
        
        if(direction.x > 0) { playerSprite.flipX = false; playerSpriteChildren.flipX = false; }
        if(direction.x < 0) { playerSprite.flipX = true; playerSpriteChildren.flipX = true; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            ShopManager sm = collision.gameObject.GetComponent<ShopManager>();
            sm.shopHelpTextMeshProBool = true;
        }

        if(collision.gameObject.tag == "Item")
        {
            ItemManager im = collision.gameObject.GetComponent<ItemManager>();
            //im.itemHelpTextMeshProBool = true;
            if(im.itemPickUpBool == true) { im.itemHelpTextMeshProBool = false; }
            if(im.itemPickUpBool == false) { im.itemHelpTextMeshProBool = true; }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shop")
        {
            ShopManager sm = other.gameObject.GetComponent<ShopManager>();
            sm.shopHelpTextMeshProBool = false;
            sm.shopUIMenuBool = false;
        }
        if (other.gameObject.tag == "Item")
        {
            ItemManager im = other.gameObject.GetComponent<ItemManager>();
            im.itemHelpTextMeshProBool = false;
        }
    }

}
