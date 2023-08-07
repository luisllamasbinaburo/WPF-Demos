namespace WpfApp2
{
    public class PersonaVM : ReactiveUI.ReactiveObject
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreYApellido => Nombre + " " + Apellido;

        public bool IsInvalid => string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido);

    }
}
