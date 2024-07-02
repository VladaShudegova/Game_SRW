using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BalanceScale : MonoBehaviour
{
    public Slider balanceSlider;
    private float decreaseRate = 0.025f;
    private float healthyFoodIncrease = 0.1f;
    private float fastFoodIncrease = 0.2f;

    private void Start()
    {
        balanceSlider.value = 0.5f;
    }

    private void Update()
    {
        DecreaseBalance();
    }

    public void DecreaseBalance()
    {
        if (balanceSlider.value > 0)
        {
            balanceSlider.value -= decreaseRate * Time.deltaTime;
        }
    }

    public void IncreaseBalance(bool isHealthyFood)
    {
        if (balanceSlider.value < 1)
        {
            if (isHealthyFood)
            {
                balanceSlider.value += healthyFoodIncrease;
            }
            else
            {
                balanceSlider.value += fastFoodIncrease;
            }
        }
    }
}