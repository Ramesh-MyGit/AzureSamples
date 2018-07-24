using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contoso.Events.Models;

namespace Contoso.Events.Data
{
    public class EventsContextInitializer: CreateDatabaseIfNotExists<EventsContext>
    {
        protected override void Seed(EventsContext context)
        {
            if (context.Events.Count() == 0) {
                Event eventItem = new Event();
                eventItem.EventKey = "FY17SepGeneralConference";
                eventItem.StartTime = DateTime.Today;
                eventItem.EndTime = DateTime.Today.AddDays(3d);
                eventItem.Title = "FY17 September Technical Conference";
                eventItem.Description = "Sed in euismod mi.";
                eventItem.RegistrationCount = 1;
                context.Events.Add(eventItem);
            }
            if (context.Registrations.Count() == 0) {
                Registration registrationItem = new Registration();
                registrationItem.EventKey = "FY17SepGeneralConference";
                registrationItem.FirstName = "Aisha";
                registrationItem.LastName = "Witt";
                context.Registrations.Add(registrationItem);
            }
            context.SaveChanges();
        }
    }
}
