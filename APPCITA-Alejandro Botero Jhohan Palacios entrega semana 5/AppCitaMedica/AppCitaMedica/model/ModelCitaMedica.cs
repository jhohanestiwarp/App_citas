using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCitaMedica.model
{
    internal class ModelCitaMedica
    {
        private string nombre;
        private string id;
        private string especialidad;
        private DateTime agendamiento;
        private string medico;


        //implementacion de getters setters para cada atributo
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setEspecialidad(string especialidad)
        {
            this.especialidad = especialidad;
        }
        public void setAgendamiento(DateTime agendamiento)
        {
            this.agendamiento = agendamiento;
        }
        public void setMedico(string medico)
        {
            this.medico = medico;
        }

        public string getNombre()
        {
            return nombre;
        }
        public string getId()
        {
            return id;
        }
        public string getEspecialidad()
        {
            return especialidad;
        }
        public DateTime getAgendamiento()
        {
            return agendamiento;
        }
        public string getMedico()
        {
            return medico;
        }
    }
}
