using System;
using System.IO;

namespace tsonamu
{
	public class LogWriter
	{
		public string filename { get; set; }

		public LogWriter (string filename)
		{
			this.filename = filename;
		}


		public void LogText(string text, bool fileonly = false)
		{
			FileStream out_strm = new FileStream (this.filename, FileMode.Append);
			StreamWriter out_wrtr = new StreamWriter(out_strm);

			out_wrtr.WriteLine (text);

			if (fileonly == false) {
				Console.WriteLine (text);
			}


			out_wrtr.Close ();
			out_strm.Close ();
		}

	}
}

