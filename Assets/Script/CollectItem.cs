using UnityEngine;

[System.Serializable]


public class Item
{
    public string name;
    public string description;
    public Sprite itemImage;
}
public class CollectItem : MonoBehaviour
{

    public Item item;

    public float moveSpeedChange;
    public float attackSpeedChange;



    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = item.itemImage;
        Destroy(GetComponent<PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerController.collectedAmount++;
            GameController.MoveSpeedChange(moveSpeedChange);
            GameController.FireRateChange(attackSpeedChange);
            Destroy(gameObject);
        }
    }



}
