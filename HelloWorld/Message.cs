using System;

namespace HelloWorld
{
    public class Message
    {
        private readonly IUser _user;
        private readonly int _morning;
        private readonly int _afternoon;
        private readonly int _night;
        private readonly ITime _time;

        public Message(int morning, int afternoon, int night)
            : this(morning, afternoon, night, new Time(), new User())
        {
        }

        internal Message(int morning, int afternoon, int night, ITime time, IUser user)
        {
            _morning = morning;
            _afternoon = afternoon;
            _night = night;
            _time = time;
            _user = user;
        }

        public string HelloMessage
        {
            get { return Response(); }
        }

        public IUser GetUser
        {
            get { return _user; }
        }

        public string Response()
        {
            int day = _time.GetDay();
            int hour = _time.GetHour();
            string name = _user.GetName();

            if (day > 0 && day < 6)
            {
                if (hour >= 0 && hour < _morning)
                {
                    return "Bonsoir " + name;
                }
                else if (hour >= _morning && hour < _afternoon)
                {
                    return "Bonjour " + name;
                }
                else if (hour >= _afternoon && hour < _night)
                {
                    return "Bon après-midi " + name;
                }
                else if (day < 5 && hour >= _night && hour < 24)
                {
                    return "Bonsoir " + name;
                }
                else if (hour >= _night && hour < 24)
                {
                    return "Bon week-end " + name;
                }
            }
            else
            {
                return "Bon week-end " + name;
            }

            return "error";
        }
    }
}