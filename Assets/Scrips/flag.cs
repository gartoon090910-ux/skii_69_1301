using UnityEngine;

public class flag : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player == null)
            return;

        player.Poin += 10;
        UIManager.Instance.ShowNotiText($"+10 poin\n points :{player.Poin}");
        Destroy(gameObject);
    }
}
