using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrfab; //������ ź���� ���� ������
    public float spawnRateMin = 0.5f; // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f; // �ִ� ���� �ֱ�

    private Transform targt; //�߻��� ���
    private float spawnRate; // ���� �ֱ�
    private float timeAfterSpawn; // �ֱ� ���� �������� ���� �ð�
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
