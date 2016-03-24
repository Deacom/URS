using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{ 

    public class Project
    {
        public Project()
        {
            this.Activities = new HashSet<Activity>();
            this.Tags = new HashSet<Tag>();
        }


        #region Fields
        private int _id;
        private string _name;
        private DateTime _deadline;
        private string _comment;
        private ProjectType _projecttype;
        private Client _client;

        private ICollection<Activity> _activities;
        private ICollection<Tag> _tags;
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
        public virtual ProjectType ProjectType
                {
                    get
                    {
                        return _projecttype;
                    }

                    set
                    {
                        _projecttype = value;
                    }
                }
        public virtual Client Client
                {
                    get
                    {
                        return _client;
                    }

                    set
                    {
                        _client = value;
                    }
                }

        public virtual ICollection<Activity> Activities
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
        public virtual ICollection<Tag> Tags
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
