namespace NerdStore.Pagamentos.AntiCorruption
{
    public interface IConfigManager
    {
        string GetValue(string node);
    }
}