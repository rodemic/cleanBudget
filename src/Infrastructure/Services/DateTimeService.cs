using cleanBudget.Application.Common.Interfaces;
using System;

namespace cleanBudget.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
