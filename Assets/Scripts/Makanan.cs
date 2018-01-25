using UnityEngine;

public enum ObjectTypeFood
{
    Tempe,
    Ayam,
    Sayur,
    NasiTempe,
    NasiAyam,
    NasiSayur,
    AyamSayur,
    TempeSayur,
    Lengkap,
    Lengkap1
}
public class Makanan : MonoBehaviour {

    public static Makanan Instance;
    public ObjectTypeFood foodType;

    public GameObject[] objChange;

    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;
    private float firstX;

    GameObject makanan;

    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Makanan"))
        {
            makanan = Instantiate(gameObject, transform.position, transform.rotation);
        }
        firstY = transform.position.y;
        firstX = transform.position.x;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    
    private void OnMouseUp()
    {
        transform.position = new Vector3(firstX, firstY, transform.position.z);
        Destroy(makanan);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Base")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (foodType == ObjectTypeFood.Ayam || foodType == ObjectTypeFood.Tempe || foodType == ObjectTypeFood.Sayur)
            {
                makanan = Instantiate(objChange[0], transform.position, transform.rotation);
            }
        }
        else if (collision.gameObject.tag == "Combine")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (foodType == ObjectTypeFood.Ayam)
            {
                if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.NasiSayur)
                {
                    Debug.Log("Test");
                    makanan = Instantiate(objChange[1], transform.position, transform.rotation);
                }
                else if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.NasiTempe)
                {
                    Debug.Log("Test");
                    makanan = Instantiate(objChange[2], transform.position, transform.rotation);
                }
            }
            else if (foodType == ObjectTypeFood.Tempe)
            {
                if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.NasiSayur)
                {
                    Debug.Log("Test");
                    makanan = Instantiate(objChange[1], transform.position, transform.rotation);
                }
                else if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.NasiAyam)
                {
                    Debug.Log("Test");
                    makanan = Instantiate(objChange[2], transform.position, transform.rotation);
                }
            }
            else if (foodType == ObjectTypeFood.Sayur)
            {
                if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.NasiAyam)
                {
                    Debug.Log("Test");
                    makanan = Instantiate(objChange[1], transform.position, transform.rotation);
                }
                else if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.NasiTempe)
                {
                    Debug.Log("Test");
                    makanan = Instantiate(objChange[2], transform.position, transform.rotation);
                }
            }
        }
        else if (collision.gameObject.tag == "Combine1")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (foodType == ObjectTypeFood.Ayam)
            {
                if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.TempeSayur)
                {
                    makanan = Instantiate(objChange[3], transform.position, transform.rotation);
                }
            }
            else if (foodType == ObjectTypeFood.Tempe)
            {
                if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.AyamSayur)
                {
                    makanan = Instantiate(objChange[3], transform.position, transform.rotation);
                }
            }
            else if (foodType == ObjectTypeFood.Sayur)
            {
                if (collision.gameObject.GetComponent<Makanan>().foodType == ObjectTypeFood.Lengkap)
                {
                    makanan = Instantiate(objChange[3], transform.position, transform.rotation);
                }
            }
        }
        else if (collision.gameObject.tag == "Trash")
        {
            Destroy(collision.gameObject);
            SpawnCust.Instance.BaseFood();
        }

        switch (collision.gameObject.GetComponent<Customer>().customerType)
        {
            case ObjectTypeCustomer.Customer1:
                {
                    if (foodType == ObjectTypeFood.NasiAyam)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                        ScoresManager.Instance.AddCoin();
                        Customer.Instance.audioSource.PlayOneShot(Customer.Instance.audioClip);
                        ScoresManager.Instance.AddRep();
                        SpawnCust.Instance.BaseFood();
                    }
                    break;
                }
            case ObjectTypeCustomer.Customer2:
                {
                    if (foodType == ObjectTypeFood.NasiTempe)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                        ScoresManager.Instance.AddCoin();
                        Customer.Instance.audioSource.PlayOneShot(Customer.Instance.audioClip);
                        ScoresManager.Instance.AddRep();
                        SpawnCust.Instance.BaseFood();
                    }
                    break;
                }
            case ObjectTypeCustomer.Customer3:
                {
                    if (foodType == ObjectTypeFood.NasiSayur)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                        ScoresManager.Instance.AddCoin();
                        Customer.Instance.audioSource.PlayOneShot(Customer.Instance.audioClip);
                        ScoresManager.Instance.AddRep();
                        SpawnCust.Instance.BaseFood();
                    }
                    break;
                }
            case ObjectTypeCustomer.Customer4:
                {
                    if (foodType == ObjectTypeFood.TempeSayur)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                        ScoresManager.Instance.AddCoin();
                        Customer.Instance.audioSource.PlayOneShot(Customer.Instance.audioClip);
                        ScoresManager.Instance.AddRep();
                        SpawnCust.Instance.BaseFood();
                    }
                    break;
                }
            case ObjectTypeCustomer.Customer5:
                {
                    if (foodType == ObjectTypeFood.AyamSayur)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                        ScoresManager.Instance.AddCoin();
                        Customer.Instance.audioSource.PlayOneShot(Customer.Instance.audioClip);
                        ScoresManager.Instance.AddRep();
                        SpawnCust.Instance.BaseFood();
                    }
                    break;
                }

            case ObjectTypeCustomer.Customer6:
                {
                    if (foodType == ObjectTypeFood.Lengkap1)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                        ScoresManager.Instance.AddCoin();
                        Customer.Instance.audioSource.PlayOneShot(Customer.Instance.audioClip);
                        ScoresManager.Instance.AddRep();
                        SpawnCust.Instance.BaseFood();
                    }
                    break;
                }

            case ObjectTypeCustomer.Customer7:
                {
                    if (foodType == ObjectTypeFood.Lengkap)
                    {
                        Destroy(collision.gameObject);
                        Destroy(gameObject);
                        ScoresManager.Instance.AddCoin();
                        Customer.Instance.audioSource.PlayOneShot(Customer.Instance.audioClip);
                        ScoresManager.Instance.AddRep();
                        SpawnCust.Instance.BaseFood();
                    }
                    break;
                }
        }
    }
}
