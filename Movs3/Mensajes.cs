using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

public class Mensaje
{
    public async Task CheckETHAsync()
    {
        ConeccionAPIETH CRYPTO = new ConeccionAPIETH();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckEWTAsync()
    {
        ConeccionAPIEWT CRYPTO = new ConeccionAPIEWT();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckHTAsync()
    {
        ConeccionAPIHT CRYPTO = new ConeccionAPIHT();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckIOTAAsync()
    {
        ConeccionAPIIOTA CRYPTO = new ConeccionAPIIOTA();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckKAIAsync()
    {
        ConeccionAPIKAI CRYPTO = new ConeccionAPIKAI();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckKARAsync()
    {
        ConeccionAPIKAR CRYPTO = new ConeccionAPIKAR();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckKCSAsync()
    {
        ConeccionAPIKCS CRYPTO = new ConeccionAPIKCS();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckKDAAsync()
    {
        ConeccionAPIKDA CRYPTO = new ConeccionAPIKDA();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckKSMAsync()
    {
        ConeccionAPIKSM CRYPTO = new ConeccionAPIKSM();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckLINKAsync()
    {
        ConeccionAPILINK CRYPTO = new ConeccionAPILINK();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckLTCAsync()
    {
        ConeccionAPILTC CRYPTO = new ConeccionAPILTC();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckLUNAAsync()
    {
        ConeccionAPILUNA CRYPTO = new ConeccionAPILUNA();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckMATICAsync()
    {
        ConeccionAPIMATIC CRYPTO = new ConeccionAPIMATIC();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckMIRAsync()
    {
        ConeccionAPIMIR CRYPTO = new ConeccionAPIMIR();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    static async Task SendMessage10PAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Buen movimiento : )\n" +
            $"{Sysmbol} se ha movido {ChangeRate}%\n" +
            $"En las ultimas 24h, terminando con un precio de {Price}\n" +
            $"Teniendo un Low de {Low} y un High de {High}");
    }

    static async Task SendMessage10NAsync(string chatID, string Sysmbol,
            string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Se pone interesante esto ; )\n" +
            $"{Sysmbol} se ha movido {ChangeRate}%\n" +
            $"En las ultimas 24h, terminando con un precio de {Price}\n" +
            $"Teniendo un Low de {Low} y un High de {High}");
    }

    static async Task SendMessage20PAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Y nos fuimos pa arriba ^_^\n" +
            $"{Sysmbol} se ha movido {ChangeRate}%\n" +
            $"En las ultimas 24h, terminando con un precio de {Price}\n" +
            $"Teniendo un Low de {Low} y un High de {High}");
    }

    static async Task SendMessage20NAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Las oportunidades llegando\n" +
            $"{Sysmbol} se ha movido {ChangeRate}%\n" +
            $"En las ultimas 24h, terminando con un precio de {Price}\n" +
            $"Teniendo un Low de {Low} y un High de {High}");
    }

    static async Task SendMessage30PAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"To the moon\n" +
            $"{Sysmbol} se ha movido {ChangeRate}%\n" +
            $"En las ultimas 24h, terminando con un precio de {Price}\n" +
            $"Teniendo un Low de {Low} y un High de {High}");
    }

    static async Task SendMessage30NAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Muevete que nos fuimos hasta abajo\n" +
            $"{Sysmbol} se ha movido {ChangeRate}%\n" +
            $"En las ultimas 24h, terminando con un precio de {Price}\n" +
            $"Teniendo un Low de {Low} y un High de {High}");
    }
}