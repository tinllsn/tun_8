using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private void OnTriggerEnter(Collider other) 
    {
        // Kiểm tra nếu vật thể va chạm có Tag là "Player" (Máy bay)
        if (other.CompareTag("Player")) 
        {
            // Bật hiển thị Canvas Menu lên ngay lập tức
            GameMenu.enabled = true;
        }
    }
}
