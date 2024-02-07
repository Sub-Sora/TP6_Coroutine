using Cysharp.Threading.Tasks;
using UnityEngine;

public class UnitaskTurnCube : MonoBehaviour
{
    [SerializeField] private float _rotationSpd;
    private bool _isPlayed = true;

    async UniTask TaskTurnCube()
    {
        float totalTime = 0f;
        while (_isPlayed && totalTime < 5f)
        {
            transform.Rotate(new Vector3(0f, _rotationSpd * Time.deltaTime, 0f));
            await UniTask.Delay(1);
            totalTime += Time.deltaTime;
        }
    }

    public async void StartTaskTurnCube()
    {
        _isPlayed = true;
        await TaskTurnCube();
    }

    public void PauseTaskTurnCube()
    {
        if(_isPlayed) _isPlayed = false;
    }
}
