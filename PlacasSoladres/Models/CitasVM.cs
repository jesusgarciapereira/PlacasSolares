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
        listaCita = getCitas();
    }
    #endregion
    #region Funciones
    public static ObservableCollection<Cita> getCitas(){

        ObservableCollection<Cita> lista = new ObservableCollection<Cita> {
            new Cita(1,"Juan Pérez", "Calle 1 #123", 5551234567),
            new Cita(2,"Ana López", "Avenida 2 #456", 5552345678),
            new Cita(3,"Carlos Ruiz", "Boulevard 3 #789", 5553456789),
            new Cita(4,"Lucía Gómez", "Calle 4 #101", 5554567890),
            new Cita(5,"Pedro Martínez", "Avenida 5 #202", 5555678901),
            new Cita(6,"Sofía Torres", "Boulevard 6 #303", 5556789012),
            new Cita(7,"Miguel Sánchez", "Calle 7 #404", 5557890123),
            new Cita(8,"Elena Fernández", "Avenida 8 #505", 5558901234),
            new Cita(9,"Raúl Herrera", "Boulevard 9 #606", 5559012345),
            new Cita(10,"Patricia Castro", "Calle 10 #707", 5550123456)
        };

        return lista;
    }
    #endregion
}
