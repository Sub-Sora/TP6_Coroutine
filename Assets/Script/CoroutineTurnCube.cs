using System.Collections;
using UnityEngine;

public class CoroutineTurnCube : MonoBehaviour
{
    [SerializeField] private float _rotationSpd;
    private Coroutine _turnCubeCoroutine;

    IEnumerator TurnCube()
    {
        float totalTime = 0f;
        while (totalTime < 5f)
        {
            transform.Rotate(new Vector3(0f, _rotationSpd * Time.deltaTime, 0f));
            totalTime += Time.deltaTime;
            yield return null;
        }
        _turnCubeCoroutine = null;
    }

    public void StartTurnCube()
    {
        if (_turnCubeCoroutine == null)
        {
            _turnCubeCoroutine = StartCoroutine(TurnCube());
        }
    }

    public void PauseTurnCube()
    {
        if (_turnCubeCoroutine != null)
        {
            StopCoroutine(_turnCubeCoroutine);
            _turnCubeCoroutine = null;
        }
    }
}
