namespace Exc_one_stopwatch.WFE
{
    class WorkflowEngine
    {
        public void Run(IWorkflow  workflow){
          foreach( IActivity activity in workflow.GetActivities()){
              activity.Execute();
          }
        }
    }
}