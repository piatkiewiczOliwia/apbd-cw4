namespace LegacyApp.Tests;

public class FakeClientRepository : IClientRepository
{
    public Client GetById(int idClient)
    {
        return new Client();
    }
}