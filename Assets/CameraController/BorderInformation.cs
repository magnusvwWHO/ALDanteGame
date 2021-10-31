using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderInformation : MonoBehaviour {
    public float LeftBorder
        { get => _leftBorder; private set => _leftBorder = value; }
    public float RightBorder 
        { get => _rightBorder; private set => _rightBorder = value; }
    public float TopBorder
        { get => _topBorder; private set => _topBorder = value; }
    public float BottomBorder
        { get => _bottomBorder; private set => _bottomBorder = value; }
    public Vector2 Target
        { get => _target; private set => _target = value; }
    public bool IsPoint
        { get => _isPoint; private set => _isPoint = value; }

    [SerializeField]
    private float _leftBorder;
    [SerializeField]
    private float _rightBorder;
    [SerializeField]
    private float _topBorder;
    [SerializeField]
    private float _bottomBorder;
    [SerializeField]
    private Vector2 _target;
    [SerializeField]
    private bool _isPoint;

    public void CorrectPosition(ref Vector2 position) {
        if (position.x < LeftBorder) {
            position.x = LeftBorder;
        } 
        else if (position.x > RightBorder) {
            position.x = RightBorder;
        }
        if (position.y > TopBorder) {
            position.y = TopBorder;
        } 
        else if (position.y < BottomBorder) {
            position.y = BottomBorder;
        }
    }

    private void ChangeBorder(float left, float right, float top, float bottom) {
        if ((left == right) && (top == bottom)) {
            IsPoint = true;
        }
        if ((left <= right) && (top >= bottom)) {
            LeftBorder = left;
            RightBorder = right;
            TopBorder = top;
            BottomBorder = bottom;
        }
    }
}
