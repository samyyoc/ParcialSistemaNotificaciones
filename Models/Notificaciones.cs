using System;

namespace SistemaNotificaciones.Models
{
    // Clase Base
    public class Notificacion
    {
        public string Mensaje { get; set; }

        public Notificacion(string mensaje)
        {
            Mensaje = mensaje;
        }

        // Método virtual para permitir Polimorfismo
        public virtual void Enviar()
        {
            Console.WriteLine($"Enviando notificación general: {Mensaje}");
        }
    }
}