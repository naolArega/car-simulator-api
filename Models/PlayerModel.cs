namespace car_simulator_api.Models
{
    public sealed class PlayerModel
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PlayerTag { get; set; }
    }
}
