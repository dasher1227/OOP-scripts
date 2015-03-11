using UnityEngine;
using System.Collections;

public class Bullet : TempObject {
    public float speed;
    private float lifeTime = 0f;
    public float maxLifeTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float delta = Time.deltaTime;
        transform.Translate(Vector3.forward * speed * delta);
        
        {
            
        }
	
	}
    void removeBullet()
    {
        Destroy(this.gameObject);
    }
    void removeOnImpact() 
    {
      lifeTime += delta;
      if (lifeTime > maxLifeTime)
          Destroy(this.gameObject);
      { }
    }

}
