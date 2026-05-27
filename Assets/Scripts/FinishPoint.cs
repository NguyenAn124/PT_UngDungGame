using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện dùng để chuyển cảnh

public class FinishPoint : MonoBehaviour
{
    // Hàm này sẽ tự động chạy khi có ai đó chạm vào Collider (Trigger) của cổng
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Nếu cái thứ vừa chạm vào có Tag là "Player"
        if (collision.CompareTag("Player"))
        {
            // Lấy vị trí màn hiện tại (ví dụ màn 1 là số 1) và cộng thêm 1 để sang màn 2
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            // Chuyển cảnh!
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}