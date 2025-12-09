using UnityEngine;

public class TestTrigger : MonoBehaviour
{

    public GameObject box;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            box.SetActive(false);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            box.SetActive(true);
        }
    }






}
