using System;

namespace SistemaNotificaciones.Models
{
    // Clase Derivada que hereda de Notificacion
    public class CorreoElectronico : Notificacion
    {
        public string DireccionCorreo { get; set; }

        public CorreoElectronico(string mensaje, string direccionCorreo) 
            : base(mensaje)
        {
            DireccionCorreo = direccionCorreo;
        }

        // Sobrescribe el método Enviar()
        public override void Enviar()
        {
            Console.WriteLine($"[CORREO ELECTRÓNICO] Enviado a <{DireccionCorreo}>: \"{Mensaje}\"");
        }
    }
}