namespace YMF_2.JsonModels;

public class Accuracy
{
    public int MaxIter { get; init; }
    public double Eps { get; init; }
    public double Delta { get; init; }

    public bool AutoRelax { get; init; }

    public double RelaxRatio { get; init; }
    
}