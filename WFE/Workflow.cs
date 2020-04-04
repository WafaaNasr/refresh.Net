using System;
using System.Collections.Generic;

namespace Exc_one_stopwatch.WFE
{

    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;
     
        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void AddActivity(IActivity newActivity)
        {
            if (newActivity == null) throw new ArgumentNullException("Activity can't be null");
            _activities.Add(newActivity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
          return _activities;
        }

        public void RemoveActivity(IActivity activity)
        {
          _activities.Remove(activity);
        }
    }
}