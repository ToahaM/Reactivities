using System.Security.AccessControl;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        

        [HttpGet] //api/activities

        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/activities/fdfdfdfdf
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity)    // access to HttpResponse Type 
        {
            await Mediator.Send(new Create.Command {Activity = activity});
            return Ok();
        }

         [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id, Activity activity)    // access to HttpResponse Type 
        {
            activity.Id = id;
            
            await Mediator.Send(new Edit.Command {Activity = activity});
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)    // access to HttpResponse Type 
        {        
            await Mediator.Send(new Delete.Command{Id = id});
            return Ok();
        }

    }
}