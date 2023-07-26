using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace FlickPicksGraphQLAPI.Machine_Learning
{
    public class ModelBuilder
    {
        private readonly MLContext _mlContext;

        public ModelBuilder(MLContext mLContext)
        {
            _mlContext = mLContext;
        }

        public void BuildModel()
        {
            // Load the data
            var dataView = _mlContext.Data.LoadFromTextFile<MovieData>("../Data/top_1000_popular_movies_tmdb.csv", separatorChar: ',', hasHeader: true);

            // Convert the IDataView to an enumerable
            var dataEnumerable = _mlContext.Data.CreateEnumerable<MovieData>(dataView, reuseRowObject: false);

            // Filter the data
            var filteredData = dataEnumerable.Where(x => x.Original_Language == "German" && x.Vote_Average > 6.5);

            // Convert the filtered data back to an IDataView
            var filteredDataView = _mlContext.Data.LoadFromEnumerable(filteredData);

            // Preprocess the data
            var pipeline = _mlContext.Transforms.Text.FeaturizeText("Genres")
                .Append(_mlContext.Transforms.NormalizeMinMax("Genres"));

            var transformedDataView = pipeline.Fit(filteredDataView).Transform(filteredDataView);

            // Compute similarity between items
            // This depends on your specific requirements and might involve custom code
        }


    }
}
