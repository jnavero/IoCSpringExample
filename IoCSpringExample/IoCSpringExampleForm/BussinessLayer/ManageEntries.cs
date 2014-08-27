using System;
using Entities.Contracts;
using ApplicationContext;
using System.Collections.Generic;
using System.Linq;

namespace IoCSpringExampleForm.BussinessLayer
{
    //Realiza las operaciones necesarias para insertar o retornar entradas del diario.
	public class ManageEntries
	{
        List<IDiaryEntry> _diaryEntries;

		public ManageEntries ()
		{
            _diaryEntries = IOEntries.LoadEntriesFromDisk();
            if (_diaryEntries == null)
                _diaryEntries = new List<IDiaryEntry>();
 		}

        public IEnumerable<IDiaryEntry> GetEntries
        {
            get 
            {
                return _diaryEntries;
            }
        }

        private void addEntry(IDiaryEntry Entry)
        {
            _diaryEntries.Add(Entry);
            IOEntries.SaveEntriesToDisk(_diaryEntries); // lo suyo es no poner esto aqui pero, el ejemplo del guardado/carga de datos da igual
        }

        public void addEntry(string NameEntry, string EntryDescription, DateTime date)
        {
            IDiaryEntry diaryEntry = (IDiaryEntry)AppContext.Instance.GetObject("DiaryEntry");

            diaryEntry.date = date;
            diaryEntry.Entry = EntryDescription;
            diaryEntry.nameEntry = NameEntry;
            diaryEntry.idEntry = Guid.NewGuid();
            addEntry(diaryEntry);
        }

        public IEnumerable<IDiaryEntry> GetEntriesSelectedMonth(DateTime date)
        {
            return GetEntries.Where(x => x.date.Month.CompareTo(date.Month) == 0).ToList();
        }

	}
}

