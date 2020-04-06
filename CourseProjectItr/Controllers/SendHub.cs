using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CourseProjectItr.Controllers
{
    public class SendHub : Hub
    {
        public async Task SendComment(string message, string userName, string itemID)
        {
            await Clients.All.SendAsync("SendComment", message, userName, itemID);
        }
        public async Task SendLike(int like)
        {
            await Clients.All.SendAsync("SendLike", like);
        }
    }
}
