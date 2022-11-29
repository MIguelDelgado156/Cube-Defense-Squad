using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split_reset : MonoBehaviour
{
    public GameObject splitter;
    public GameObject OGsplitter;
    private GameObject newSplit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void resetSplitter(){
        newSplit = Instantiate(splitter, OGsplitter.transform.position, OGsplitter.transform.rotation);
        newSplit.transform.parent = this.transform;
        Destroy(OGsplitter);
        OGsplitter = newSplit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
