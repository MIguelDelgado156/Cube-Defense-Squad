using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split_reset : MonoBehaviour
{
    public GameObject splitter;
    public GameObject[] OGsplitters;
    private GameObject newSplit;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void resetSplitter(){
        index = 0;
        foreach(GameObject split in OGsplitters){
            newSplit = Instantiate(splitter, split.transform.position, split.transform.rotation);
            newSplit.transform.parent = this.transform;
            Destroy(split);
            OGsplitters[index] = newSplit;
            index = index + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
