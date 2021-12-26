using Dapper;
using System.Data;
using System.Data.SqlClient;
using car_simulator_api.Models;
using car_simulator_api.Options;

namespace car_simulator_api.Services
{
    public class PlayerService
    {
        public static List<PlayerModel> GetAllPlayers()
        {
            using SqlConnection connection = new(GeneralOption.SqlServerConnectionString);

            return connection.Query<PlayerModel>(
                "ProcPlayerGetAll",
                commandType: CommandType.StoredProcedure
                ).ToList();
        }

        public static PlayerModel? GetAPlayer(Guid id)
        {
            using SqlConnection connection = new(GeneralOption.SqlServerConnectionString);

            return connection.Query<PlayerModel>(
                "ProcPlayerGetById",
                new { Id = id },
                commandType: CommandType.StoredProcedure
                ).FirstOrDefault();
        }

        public static int InsertPlayer(PlayerModel player)
        {
            using SqlConnection connection = new(GeneralOption.SqlServerConnectionString);

            return connection.Execute(
                "ProcPlayerInsert",
                player,
                commandType: CommandType.StoredProcedure
                );
        }
    }
}
