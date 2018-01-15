using UnityEngine;

namespace MinimapConfig
{
    public class Movement : MonoBehaviour
    {
        public float speed = 10f;
        public float rotationSpeed = 10f;

        private Vector3 movement;

        private float rotation;

        // Update is called once per frame
        void Update ()
        {
            movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

            rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        }

        void FixedUpdate ()
        {
            transform.Translate(movement, Space.Self);

            transform.Rotate(0f, rotation, 0f);
        }
    }
}