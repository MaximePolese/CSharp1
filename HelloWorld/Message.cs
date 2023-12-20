using System;

namespace HelloWorld
{
    public class Message
    {
        private string _helloMessage;
        private int _day;
        private int _hour;
        private readonly int _morning;
        private readonly int _afternoon;
        private readonly int _night;

        public Message(int morning, int afternoon, int night)
        {
            this._morning = morning;
            this._afternoon = afternoon;
            this._night = night;
        }

        public string HelloMessage
        {
            get { return _helloMessage; }
            set { _helloMessage = GetMessage(value); }
        }

        private string GetMessage(string userName)
        {
            _day = (int)DateTime.Now.DayOfWeek;
            _hour = DateTime.Now.Hour;

            if (_day > 0 && _day < 6)
            {
                if (_hour >= 0 && _hour < _morning)
                {
                    return "Bonsoir " + userName;
                }
                else if (_hour >= _morning && _hour < _afternoon)
                {
                    return "Bonjour " + userName;
                }
                else if (_hour >= _afternoon && _hour < _night)
                {
                    return "Bon après-midi " + userName;
                }
                else if (_day < 5 && _hour >= _night && _hour < 24)
                {
                    return "Bonsoir " + userName;
                }
                else if (_hour >= _night && _hour < 24)
                {
                    return "Bon week-end " + userName;
                }
            }
            else
            {
                return "Bon week-end " + userName;
            }

            return "error";
        }
    }
}