using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public BorderInformation KitchenBorder
        { get => _kitchenBorder; private set => _kitchenBorder = value; }
    public BorderInformation HallBorder
        { get => _hallBorder; private set => _hallBorder = value; }
    public BorderInformation CurrentBorder
        { get => _currentBorder; private set => _currentBorder = value; }
    public bool BlockMove 
        { get => _blockMove; private set => _blockMove = value; }
    

    [SerializeField]
    private Vector2 _target;
    [SerializeField]
    private BorderInformation _kitchenBorder;
    [SerializeField]
    private BorderInformation _hallBorder;
    [SerializeField]
    private BorderInformation _currentBorder;
    [SerializeField]
    private bool _blockMove; 

    private void ChangePosition() {
        //TODO: Реализовать считывание движения пальца
    }

    private void ChangeCurrentBorder(BorderInformation newBorder, bool smothly) {
        if (CurrentBorder != newBorder) {
            if (smothly == true) {
                _target = newBorder.Target;
                BlockMove = true;
            }
            else {
                transform.position = newBorder.Target;
            }
            CurrentBorder = newBorder;
        }
    }

    private void Update() {
        ChangePosition();
    }
}