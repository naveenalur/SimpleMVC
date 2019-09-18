using Buiness.Infra.Command;
using Buiness.Infra.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SimpleCRUD.InfraStructure.IQS
{
    public class Mediator : IMediator
    {
        private readonly IContainer _container;

        public Mediator(IContainer container)
        {
            _container = container;
        }

        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlerType =
                typeof(ICommandHandler<>).MakeGenericType(command.GetType());

            dynamic handler = _container.GetInstance(handlerType);

            handler.Handle((dynamic)command);
        }

        public TResult Send<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));

            dynamic handler = _container.GetInstance(handlerType);

            return handler.Handle((dynamic)query);
        }
    }
}