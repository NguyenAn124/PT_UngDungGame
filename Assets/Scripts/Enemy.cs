using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float distance = 5f;

    private Vector3 startPos;
    private bool movingRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Lưu vị trí bắt đầu khi game chạy
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Tính toán giới hạn trái và phải dựa trên vị trí bắt đầu và khoảng cách
        float leftBound = startPos.x - distance;
        float rightBound = startPos.x + distance;

        if (movingRight)
        {
            // Di chuyển sang phải
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            // Kiểm tra nếu chạm hoặc vượt quá biên phải
            if (transform.position.x >= rightBound)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            // Di chuyển sang trái
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            // Kiểm tra nếu chạm hoặc vượt quá biên trái
            if (transform.position.x <= leftBound)
            {
                movingRight = true;
                Flip();
            }
        }
        void Flip()
        {
            Vector3 scaler=transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
        }
    }
}
