using UnityEngine;

public class Graph : MonoBehaviour {

    [SerializeField]
    Transform pointPrefab;

    [SerializeField, Range(10, 200)]
    int resolution = 10;

    Transform[] points;
    float[] yPositions;
    float timeToWait;

    void Awake() {
        var file = Resources.Load<TextAsset>("heart_rate_normalized");
        var split = file.text.Split("\n");
        yPositions = new float[split.Length];
        for (int i = 0; i < split.Length; i++) {
            yPositions[i] = float.Parse(split[i]) * 4.0f;
        }

        float step = 10f / resolution;
        var scale = Vector3.one * step;
        var position = Vector3.zero;
        points = new Transform[resolution];

        for (int i = 0; i < points.Length; i++) {
            Transform point = points[i] = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - 1f;
            position.y = yPositions[i % yPositions.Length];
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform, false);
        }
    }

    // Start is called before the first frame update
    void Start() {
        timeToWait = Time.fixedTime + 0.1f;
    }

    // Update is called once per frame
    void Update() {
        // position.y = ECG(position.x + +Time.time);
        // float time = Time.time;
        // for (int i = 0; i < points.Length; i++) {
        //     Transform point = points[i];
        //     Vector3 position = point.localPosition;
        //     // TODO: use heartbeat data
        //     // position.y = Mathf.Sin(Mathf.PI * (position.x + time));
        //     position.y = yPositions[(int)(i + time) % yPositions.Length];
        //     if (i == 0) {
        //         Debug.LogWarning(position.y.ToString());
        //     }
        //     point.localPosition = position;
        // }
    }

    void FixedUpdate() {
        if (Time.fixedTime >= timeToWait) {
            timeToWait = Time.fixedTime + 0.1f;
            float time = Time.time;
            for (int i = 0; i < points.Length; i++) {
                Transform point = points[i];
                Vector3 position = point.localPosition;
                position.y = yPositions[(int)(i + time) % yPositions.Length];
                point.localPosition = position;
            }
        }
    }

    float ECG(float x) {
        var a = 0.2f;
        var d = 1.4f;
        var h = 3f;
        var s = 0.05f;
        var w = 0.02f;

        return a * (Mathf.Exp((-((x + d) * (x + d))) / (2 * w)) + Mathf.Exp((-((x - d) * (x - d))) / (2 * w))) + (h - Mathf.Abs(x / s) - x) * Mathf.Exp((-(7 * x) * (7 * x)) / 2);
    }
}
