using Colorify;
using Colorify.UI;

namespace Datacenter.Server
{
    public class Logging
    {
        private Format _colorify;
        private string _logTag;

        public Logging(string logTag)
        {
            _colorify = new Format(Theme.Dark);
            _logTag = logTag;
        }

        private string PrettyPrint(Object obj)
        {
            string msg = "null";

            if (obj is Array)
            {
                msg = $"[{string.Join(", ", obj)}]";
            }
            else if (obj is List<string>)
            {
                msg = "\n[\n";

                List<string> list = ((List<string>)obj);

                for (int i = 0; i < list.Count; i++)
                {
                    if (i == list.Count - 1)
                        msg += $"    {list[i].ToString()}\n";
                    else
                        msg += $"    {list[i].ToString()},\n";
                }

                msg += "]\n";
            }
            else if (obj != null)
            {
                msg = obj.ToString()!;
            }

            return msg;
        }

        public void Info(Object obj)
        {
            _colorify.WriteLine($" [{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}] [{DateTime.UtcNow.ToString()}] [{_logTag}] {PrettyPrint(obj)}", Colors.bgInfo);
        }

        public void Warning(Object obj)
        {
            _colorify.WriteLine($" [{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}] [{DateTime.UtcNow.ToString()}] [{_logTag}] {PrettyPrint(obj)}", Colors.bgWarning);
        }

        public void Error(Object obj)
        {
            _colorify.WriteLine($" [{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}] [{DateTime.UtcNow.ToString()}] [{_logTag}] {PrettyPrint(obj)}", Colors.bgDanger);
        }

        public void Success(Object obj)
        {
            _colorify.WriteLine($" [{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}] [{DateTime.UtcNow.ToString()}] [{_logTag}] {PrettyPrint(obj)}", Colors.bgSuccess);
        }
    }
}
