using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

using Newtonsoft.Json;

namespace the_Cryptocurrencies_bot_Movs
{
    public class API
    {
        static async Task Main(string[] args)
        {
            Mensaje m = new Mensaje();
            await m.CheckETHAsync();
            await m.CheckEWTAsync();
            await m.CheckHTAsync();
            await m.CheckIOTAAsync();
            await m.CheckKAIAsync();
            await m.CheckKARAsync();
            await m.CheckKCSAsync();
            await m.CheckKDAAsync();
            await m.CheckKSMAsync();
            await m.CheckLINKAsync();
            await m.CheckLTCAsync();
            await m.CheckLUNAAsync();
            await m.CheckMATICAsync();
            await m.CheckMIRAsync();
        }
    }
}