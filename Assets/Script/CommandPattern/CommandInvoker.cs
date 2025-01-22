using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker 
{
    public Queue<ICommand> commands = new Queue<ICommand>();

    public void ExecuteCommand()
    {
        if (commands.Count > 0)
        {
            ICommand command = commands.Peek();
            command.Execute();
        }
    }

    public void AddCommand(ICommand command)
    {
        commands.Enqueue(command);
        ExecuteCommand();
    }

    public void DecCommand()
    {
        if (commands.Count > 0)
            commands.Dequeue();
    }
}