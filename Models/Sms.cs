using System;

namespace SistemaNotificaciones.Models
{
    // Clase Derivada que hereda de Notificacion
    public class Sms : Notificacion
    {
        public string NumeroTelefono { get; set; }

        public Sms(string mensaje, string numeroTelefono) 
            : base(mensaje)
        {
            NumeroTelefono = numeroTelefono;
        }

        // Sobrescribe el método Enviar()
        public override void Enviar()
        {
            Console.WriteLine($"[SMS] Enviado a ({NumeroTelefono}): \"{Mensaje}\"");
        }
    }
}