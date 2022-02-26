using System;
using System.Collections.Generic;

namespace PrimusPong
{
    class Event
    {
        public static List<Event> Events = new List<Event>();

        private bool _isUnlocked;
        private System.Action _eventMethod;

        public bool IsUnlocked
        {
            get
            {
                return _isUnlocked;
            }
            set
            {
                _isUnlocked = value;
            }
        }
        public System.Action EventMethod
        {
            get
            {
                return _eventMethod;
            }
            set
            {
                _eventMethod = value;
            }

        }

        public Event(System.Action eventMethod)
        {
            _eventMethod = eventMethod;
            Events.Add(this);
        }
    }
}
