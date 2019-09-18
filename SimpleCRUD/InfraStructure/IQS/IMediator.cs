using Buiness.Infra.Command;
using Buiness.Infra.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRUD.InfraStructure.IQS
{
    public interface IMediator
    {
        void Send<TCommand>(TCommand command) where TCommand : ICommand;

        TResult Send<TResult>(IQuery<TResult> query);
    }
}