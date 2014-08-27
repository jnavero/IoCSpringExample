using System;
using System.Collections.Generic;
using Entities.Contracts;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace IoCSpringExampleForm
{
    //La Kata no consiste en esto, así que no me centraré nada en esta clase y por no molestarme está static...
    //Realiza las operaciones de entrada o salida del diario (en un archivo)
    public static class IOEntries
    {
        const string FileName = "DataDiary.dat";

        //Serializa y guarda datos
        public static void SaveEntriesToDisk(List<IDiaryEntry> entries)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, entries);
            ms.Position = 0;
            var bytes = ms.ToArray();
            File.WriteAllBytes(FileName, bytes);                                            
            ms.Close();
        }

        //Deserializa y carga datos.
        public static List<IDiaryEntry> LoadEntriesFromDisk()
        {
            if (File.Exists(FileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream fileStream = new MemoryStream();
                fileStream = File.OpenRead(FileName);
                var obj = bf.Deserialize(fileStream);
                fileStream.Close();
                return (List<IDiaryEntry>)obj;
            }
           return null;
        }

    }
}

