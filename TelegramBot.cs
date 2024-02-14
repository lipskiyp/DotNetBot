using Telegram.Bot;
using Telegram.Bot.Types;


namespace DotNetBot.TelegramBot;

public static class Globals
{
    public static string TELEGRAM_TOKEN = "6037639903:AAH3QdDlW3i5ybuTQhkw_yN1-fyRyjvxzbc";
}


public class TelegramBot
{
    private static TelegramBotClient? botClient;

    private static void Main(string[] args)
    {
        CancellationTokenSource cts = new();
        botClient = new TelegramBotClient(Globals.TELEGRAM_TOKEN);  // new bot client instance
        botClient.StartReceiving(UpdateHandler, ErrorHandler);
        Console.WriteLine("Bot started successfully.");
    }

    #pragma warning disable 8602
    public static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken token)
    {
        string responseMessage = "Hello";
        await bot.SendTextMessageAsync(update.Message.Chat.Id, responseMessage);
    }

    #pragma warning disable 1998
    public static async Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken token)
    {
        Console.WriteLine("Error.");
    }


}