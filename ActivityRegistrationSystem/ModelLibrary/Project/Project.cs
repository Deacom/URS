using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Project
{
    public class Project
    {
        #region Fields
        private int _id;
        private string _name;
        private DateTime _deadline;
        private string _comment;

        private IEnumerable<Activity> _activities;
        private IEnumerable<Tag> _tags;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public DateTime Deadline
        {
            get
            {
                return _deadline;
            }

            set
            {
                _deadline = value;
            }
        }

        public string Comment
        {
            get
            {
                return _comment;
            }

            set
            {
                _comment = value;
            }
        }

        public IEnumerable<Activity> Activities
        {
            get
            {
                return _activities;
            }

            set
            {
                _activities = value;
            }
        }

        public IEnumerable<Tag> Tags
        {
            get
            {
                return _tags;
            }

            set
            {
                _tags = value;
            }
        }
        #endregion
    }
}
