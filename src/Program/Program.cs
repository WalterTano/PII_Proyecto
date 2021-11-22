using System;
using System.Collections.Generic;
using PII_E13.ClassLibrary;
using PII_E13.HandlerLibrary;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;

namespace Application
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        // INSTANCIAR COMO ALGÚN HANDLER.
        private static IHandler handler = new RegistrarEmprendedorHandler(null);

        // Reemplazar e incluir en handler por defecto.
        private static RespuestaTelegram respuestaPredeterminada = new RespuestaTelegram("Lo siento, parece que no puedo resolver esa consulta aún.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][] {
                    new InlineKeyboardButton[] {
                        "Buscar ofertas"
                        },
                        new InlineKeyboardButton[] {
                        "Consultar tus postulaciones"
                        }
                    }
                )
            );

        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            // DATOS DE PRUEBA -------------------------------------------------------------------------------------------
            Sistema.Instancia.Materiales.Add(new Material("Madera de roble", new List<string>() { "Madera", "Roble", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de abeto", new List<string>() { "Madera", "Abeto", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de pino", new List<string>() { "Madera", "Pino", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de cedro", new List<string>() { "Madera", "Cedro", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de arce", new List<string>() { "Madera", "Arce", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de haya", new List<string>() { "Madera", "Haya", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de nogal", new List<string>() { "Madera", "Nogal", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de cerezo", new List<string>() { "Madera", "Cerezo", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Madera de caoba", new List<string>() { "Madera", "Caoba", "Carpintería" }, "Kg"));
            Sistema.Instancia.Materiales.Add(new Material("Cobre", new List<string>() { "Metal", "Resistente", "Conductor" }, "Kg"));

           
            // DATOS DE PRUEBA -------------------------------------------------------------------------------------------

            //Obtengo una instancia de TelegramBot
            TelegramBot telegramBot = TelegramBot.Instancia;
            Console.WriteLine($"[BOT INICIADO] Nombre: {telegramBot.NombreBot} - Id: {telegramBot.IdBot}");

            //Obtengo el cliente de Telegram
            ITelegramBotClient bot = telegramBot.Cliente;

            //Asigno un gestor de mensajes
            bot.OnMessage += MensajeNuevo;

            bot.OnCallbackQuery += CallBackNuevo;

            //Inicio la escucha de mensajes
            bot.StartReceiving();

            Console.WriteLine("Presiona una tecla para terminar");
            Console.ReadKey();

            //Detengo la escucha de mensajes 
            bot.StopReceiving();
        }

        /// <summary>
        /// Manejador de evento de mensaje nuevo.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="messageEventArgs">Argumentos del evento.</param>
        private static async void MensajeNuevo(object sender, MessageEventArgs messageEventArgs)
        {
            IMensaje mensaje = new AdaptadorDeTelegram(messageEventArgs.Message);

            if (mensaje.Texto != null)
            {
                ITelegramBotClient client = TelegramBot.Instancia.Cliente;
                Console.WriteLine($"[NUEVO MENSAJE] - {mensaje.IdUsuario} envió: {mensaje.Texto}");

                RespuestaTelegram respuesta;

                IHandler resultado = handler.Resolver(mensaje, out respuesta);

                if (resultado == null)
                {
                    await client.SendTextMessageAsync(mensaje.IdUsuario, respuestaPredeterminada.Texto, replyMarkup: respuestaPredeterminada.TecladoTelegram, parseMode: ParseMode.Markdown);
                }
                else
                {
                    if (respuesta.TecladoTelegram != null)
                    {
                        await client.SendTextMessageAsync(mensaje.IdUsuario, respuesta.Texto, replyMarkup: respuesta.TecladoTelegram, parseMode: ParseMode.Markdown);

                    }
                    else
                    {
                        await client.SendTextMessageAsync(mensaje.IdUsuario, respuesta.Texto, replyMarkup: new ReplyKeyboardRemove(), parseMode: ParseMode.Markdown);
                    }
                }
            }
        }

        /// <summary>
        /// Manejador de evento de callback nuevo.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="callbackEventArgs">Argumentos del evento.</param>
        private static async void CallBackNuevo(object sender, CallbackQueryEventArgs callbackEventArgs)
        {
            ICallBack callback = new AdaptadorDeTelegram(callbackEventArgs.CallbackQuery);

            if (callback.Texto != null)
            {
                ITelegramBotClient client = TelegramBot.Instancia.Cliente;
                Console.WriteLine($"[NUEVO CALLBACK] - {callback.IdUsuario} envió: {callback.Texto}");

                RespuestaTelegram respuesta;

                IHandler resultado = handler.Resolver(callback, out respuesta);

                if (resultado == null)
                {
                    await client.SendTextMessageAsync(callback.IdUsuario, respuestaPredeterminada.Texto, replyMarkup: respuestaPredeterminada.TecladoTelegram, parseMode: ParseMode.Markdown);
                }
                else
                {
                    if (respuesta.EditarMensaje)
                    {
                        try
                        {
                            await client.EditMessageTextAsync(Int32.Parse(callback.IdChat), callback.IdMensaje, respuesta.Texto, replyMarkup: respuesta.TecladoTelegram, parseMode: ParseMode.Markdown);
                            return;
                        }
                        catch (Exception e)
                        {
                            return;
                        }
                    }

                    if (respuesta.TecladoTelegram != null)
                    {
                        if (respuesta.Texto.Equals(String.Empty))
                        {
                            try
                            {
                                await client.EditMessageReplyMarkupAsync(callback.IdChat, callback.IdMensaje, replyMarkup: respuesta.TecladoTelegram);
                            }
                            catch (MessageIsNotModifiedException)
                            {
                                /* No hay que hacer nada. */
                            }
                        }
                        else
                        {
                            await client.SendTextMessageAsync(callback.IdUsuario, respuesta.Texto, replyMarkup: respuesta.TecladoTelegram, parseMode: ParseMode.Markdown);
                        }
                    }
                    else
                    {
                        await client.SendTextMessageAsync(callback.IdUsuario, respuesta.Texto, replyMarkup: new ReplyKeyboardRemove(), parseMode: ParseMode.Markdown);
                    }
                }
            }
        }
    }
}