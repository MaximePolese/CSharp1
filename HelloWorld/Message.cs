using System;

namespace HelloWorld
{
    public class Message
    {
        private string _helloMessage;
        private readonly string _userName;
        private readonly int _day;
        private readonly int _hour;
        private readonly int _morning;
        private readonly int _afternoon;
        private readonly int _night;

        public Message(int morning, int afternoon, int night)
        {
            this._morning = morning;
            this._afternoon = afternoon;
            this._night = night;
            this._userName = Environment.UserName;
            this._day = (int)DateTime.Now.DayOfWeek;
            this._hour = DateTime.Now.Hour;
            this._helloMessage = Response();
        }

        public string HelloMessage
        {
            get { return _helloMessage; }
            set { _helloMessage = value; }
        }

        private string Response()
        {
            if (_day > 0 && _day < 6)
            {
                if (_hour >= 0 && _hour < _morning)
                {
                    return "Bonsoir " + _userName;
                }
                else if (_hour >= _morning && _hour < _afternoon)
                {
                    return "Bonjour " + _userName;
                }
                else if (_hour >= _afternoon && _hour < _night)
                {
                    return "Bon après-midi " + _userName;
                }
                else if (_day < 5 && _hour >= _night && _hour < 24)
                {
                    return "Bonsoir " + _userName;
                }
                else if (_hour >= _night && _hour < 24)
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