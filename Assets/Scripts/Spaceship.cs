using UnityEngine;

// Rigidbody2Dコンポーネントを必須にする
[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour
{
	// 移動スピード
	public float speed;
	
	// 弾を撃つ間隔
	public float shotDelay;
	
	// 弾のPrefab
	public GameObject bullet;
	
    // 弾を撃つかどうか
    public bool canShot;

    // 爆発の作成
    public GameObject explosion;

	// アニメーターコンポーネント
	public Animator animator;

	void Start ()
	{
		animator = GetComponent<Animator> ();
	}

    public void Explosion ()
    {
        Instantiate (explosion, transform.position, transform.rotation);
    }
	
	// 弾の作成
	public void Shot (Transform origin)
	{
		Instantiate (bullet, origin.position, origin.rotation);
	}
	
	// 機体の移動
	public void Move (Vector2 direction)
	{
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}

	// アニメーターコンポーネントの取得
	public Animator GetAnimator ()
	{
		return animator;
	}
}