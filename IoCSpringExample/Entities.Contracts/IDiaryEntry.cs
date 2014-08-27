using System;
using System.Runtime.Serialization;

namespace Entities.Contracts
{
	/// <summary>
	/// Entradas del diario.
	/// </summary>
    public interface IDiaryEntry
	{
        Guid idEntry { get; set;}
		string nameEntry { get; set; }
		string Entry{ get; set;}
		DateTime date{ get; set;}
	}
}

