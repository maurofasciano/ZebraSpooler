using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;

namespace ZebraSpoolerControllerFW
{
    public class LogEntry
    {
        /// <summary>
        /// Classe per la verifica presenza dell' errore nel registro. Se true, esegue il metodo di riavvio servizio Spooler
        /// </summary>

        public static void Logentry()
        {
            List<EventLogEntry> eventlist = new List<EventLogEntry>();

            EventLog myLog = new EventLog("System", "DAMAGE003");           

            EventLogEntryCollection myEventLogEntryCollection = myLog.Entries;

            foreach (EventLogEntry entry in myLog.Entries)
            {

                eventlist.Add(entry);

            }        
            
            string errore = "File di registro System cancellato.";

            int index = -1;


            for (int i = 0; i < eventlist.Count; i++)
            {

                if (eventlist[i].Message.Equals(errore))
             
                {
                    index = 0;
                }

            }


            if (index >= 0)
            {
                Console.WriteLine("trovato");
            }
            else
            {
                Console.WriteLine("NON trovato");
            }

            Console.ReadLine();
        }
    }

}


            

            
  