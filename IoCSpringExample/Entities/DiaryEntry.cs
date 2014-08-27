using System;
using Entities.Contracts;

namespace Entities
{
	/// <summary>
	/// Representa una entrada del diario.
	/// </summary>
    [Serializable()]
	public class DiaryEntry : IDiaryEntry
	{
		public DiaryEntry ()
		{
		}

        private Guid _identry;
        public Guid idEntry 
		{ 
			get 
			{
				return _identry;
			}
			set
			{
				_identry = value;
			}
		}

		private string _nameEntry = string.Empty;
		public string nameEntry { 
			get {
				return _nameEntry;
			}
			set
			{
				_nameEntry = value;
			}
		}
		private string _entry = string.Empty;
		public string Entry{ 
			get{
				return _entry;
			}
			set{
				_entry = value;
			}
		}
		private DateTime _date{ get; set;}
		public DateTime date{ 
			get{
				return _date;
			}
			set
			{
				_date = value;

			}

		}

		public override string ToString ()
		{
			return string.Format ("[DiaryEntry: idEntry={0}, nameEntry={1}, date={2}, Entry={3}]", idEntry, nameEntry, date, Entry);
		}

	}
}

