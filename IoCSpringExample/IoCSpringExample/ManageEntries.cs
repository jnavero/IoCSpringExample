using System;
using Entities.Contracts;
using ApplicationContext;

namespace IoCSpringExample
{
	public class ManageEntries
	{
		public LoadEntries ()
		{
			IDiaryEntry diaryEntrie = (IDiaryEntry) AppContext.Instance.GetObject("DiaryEntry");
		}

	}
}

