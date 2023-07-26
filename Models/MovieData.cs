using Microsoft.ML.Data;

public class MovieData
{
    [LoadColumn(0)]
    public float Id;

    [LoadColumn(1)]
    public string Title;

    [LoadColumn(2)]
    public string Genres;

    [LoadColumn(3)]
    public string Original_Language;

    [LoadColumn(4)]
    public float Vote_Average;
}
