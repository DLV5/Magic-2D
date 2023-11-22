using Cinemachine;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [Header("Camera Settings")]
    [SerializeField] private CinemachineVirtualCamera camera;

    [Header("Player Settings")]
    [SerializeField] private GameObject playerSpawnPoint;
    [SerializeField] private GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = Instantiate(playerPrefab, playerSpawnPoint.transform.position, Quaternion.identity);
        camera.Follow = player.transform;
    }
}
