using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;
    private bool isShowingMenu = false;

    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;

    void Start()
    {
        // Ẩn menu khi bắt đầu game bằng biến isShowingMenu (false)
        GameMenu.enabled = isShowingMenu;

        // Tự động gán nội dung chữ động cho giao diện
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want continue?";
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

      public void NextScene() 
    {
        // Chuyển sang màn chơi tiếp theo (tên màn là _Scene_1)
        // SceneManager.LoadScene("_Scene_1");
         Debug.Log("Nguoi choi da bam nut [ENTER] - Chuan bi chuyen man tiep theo!");
    }

    public void RestartScene() 
    {
        // Tải lại màn chơi hiện tại để chơi lại (tên màn là _Scene_3_2)
        // SceneManager.LoadScene("_Scene_3_2");
        Debug.Log("Nguoi choi da bam nut [RESTART] - Chuan bi tai lai man choi hien tai!");
    
    }
}
