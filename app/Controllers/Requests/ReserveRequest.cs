using System.Globalization;

namespace Hotel.app.Controllers.Requests
{
    public class ReserveRequest
    {
        public string? HospedeId { get; set; }
        private string? _date;
        public string? Date
        {
            get => _date;
            set => SetDate(value!);
        }


        private void SetDate(string date)
        {
            try
            {
                _date = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            }
            catch (FormatException)
            {
                throw new InvalidDateException("Data inválida. O formato deve ser yyyy-MM-dd.");
            }
        }
    }
}
