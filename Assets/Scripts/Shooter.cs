using UnityEngine;

public class Shooter : MonoBehaviour
{
	public GameObject projectilePrefab;
	
    void Update()
    {
		if (Input.GetButtonDown("Fire2"))
		{
			var projectile = GameObject.Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
			//projectilePrefab.GetComponent<AudioSource>().Play();
		}
	}
}
