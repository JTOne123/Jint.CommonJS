
namespace Jint.ModuleLoader
{
    public static class EngineExtensions
    {
        public static ModuleLoadingEngine CommonJS(this Jint.Engine e)
        {
            return new ModuleLoadingEngine(e);
        }
    }
}