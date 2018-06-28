using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using BusinessLogic.Main_Workflows;

namespace BusinessLogic
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity workflow1 = new FlowchartNumberGuessWorkflow();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}
