using cleanBudget.Application.Common.Interfaces;
using System;

namespace cleanBudget.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
