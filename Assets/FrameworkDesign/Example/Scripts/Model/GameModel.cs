using FrameworkDesign;

public interface IGameModel
{
    public BindableProperty<int> KillCount { get; }
    public BindableProperty<int> Gold { get; }
    public BindableProperty<int> Score { get; }
    public BindableProperty<int> BestScore { get; }
}
public class GameModel:IGameModel
{
    public enum GameStates
    {
        NoStart,
        Started,
        Over
    }
    public BindableProperty<int> KillCount { get; } = new BindableProperty<int>()
    {
        Value = 0
    };
    public BindableProperty<int> Gold { get; } = new BindableProperty<int>()
    {
        Value = 0
    };
    public BindableProperty<int> Score { get; } = new BindableProperty<int>()
    {
        Value = 0
    };
    public BindableProperty<int> BestScore { get; } = new BindableProperty<int>()
    {
        Value = 0
    };
}
