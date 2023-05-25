using System;
using System.IO;
using System.Collections.Generic;


namespace lib_fileCounter
{
    public class FileCounter: IFilterCounter
    {
        // server per binding e Event Raise
        public string PathString { get; set; }

        public int Count
        {
            get
            {
                return Directory.GetFiles(PathString, "*", SearchOption.AllDirectories).Length;
            }
            set { Directory.Delete(PathString, true);
            }
        }
        //metodo per contare i file all'interno di una cartella
        /*public void countItemInPath(string folderPath, out int nr_filesTot, out int nr_foldersTot)
        {
            nr_filesTot = 0;
            nr_foldersTot = 0;

            try
            {
                //chiamo il metodo ricorsivo che va a contare gli elementi nelle sottocartelle e il numero di sottocartelle
                countItemRicorsivo(folderPath, out nr_filesTot, out nr_foldersTot);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore! Percorso non corretto " + ex.Message);
            }

            Console.WriteLine("Il numero di files totali e': ");
            Console.WriteLine("Sono presenti " + nr_foldersTot + "cartelle totali");
        }

        //metodo ricorsivo
        private void countItemRicorsivo(string folderPath, out int nr_filesTot, out int nr_foldersTot)
        {
            nr_filesTot = 0;
            nr_foldersTot = 0;

            string[] files = Directory.GetFiles(folderPath);//chiedere a stefano
            nr_filesTot += files.Length;

            string[] subdirectories = Directory.GetDirectories(folderPath);
            foreach (string subdirectory in subdirectories)
            {
                int subfolderFiles;
                int subfolderFolders;

                countItemRicorsivo(subdirectory, out subfolderFiles, out subfolderFolders);

                nr_filesTot += subfolderFiles;
                nr_foldersTot += subfolderFolders + 1;
                Console.WriteLine("Sottocartelle: " + subdirectory);
                Console.WriteLine("Files: " + subfolderFiles);
                Console.WriteLine("Cartelle: " + (subfolderFolders + 1));
                Console.WriteLine();
                
            }
        } */
    }
}
