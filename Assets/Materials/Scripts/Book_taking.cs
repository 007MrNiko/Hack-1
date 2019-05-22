using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_taking : MonoBehaviour
{
    public int PickedUp = 0;
    public GameObject BOOK;
    public GameObject Writer;
    void TakeBook()
    {
        Destroy(BOOK);
        PickedUp++;
    }
}