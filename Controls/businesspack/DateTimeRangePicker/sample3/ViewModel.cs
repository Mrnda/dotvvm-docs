using System;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.DateTimeRangePicker.sample3
{
    public class ViewModel
    {
        public DateTime StartDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
        public DateTime SelectedTime { get; set; } = DateTime.Now;
        public DateTime SelectedDateTime { get; set; } = DateTime.Now;
    }
}