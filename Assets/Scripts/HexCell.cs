using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCell : MonoBehaviour
{

    public HexCoordinates coordinations;
    public Color color;
    [SerializeField]
    HexCell[] neighbors;

    public HexCell GetNeighbor(HexDirection direction)
    {
        return neighbors[(int)direction];
    }

    public void SetNeighbor(HexDirection dirextion, HexCell cell)
    {
        neighbors[(int)dirextion] = cell;
        cell.neighbors[(int)dirextion.Opposite()] = this;
    }



}