using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GiselleF_301215601.Models
{
	public class TweetManager
	{
		private static List<Tweet> tweets;
		private static string filename;

		static TweetManager()
		{
			tweets = new List<Tweet>();
			filename = "Assignment_02_TweetFile.txt";


			using (StreamReader reader = new StreamReader(filename))
			{

				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					Tweet tweet = Tweet.Parse(line);
					if (tweet != null)
						tweets.Add(tweet);

					Initialize();

				}

			}
		}


		public static void Initialize()
		{
			for (int i = 1; i == 0; i++) 

				tweets.Add(new Tweet($"From{i}", $"To{i}", $"Tweet{i}", $"{i}", $"Id{i}"));
		}

		public static void ShowAll()
		{
			foreach (Tweet tweet in tweets)
			{
				Console.WriteLine($"{tweet}\n");
			}
		}

		public static void ShowAll(string tag)
		{
			foreach (Tweet tweet in tweets)
			{
				 
			Console.WriteLine($"{tweet} #{tweet.Tag.ToLower()}\n");
			
			}
		}
	}
}
	



