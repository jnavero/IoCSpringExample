using System;
using Entities.Contracts;
using ApplicationContext;

namespace IoCSpringExample
{
	public class LoadEntries
	{
		public LoadEntries ()
		{

			IDiaryEntry diaryEntrie = (IDiaryEntry) AppContext.Instance.GetObject("DiaryEntry");




		}
	}
}

