using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaGene : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // ここ丸々GPTに投げてもいいかもね
        // Resources のスプライトと見なせるものすべてに対して、
        foreach (Sprite s in Resources.LoadAll<Sprite>(""))
        {
            // Prefab をインスタンス化する(objとして)
            GameObject obj = Instantiate(prefab);
            // obj のスプライト管理情報を持ってくる
            SpriteRenderer sr = prefab.GetComponent<SpriteRenderer>();
            // obj のスプライトを s (すべてのうちの一つ) にする
            sr.sprite = s;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
