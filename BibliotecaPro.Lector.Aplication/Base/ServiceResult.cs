

namespace BibliotecaPro.Lector.Aplication.Base
{
    public class ServiceResult
    {
        public string? Message { get; set; }
        public bool Success { get; set; }
        public dynamic? Result { get; set; }

        public ServiceResult() 
        {
            this.Success = true;
        }
    }
}
