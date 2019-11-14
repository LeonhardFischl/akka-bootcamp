using System;
using System.Diagnostics.Eventing.Reader;
using Akka.Actor;
using WinTail.Messages;

namespace WinTail.Actors
{
    /// <summary>
    /// Actor responsible for serializing message writes to the console.
    /// (write one message at a time, champ :)
    /// </summary>
    class ConsoleWriterActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            if (message is InputError inputError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(inputError.Reason);
            }
            else if (message is InputSuccess inputSuccess)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(inputSuccess.Reason);
            }
            else
            {
                Console.WriteLine(message);
            }
            Console.ResetColor();
        }
    }
}
