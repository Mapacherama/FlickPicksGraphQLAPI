# FlickPicksGraphQLAPI

Welcome to the Movie Recommendation API! This API provides personalized movie recommendations based on user preferences, allowing users to rate movies, receive tailored recommendations, and more.

## Technologies Used

This project is built using the following technologies and libraries:

- **.NET**: The backend is developed using the .NET framework, which provides a robust and scalable platform for building web applications.
- **C#**: The primary programming language used for the backend implementation.
- **Entity Framework Core**: The ORM (Object-Relational Mapping) library used for database operations, providing seamless integration with various database systems.
- **GraphQL**: The API is implemented using the GraphQL query language, enabling efficient and flexible data fetching.
- **Hot Chocolate**: The GraphQL server framework for .NET, used to handle GraphQL operations, schema, and resolvers.
- **SQLite**: The lightweight and file-based database used for development and testing purposes.

## Getting Started

To start using the Movie Recommendation API, follow the steps below:

1. **Clone the repository**: Clone this repository to your local machine using the following command:

``` git clone https://github.com/your-username/movie-recommendation-api.git ```

2. **Database Configuration**: By default, the API is configured to use the SQLite database. You can change the database configuration in the `appsettings.json` file if needed.
3. **Install Dependencies**: Navigate to the project's root directory and restore the project dependencies by running the following command: ``` dotnet restore ```
4. **Run Database Migrations**: Apply the database migrations to create the necessary database schema by executing the following command: ``` dotnet ef database update ```
5. **Start the API**: Launch the API by running the following command: ``` dotnet run ```
6. **API Documentation**: Once the API is running, you can access the GraphQL Playground at `http://localhost:5000/graphql` to explore the available API operations and interact with the API.

## API Endpoints

The API provides the following GraphQL endpoints:

- **/graphql**: The main GraphQL endpoint for making queries, mutations, and subscriptions.
- **/graphql/ui**: The GraphQL Playground UI, providing a graphical interface to interact with the API and explore the schema.

## Contributing

Contributions to the Movie Recommendation API are welcome! If you find any issues or have suggestions for improvement, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
