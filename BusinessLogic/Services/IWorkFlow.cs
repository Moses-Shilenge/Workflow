using BusinessObject.DtoModels;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IWorkFlowApplication
    {
        void InvokeWorkFlow();
        void ResumeWorkFlow(Game game);
        Dictionary<string, object> ConfigureWorkflowApplication(WorkflowApplication wfApp);
        WorkflowApplicationInstance GetInstance(Guid guid);
    }
}
