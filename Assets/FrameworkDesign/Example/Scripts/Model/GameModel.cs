using FrameworkDesign;

public class GameModel
{
    public enum GameStates
    {
        NoStart,
        Started,
        Over
    }
    // private GameModel(){}
    public BindableProperty<int> KillCount = new BindableProperty<int>()
    {
        Value = 0
    };//【】事件是啥
    // public static int KillCount = 0;
    public BindableProperty<int> Gold = new BindableProperty<int>()
    {
        Value = 0
    };
    public BindableProperty<int> Score = new BindableProperty<int>()
    {
        Value = 0
    };
    public BindableProperty<int> BestScore = new BindableProperty<int>()
    {
        Value = 0
    };

}
