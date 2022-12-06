using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public GameObject shootingBall;
    public float ballSpeed = 10;
    public GameObject[] ballsPrefabs;
    
    public Camera _mainCamera;
    public GameObject player;

    //public ShootBalls _ballsPrefab;
    public Transform _spawnPoint;
    private Vector3 playerRotation;

    //Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotaion();
        ShootBall();
    }


    // Rotate the player along the mouse position with circle on the player
    private void PlayerRotaion()
    {
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _mainCamera.transform.position.y))
            playerRotation = hit.point;

        Vector3 playerDirection = playerRotation - transform.position;
        playerDirection.y = 0;

        transform.LookAt(transform.position + playerDirection, Vector3.up);
    }

    private void ShootBall()
    {
        int arraySize = ballsPrefabs.Length;
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(ballsPrefabs[Random.Range(0, arraySize)], player.transform.position, player.transform.rotation.normalized);
        }
    }

}
