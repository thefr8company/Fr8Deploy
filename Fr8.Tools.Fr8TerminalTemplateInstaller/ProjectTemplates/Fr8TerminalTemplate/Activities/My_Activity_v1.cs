using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fr8.Infrastructure.Data.Control;
using Fr8.Infrastructure.Data.DataTransferObjects;
using Fr8.Infrastructure.Data.Managers;
using Fr8.Infrastructure.Data.Manifests;
using Fr8.TerminalBase.BaseClasses;


namespace $safeprojectname$.Activities
{
    public class My_Activity_v1 : TerminalActivity<My_Activity_v1.ActivityUi>
    {
        public static ActivityTemplateDTO ActivityTemplateDTO = new ActivityTemplateDTO
        {
            Id = new Guid("00000000-0000-0000-0000-000000000000"),
            Name = "My_Activity",
            Label = "My Activity",
            Version = "1",
            MinPaneWidth = 330,
            Terminal = TerminalData.TerminalDTO,
            NeedsAuthentication = true,
            Categories = new[]
            {
                ActivityCategories.Forward,
                TerminalData.ActivityCategoryDTO
            }
        };
        protected override ActivityTemplateDTO MyTemplate => ActivityTemplateDTO;

        public class ActivityUi : StandardConfigurationControlsCM
        {
            public TextSource Message { get; set; }

            public ActivityUi()
            {
                Message = new TextSource
                {
                    InitialLabel = "Message",
                    Label = "Message",
                    Name = nameof(Message),
                    Source = new FieldSourceDTO
                    {
                        ManifestType = CrateManifestTypes.StandardDesignTimeFields,
                        RequestUpstream = true
                    }
                };
                Controls = new List<ControlDefinitionDTO> { Message };
            }
        }

        public My_Activity_v1(ICrateManager crateManager)
            : base(crateManager)
        {
        }

        public override Task Initialize()
        {
            return Task.FromResult(0);
        }

        public override Task FollowUp()
        {
            return Task.FromResult(0);
        }

        protected override Task Validate()
        {
            return Task.FromResult(0);
        }

        public override Task Run()
        {
            return Task.FromResult(0);
        }
    }
}