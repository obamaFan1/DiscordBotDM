using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;



namespace DiscordBotDM
{
    public class Program
    {
         static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandHandler _handler;

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            new CommandHandler(_client);

            // var token = File.ReadAllText("token.txt");
            var token = "";
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            await Task.Delay(-1);
        }
        public async Task DmUser()
        {
            _handler = new CommandHandler(_client);
            await _handler.DmUSer();
        }
    }
}
