using MediatR;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.Events
{
    /// <summary>
    /// Event used when an order is created
    /// </summary>
    public class OrderStartedDomainEvent
        : INotification
    {
        public string UserId { get; private set; }
        public int CardTypeId { get; private set; }
        public string CardNumber { get; private set; }
        public string CardSecurityNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public DateTime CardExpiration { get; private set; }
        public Order Order { get; private set; }

        public OrderStartedDomainEvent(Order order, string userId,
            int cardTypeId, string cardNumber, 
            string cardSecurityNumber, string cardHolderName, 
            DateTime cardExpiration)
        {
            Order = order;
            UserId = userId;
            CardTypeId = cardTypeId;
            CardNumber = cardNumber;
            CardSecurityNumber = cardSecurityNumber;
            CardHolderName = cardHolderName;
            CardExpiration = cardExpiration;
        }
    }
}
