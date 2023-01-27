using UnityEngine;

public class PinGroup : MonoBehaviour
{
    private Pin[] pins;
    private int fallCount = 0;
    private Vector3[] positions;
    private Quaternion[] rotations;
    //public AudioSource hitSource;

    private void Start()
    {
        //hitSource = GetComponent<AudioSource>();
    }

    protected void Awake()
    {
        pins = GetComponentsInChildren<Pin>();
        SavePositions();
    }

    public void SavePositions()
    {
        positions = new Vector3[pins.Length];
        rotations = new Quaternion[pins.Length];
        for (int index = 0; index < pins.Length; index++)
        {
            positions[index] = pins[index].transform.position;
            rotations[index] = pins[index].transform.rotation;
        }
    }

    public void ResetPositions()
    {
        for (int index = 0; index < pins.Length; index++)
        {
            if (pins[index].transform.position != positions[index])
            {
                fallCount++;
            }
            pins[index].transform.position = positions[index];
            pins[index].transform.rotation = rotations[index];
            pins[index].CancelToppleCheck();
            Rigidbody pinRigidbody = pins[index].GetComponent<Rigidbody>();
            pinRigidbody.velocity = Vector3.zero;
            pinRigidbody.angularVelocity = Vector3.zero;
            pins[index].gameObject.SetActive(true);

        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //if (collision.gameObject.tag == "Ball")
    // hitSource.Play();
    //}
}