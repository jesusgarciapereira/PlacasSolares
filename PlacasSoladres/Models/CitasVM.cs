using Citas;
using PlacasSoladres.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
namespace PlacasSoladres.Models;

public class CitasVM
{
    #region Atributos
    public ObservableCollection<Cita> listaCita { get; set; }
    #endregion

    #region Constructor
    public CitasVM(){
        listaCita = obtenerCitas();
    }
    #endregion

    #region Funcion
    public static ObservableCollection<Cita> obtenerCitas()
    {
        ObservableCollection<Cita> lista = new ObservableCollection<Cita>
    {
        new Cita(1, "Marcos Hernández", "Calle Magnolia #10", 9912345678),
        new Cita(2, "Laura Vega", "Avenida Sol #22", 9923456789),
        new Cita(3, "Javier Álvarez", "Boulevard Luna #35", 9934567890),
        new Cita(4, "Carmen Ortiz", "Calle Olivo #48", 9945678901),
        new Cita(5, "Diego Ramos", "Avenida Estrella #53", 9956789012),
        new Cita(6, "Valeria Silva", "Boulevard Mar #67", 9967890123),
        new Cita(7, "Ricardo Gutiérrez", "Calle Jardín #74", 9978901234),
        new Cita(8, "Adriana López", "Avenida Rio #89", 9989012345),
        new Cita(9, "Luis Navarro", "Boulevard Sol #96", 9990123456),
        new Cita(10, "Marta Castro", "Calle Palmeras #105", 9901234567)
    };

        return lista;
    }

    #endregion
}
