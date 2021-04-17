using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System.Reflection;

namespace DiscordBotDM
{
    public class CommandHandler
    {
        private readonly DiscordSocketClient _client;
        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();
        }          
        public async Task GetUser1()
        {
           var guild = _client.GetGuild(829222916808769558);
           var member = guild.GetUsersAsync();
           var user = _client.GetUser(514897909804957736);
           await user.SendMessageAsync("Olá");
        }    
    }
}
