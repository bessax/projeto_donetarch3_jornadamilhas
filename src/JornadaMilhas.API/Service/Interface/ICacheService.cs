namespace JornadaMilhas.API.Service.Interface;

public interface ICacheService
{
    Task<T> GetCachedDataAsync<T>(string key);
    Task SetCachedDataAsync<T>(string key, T data, TimeSpan expiration);
    Task RemoveCachedDataAsync(string key);
}