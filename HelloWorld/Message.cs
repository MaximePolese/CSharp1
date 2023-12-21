using System;

namespace HelloWorld
{
    public class Message
    {
        private readonly string _userName;
        private readonly int _morning;
        private readonly int _afternoon;
        private readonly int _night;
        private readonly ITime _time;

        public Message(int morning, int afternoon, int night)
            : this(morning, afternoon, night, new Time())
        {
        }
        internal Message(int morning, int afternoon, int night, ITime time)
        {
            _userName = Environment.UserName;
            _morning = morning;
            _afternoon = afternoon;
            _night = night;
            _time = time;
        }
        
        public string HelloMessage
        {
            get { return Response(); }
        }

        public string Response()
        {
            int day = _time.GetDay();
            int hour = _time.GetHour();
            
            if (day > 0 && day < 6)
            {
                if (hour >= 0 && hour < _morning)
                {
                    return "Bonsoir " + _userName;
                }
                else if (hour >= _morning && hour < _afternoon)
                {
                    return "Bonjour " + _userName;
                }
                else if (hour >= _afternoon && hour < _night)
                {
                    return "Bon après-midi " + _userName;
                }
                else if (day < 5 && hour >= _night && hour < 24)
                {
                    return "Bonsoir " + _userName;
                }
                else if (hour >= _night && hour < 24)
                {
                    return "Bon week-end " + _userName;
                }
            }
            else
            {
                return "Bon week-end " + _userName;
            }

            return "error";
        }
    }
}