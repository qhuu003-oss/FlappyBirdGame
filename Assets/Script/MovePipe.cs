using UnityEngine;

public class MovePipe : GameObjectBase, IGameAction
{
    public float moveSpeed = 3f;
    public float deadZone = -30f;

    void Update()
    {
        DoAction();
    }

    public override void DoAction()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}