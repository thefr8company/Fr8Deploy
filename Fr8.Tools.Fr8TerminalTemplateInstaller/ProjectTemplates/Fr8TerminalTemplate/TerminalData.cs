using Fr8.Infrastructure.Data.DataTransferObjects;
using Fr8.Infrastructure.Data.States;
using Fr8.Infrastructure.Utilities.Configuration;

namespace $safeprojectname$
{
    public static class TerminalData
    {
        public static ActivityCategoryDTO ActivityCategoryDTO = new ActivityCategoryDTO
        {
            Name = "MyService",
            IconPath = "/Content/icons/web_services/My-service-icon-64x64.png",
            Type = "WebService"
        };

        public static TerminalDTO TerminalDTO = new TerminalDTO
        {
            Endpoint = CloudConfigurationManager.GetSetting("terminalMyService.TerminalEndpoint"),
            TerminalStatus = TerminalStatus.Active,
            Name = "terminalMyService",
            Label = "MyService",
            Version = "1",
            AuthenticationType = AuthenticationType.External
        };
    }
}