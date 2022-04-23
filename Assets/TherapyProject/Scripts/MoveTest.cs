using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour
{
    /* public Vector3 pointA;
     public Vector3 pointB;
     public Vector3 pointC;
     public Vector3 pointD;
 */

    // randomize position of butterfly 
    // butterfly flys towards the XR Origin location 

    // figure out collision issue as well 

    public Transform playerPos;
     Vector3 offset;
    public float distance;
    public float radiusOffset; 
    private void Awake()
    {
        float randVal = Random.Range(0.5f, 0.8f); 

        offset = new Vector3(randVal, 0, randVal);


        Debug.Log("offset is " + offset);
    }


    private void Update()
    {
        this.transform.localPosition = Vector3.MoveTowards(this.transform.localPosition, CircularOffset(this.transform.localPosition, playerPos.position+ offset, radiusOffset) , distance);
    }


    Vector3 CircularOffset(Vector3 p1, Vector3 p2, float radius) {
    
        Vector3 dir = (p2 - p1).normalized;
        Vector3 start = p1 + dir * radius;
        Vector3 end = p2 - dir * radius;
        return end; 
    }
    /*  IEnumerator Start()
      {
          // var pointA = transform.position;
          while (true)
          {
              yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.5f));
              yield return StartCoroutine(MoveObject(transform, pointB, pointC, 3.5f));
              yield return StartCoroutine(MoveObject(transform, pointC, pointD, 3.5f));
              yield return StartCoroutine(MoveObject(transform, pointD, pointA, 3.5f));
          }
      }

      IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
      {
          var i = 0.0f;
          var rate = 1.0f / time;
          while (i < 1.0f)
          {
              i += Time.deltaTime * rate;
              thisTransform.position = Vector3.Lerp(startPos, endPos, i);
              yield return null;
          }
      }*/
}