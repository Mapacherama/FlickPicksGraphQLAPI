using Microsoft.ML;
using Microsoft.ML.Trainers;
using System.Collections.Generic;
using System.Data;

namespace FlickPicksGraphQLAPI.Machine_Learning
{
    public class RecommendationEngine
    {
        private readonly MLContext _mlContext;
        private readonly ITransformer _model;
        private readonly ModelBuilder _modelBuilder;

        public RecommendationEngine(MLContext mlContext, string modelPath, ModelBuilder modelBuilder)
        {
            _mlContext = mlContext;
            _model = _mlContext.Model.Load(modelPath, out _);
            _modelBuilder = modelBuilder;
        }

        public List<MovieData> RecommendMoviesForUser(int userId, int numRecommendations)
        {

            // Step 1: Prepare your data
            var dataView = _modelBuilder.BuildModel();

            // Step 2: Transform your data
            var pipeline = _mlContext.Transforms.Conversion.MapValueToKey("MovieId")
                .Append(_mlContext.Transforms.Conversion.MapValueToKey("UserId"))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding("Genres"))
                .Append(_mlContext.Transforms.Concatenate("Features", "MovieId", "UserId", "Genres"))
                .Append(_mlContext.Transforms.NormalizeMinMax("Features"))
                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("MovieId"))
                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("UserId"));

            // Step 3: Choose an algorithm
            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = "UserIdEncoded",
                MatrixRowIndexColumnName = "MovieIdEncoded",
                LabelColumnName = "Label",
                NumberOfIterations = 20,
                ApproximationRank = 100
            };
            var trainer = _mlContext.Recommendation().Trainers.MatrixFactorization(options);

            // Step 4: Train your model
            var model = pipeline.Append(trainer).Fit(dataView);

            // Step 5: Evaluate your model
            // This step would require a separate test dataset

            // Step 6: Use your model
            // You can now use the 'model' object to make predictions

        }
    }
}
