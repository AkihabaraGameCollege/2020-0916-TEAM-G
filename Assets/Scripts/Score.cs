using RunGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// スコアUIを制御します。
public class Score : MonoBehaviour
{
    // 値の表示テキストを指定します。
    [SerializeField]
    private Text valueText = null;

    // Start is called before the first frame update
    void Start()
    {
        UpdateValueText();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateValueText();
    }

    // 値の表示を更新
    private void UpdateValueText()
    {
        var score = StageScene.Instance.Score;
        // 10進数6桁でゼロキャスト
        valueText.text = score.ToString("D06");
    }
}
