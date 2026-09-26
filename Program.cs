using System;
using System.Collections.Generic;
using SistemaNotificaciones.Models;

namespace SistemaNotificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista polimórfica que almacena distintas derivaciones de Notificacion
            List<Notificacion> listaNotificaciones = new List<Notificacion>
            {
                new CorreoElectronico("Su estado de cuenta está disponible.", "cliente@correo.com"),
                new Sms("Su código de verificación es: 482910", "+502 5555-1234"),
                new CorreoElectronico("Bienvenido a la plataforma.", "usuario@dominio.com")
            };

            Console.WriteLine("=== SISTEMA DE ENVÍO DE NOTIFICACIONES ===");
            Console.WriteLine();

            // Recorrido polimórfico
            foreach (Notificacion notificacion in listaNotificaciones)
            {
                notificacion.Enviar();
            }
        }
    }
}