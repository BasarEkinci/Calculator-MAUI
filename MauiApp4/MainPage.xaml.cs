namespace MauiApp4;

public enum OperationType
{
    None,
    Sum,
    Substraction,
    Multiply,
    Divide,
    Mode
}


public partial class MainPage : ContentPage
{
    #region Variables
    string displayNumber = string.Empty;
    double? firstNumber = null;
    double? secondNumber = null;
    double? result = null;
    double? reversedNumber;
    bool isEqualsClicked = false;


    OperationType currentOperation = OperationType.None;

    #endregion
    public MainPage() => InitializeComponent();



    #region Operation Buttons
    private void C_Button_Clicked(object sender, EventArgs e)
    {

        currentOperation = OperationType.None;

        ResultLabel.Text = "0";
        secondNumber = null;
        firstNumber = null;
        secondNumber = null;
        isEqualsClicked = false;
        displayNumber = string.Empty;
    }

    private void ChangeSign_Button_Clicked(object sender, EventArgs e)
    {
        if (displayNumber == "0") return;

        if (displayNumber != string.Empty)
        {
            reversedNumber = double.Parse(displayNumber) * -1;
            displayNumber = reversedNumber.ToString();
            ResultLabel.Text = displayNumber;
        }
        else
        {
            isEqualsClicked = false;
            reversedNumber = result;
            result *= -1;
            displayNumber = result.ToString();
            ResultLabel.Text = displayNumber;
        }

    }

    private void Mode_Button_Clicked(object sender, EventArgs e)
    {
        if (currentOperation == OperationType.None)
        {
            currentOperation = OperationType.Mode;
            firstNumber = double.Parse(displayNumber);
            displayNumber = string.Empty;
        }
        else if (currentOperation == OperationType.Mode)
        {
            isEqualsClicked = false;
            firstNumber %= double.Parse(displayNumber);
            ResultLabel.Text = firstNumber.ToString();
            displayNumber = string.Empty;
        }
        else
        {
            MakePreviousOperation();
            currentOperation = OperationType.Mode;
        }
    }

    private void DivideButton_Clicked(object sender, EventArgs e)
    {
        if (currentOperation == OperationType.None)
        {
            currentOperation = OperationType.Substraction;
            firstNumber = double.Parse(displayNumber);
            displayNumber = string.Empty;
        }
        else if (currentOperation == OperationType.Divide)
        {
            isEqualsClicked = false;
            firstNumber /= double.Parse(displayNumber);
            ResultLabel.Text = firstNumber.ToString();
            displayNumber = string.Empty;
        }
        else
        {

            MakePreviousOperation();
            currentOperation = OperationType.Divide;
        }
    }

    private void Multiply_Button_Clicked(object sender, EventArgs e)
    {
        if (currentOperation == OperationType.None)
        {
            currentOperation = OperationType.Multiply;
            firstNumber = double.Parse(displayNumber);
            displayNumber = string.Empty;
        }
        else if (currentOperation == OperationType.Multiply)
        {
            isEqualsClicked = false;
            firstNumber *= double.Parse(displayNumber);
            ResultLabel.Text = firstNumber.ToString();
            displayNumber = string.Empty;
        }
        else
        {

            MakePreviousOperation();
            currentOperation = OperationType.Multiply;
        }
    }

    private void Substraction_Button_Clicked(object sender, EventArgs e)
    {
        if (currentOperation == OperationType.None)
        {
            currentOperation = OperationType.Substraction;
            firstNumber = double.Parse(displayNumber);
            displayNumber = string.Empty;
        }
        else if (currentOperation == OperationType.Substraction)
        {
            isEqualsClicked = false;
            firstNumber -= double.Parse(displayNumber);
            ResultLabel.Text = firstNumber.ToString();
            displayNumber = string.Empty;
        }
        else
        {

            MakePreviousOperation();
            currentOperation = OperationType.Substraction;
        }
    }

    private void Sum_Button_Clicked(object sender, EventArgs e)
    {
        if (currentOperation == OperationType.None)
        {
            currentOperation = OperationType.Sum;
            firstNumber = double.Parse(displayNumber);
            displayNumber = string.Empty;
        }
        else if (currentOperation == OperationType.Sum)
        {
            isEqualsClicked = false;
            firstNumber += double.Parse(displayNumber);
            ResultLabel.Text = firstNumber.ToString();
            displayNumber = string.Empty;
        }
        else
        {

            MakePreviousOperation();
            currentOperation = OperationType.Sum;
        }
    }

    private void Dot_Button_Clicked(object sender, EventArgs e)
    {
    }

    private void Equals_Button_Clicked(object sender, EventArgs e)
    {
        SetResult();
    }
    #endregion
    private void MakePreviousOperation()
    {
        if (isEqualsClicked) return;
        switch (currentOperation)
        {
            case OperationType.Sum:
                firstNumber += double.Parse(displayNumber);
                ResultLabel.Text = firstNumber.ToString();
                displayNumber = string.Empty;
                break;
            case OperationType.Substraction:
                firstNumber -= double.Parse(displayNumber);
                ResultLabel.Text = firstNumber.ToString();
                displayNumber = string.Empty;
                break;
            case OperationType.Multiply:
                firstNumber -= double.Parse(displayNumber);
                ResultLabel.Text = firstNumber.ToString();
                displayNumber = string.Empty;
                break;
            case OperationType.Divide:
                firstNumber -= double.Parse(displayNumber);
                ResultLabel.Text = firstNumber.ToString();
                displayNumber = string.Empty;
                break;
        }
    }
    private void SetResult()
    {
        if (secondNumber == null)
        {
            secondNumber = double.Parse(displayNumber);
        }
        isEqualsClicked = true;
        switch (currentOperation)
        {
            case OperationType.Sum:
                result = firstNumber + secondNumber;
                ResultLabel.Text = result.ToString();
                firstNumber = result;
                displayNumber = string.Empty;
                break;
            case OperationType.Substraction:
                result = firstNumber - secondNumber;
                ResultLabel.Text = result.ToString();
                firstNumber = result;
                displayNumber = string.Empty;
                break;
            case OperationType.Multiply:
                result = firstNumber * secondNumber;
                ResultLabel.Text = result.ToString();
                firstNumber = result;
                displayNumber = string.Empty;
                break;
            case OperationType.Divide:
                result = firstNumber / secondNumber;
                ResultLabel.Text = result.ToString();
                firstNumber = result;
                displayNumber = string.Empty;
                break;
        }
    }
    #region Number Buttons


    private void Button_0_Clicked(object sender, EventArgs e)
    {
        displayNumber += "0";
        ResultLabel.Text = displayNumber;
    }

    private void Button_1_Clicked(object sender, EventArgs e)
    {
        displayNumber += "1";
        ResultLabel.Text = displayNumber;
    }

    private void Button_2_Clicked(object sender, EventArgs e)
    {
        displayNumber += "2";
        ResultLabel.Text = displayNumber;
    }

    private void Button_3_Clicked(object sender, EventArgs e)
    {
        displayNumber += "3";
        ResultLabel.Text = displayNumber;
    }

    private void Button_4_Clicked(object sender, EventArgs e)
    {
        displayNumber += "4";
        ResultLabel.Text = displayNumber;
    }

    private void Button_5_Clicked(object sender, EventArgs e)
    {
        displayNumber += "5";
        ResultLabel.Text = displayNumber;
    }

    private void Button_6_Clicked(object sender, EventArgs e)
    {
        displayNumber += "6";
        ResultLabel.Text = displayNumber;
    }

    private void Button_7_Clicked(object sender, EventArgs e)
    {
        displayNumber += "7";
        ResultLabel.Text = displayNumber;
    }

    private void Button_8_Clicked(object sender, EventArgs e)
    {
        displayNumber += "8";
        ResultLabel.Text = displayNumber;
    }

    private void Button_9_Clicked(object sender, EventArgs e)
    {
        displayNumber += "9";
        ResultLabel.Text = displayNumber;
    }


    #endregion
}