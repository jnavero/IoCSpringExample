using System;

namespace Entities.Contracts
{
	/// <summary>
	/// Entradas del diario.
	/// </summary>
	public interface IDiaryEntry
	{

		int idEntry { get; set;}
		string nameEntry { get; set; }
		string Entry{ get; set;}
		DateTime date{ get; set;}
	}
}

