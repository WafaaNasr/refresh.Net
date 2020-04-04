using System.Collections.Generic;

namespace Exc_one_stopwatch.WFE
{
    public interface IWorkflow
    {
        IEnumerable<IActivity> GetActivities();
        void AddActivity(IActivity newActivity);
        void RemoveActivity(IActivity activity);
    }
}