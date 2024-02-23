namespace RoutingSampleApplication.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; init; } = default!;
        public string Email { get; init; } = default!;

    }
}
