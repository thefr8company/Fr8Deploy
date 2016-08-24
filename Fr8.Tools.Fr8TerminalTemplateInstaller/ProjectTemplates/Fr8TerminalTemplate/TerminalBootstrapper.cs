using StructureMap;

namespace $safeprojectname$
{
    public static class TerminalBootstrapper
    {
        public static void ConfigureSlackDependencies(this IContainer container)
        {
            container.Configure(ConfigureLive);
        }

        /**********************************************************************************/

        public static void ConfigureLive(ConfigurationExpression configurationExpression)
        {
            //configurationExpression.For<IEvent>().Use<Event>();
        }
    }
}