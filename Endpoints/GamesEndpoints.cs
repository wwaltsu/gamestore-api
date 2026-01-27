using GameStore.Api.Dtos;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{
    const string GetGameEndpointName = "GetGame";

    private static readonly List<GameDto> games = [
    new (1, "Cult of Lambs","Action", 9.99M, new DateOnly(2002, 2, 8)),
    new (2, "Hollow Knight: Silksong","Adventure", 29.99M, new DateOnly(2025, 4, 9)),
    new (3, "ELDEN RING","RPG", 59.99M, new DateOnly(2022, 2, 25))
    ];

    public static void MapGameEndpoints(this WebApplication app)
    {
        var gamesGroup = app.MapGroup("/games");

        // GET /games
        gamesGroup.MapGet("/", () => games);

        // GET /games/1
        gamesGroup.MapGet("/{id}", (int id) =>
        {
            var game = games.Find(game => game.Id == id);

            return game is null ? Results.NotFound() : Results.Ok(game);
        })
        .WithName(GetGameEndpointName);

        // POST /games
        gamesGroup.MapPost("/", (CreateGameDto newGame) =>
        {
            GameDto game = new(
         games.Count + 1,
         newGame.Name,
         newGame.Genre,
         newGame.Price,
         newGame.ReleaseDate
            );
            games.Add(game);

            return Results.CreatedAtRoute(GetGameEndpointName, new
            {
                id = game.Id
            }, game);
        });

        // PUT /games/1
        gamesGroup.MapPut("/{id}", (int id, UpdateGameDto updateGame) =>

        {
            var index = games.FindIndex(game => game.Id == id);
            if (index == -1)
                return Results.NotFound();

            games[index] = new GameDto(
                id,
                updateGame.Name,
                updateGame.Genre,
                updateGame.Price,
                updateGame.ReleaseDate
            );
            return Results.NoContent();
        });

        // DELETE /games/1
        gamesGroup.MapDelete("/{id}", (int id) =>
        {
            var removed = games.RemoveAll(game => game.Id == id);

            return removed == 0 ? Results.NotFound() : Results.NoContent();
        });
    }

}
