using Microsoft.Extensions.DependencyInjection;

public interface ICoreModule
{
    void Load(IServiceCollection serviceCollection);
}