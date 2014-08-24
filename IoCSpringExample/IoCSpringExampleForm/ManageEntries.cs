using System;
using Entities.Contracts;
using ApplicationContext;

namespace IoCSpringExample
{
	public class ManageEntries
	{
		public ManageEntries ()
		{
			IDiaryEntry diaryEntrie = (IDiaryEntry) AppContext.Instance.GetObject("DiaryEntry");
		}

	}
}

