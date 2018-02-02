using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickJudgment : MonoBehaviour
{
    GameObject coma;
    public GameObject space_P;

    public enum Type
    {
        ASHIGARU,
        SOUHEI,
        KIHEI,
        SEKKOU,
        KONOEHEI,
        SHOUGUN,
        YOUHEI,
        BAN
    };
    public Type type;

    public Vector3[] pos;

    public int spaceNum;

    GameObject spaceGroup;

    // Use this for initialization
    void Start()
    {
        spaceGroup = GameObject.Find("SpaceGroup");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Select()
    {
        for (int i = 0; i < spaceGroup.transform.childCount; i++)
        {
            Destroy(spaceGroup.transform.GetChild(i).gameObject);
        }

        GameObject space;
        switch (type)
        {
            case Type.ASHIGARU:
                AddSpace(transform.position + new Vector3(0, -0.5f, -1));
                AddSpace(transform.position + new Vector3(1, -0.5f, 1));
                AddSpace(transform.position + new Vector3(-1, -0.5f, 1));
                break;

            case Type.SOUHEI:
                for (int i = 1; i < 9; i++)
                {
                    AddSpace(transform.position + new Vector3(i, -0.5f, 0));
                    AddSpace(transform.position + new Vector3(0, -0.5f, i));
                    AddSpace(transform.position + new Vector3(0, -0.5f, -i));
                    AddSpace(transform.position + new Vector3(-i, -0.5f, 0));
                }
                break;

            case Type.KIHEI:
                AddSpace(transform.position + new Vector3(1, -0.5f, 2));
                AddSpace(transform.position + new Vector3(-1, -0.5f, 2));
                AddSpace(transform.position + new Vector3(2, -0.5f, 1));
                AddSpace(transform.position + new Vector3(2, -0.5f, -1));
                AddSpace(transform.position + new Vector3(1, -0.5f, -2));
                AddSpace(transform.position + new Vector3(-1, -0.5f, -2));
                AddSpace(transform.position + new Vector3(-2, -0.5f, 1));
                AddSpace(transform.position + new Vector3(-2, -0.5f, -1));
                break;

            case Type.SEKKOU:
                for (int i = 1; i < 9; i++)
                {
                    AddSpace(transform.position + new Vector3(i, -0.5f, i));
                    AddSpace(transform.position + new Vector3(-i, -0.5f, -i));
                    AddSpace(transform.position + new Vector3(i, -0.5f, -i));
                    AddSpace(transform.position + new Vector3(-i, -0.5f, i));
                }
                break;

            case Type.KONOEHEI:
                AddSpace(transform.position + new Vector3(-1, -0.5f, 1));
                AddSpace(transform.position + new Vector3(0, -0.5f, 1));
                AddSpace(transform.position + new Vector3(1, -0.5f, 1));
                AddSpace(transform.position + new Vector3(-1, -0.5f, 0));
                AddSpace(transform.position + new Vector3(1, -0.5f, 0));
                AddSpace(transform.position + new Vector3(0, -0.5f, -1));
                break;

            case Type.SHOUGUN:
                AddSpace(transform.position + new Vector3(-1, -0.5f, 1));
                AddSpace(transform.position + new Vector3(0, -0.5f, 1));
                AddSpace(transform.position + new Vector3(1, -0.5f, 1));
                AddSpace(transform.position + new Vector3(-1, -0.5f, 0));
                AddSpace(transform.position + new Vector3(1, -0.5f, 0));
                AddSpace(transform.position + new Vector3(-1, -0.5f, -1));
                AddSpace(transform.position + new Vector3(0, -0.5f, -1));
                AddSpace(transform.position + new Vector3(1, -0.5f, -1));
                break;

            case Type.YOUHEI:
                for (int i = 1; i < 9; i++)
                {
                    AddSpace(transform.position + new Vector3(i, -0.5f, 0));
                    AddSpace(transform.position + new Vector3(0, -0.5f, i));
                    AddSpace(transform.position + new Vector3(0, -0.5f, -i));
                    AddSpace(transform.position + new Vector3(-i, -0.5f, 0));
                    AddSpace(transform.position + new Vector3(i, -0.5f, i));
                    AddSpace(transform.position + new Vector3(-i, -0.5f, -i));
                    AddSpace(transform.position + new Vector3(i, -0.5f, -i));
                    AddSpace(transform.position + new Vector3(-i, -0.5f, i));
                }
                break;

            case Type.BAN:
                break;
        }
    }

    void AddSpace(Vector3 pos)
    {
        GameObject space;
        space = Instantiate(space_P) as GameObject;
        space.transform.position = pos;
        space.transform.parent = spaceGroup.transform;
    }


}
