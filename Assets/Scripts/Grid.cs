using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid<TGridObject>
{
    private int width;
    private int height;
    private TGridObject[,] gridArray;
    private float cellSize;
    private Vector3 OriginPosition;//绘制起点
    private TextMesh[,] debugTextArray;

    public Grid(int width,int height , float cellSize,Vector3 OriginPosition)//绘制网格
    {
        this.width=width;
        this.height=height;
        this.cellSize=cellSize;
        this.OriginPosition=OriginPosition;

        gridArray = new TGridObject[width,height];
        debugTextArray = new TextMesh[width, height];

        for (int x=0; x<gridArray.GetLength(0);x++)
        {
            for(int y=0; y<gridArray.GetLength(1);y++)
            {
                
                debugTextArray[x,y] =  UtilsClass.CreateWorldText(gridArray[x,y].ToString(),null,GetWorldPosition(x,y) + new Vector3(cellSize , cellSize) *.5f,20,Color.white , TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(x,y),GetWorldPosition(x,y+1),Color.white,100f);
                Debug.DrawLine(GetWorldPosition(x,y),GetWorldPosition(x+1,y),Color.white,100f);
            }
            
        }
        Debug.DrawLine(GetWorldPosition(0,height),GetWorldPosition(width,height),Color.white,100f);
        Debug.DrawLine(GetWorldPosition(width,0),GetWorldPosition(width,height),Color.white,100f);
    }

    private Vector3 GetWorldPosition(int x ,int y)
    {
        return new Vector3(x,y)*cellSize + OriginPosition;
    }

    private void GetXY(Vector3 worldPosition , out int x,out int y)
    {
        x=Mathf.FloorToInt((worldPosition -OriginPosition).x / cellSize);
        y=Mathf.FloorToInt((worldPosition -OriginPosition).y / cellSize);
    }

    public void SetValue(int x,int y,TGridObject value) 
    {
        if(x >=0 && y>=0 &&x< width&& y <height)//筛选无效值
        {
            gridArray[x,y] = value;
            debugTextArray[x,y].text = gridArray[x,y].ToString();
        }
    }

    public void SetValue(Vector3 WorldPostion , TGridObject value)
    {
        int x,y;
        GetXY(WorldPostion ,out x,out y);
        SetValue(x,y,value);
    }

    public TGridObject GetValue(int x, int y )
    {
        if(x >=0 && y >=0 && x<width &&y < height)
        {
            return gridArray[x,y];
        }
        else
        {
            return default(TGridObject);
        }
    }

    public TGridObject GetValue(Vector3 worldPosition)
    {
        int x,y;
        GetXY(worldPosition , out x ,out y);
        return GetValue(x,y);
    }

}
