namespace GameZone.ViewModels
{
    public class GameFormViewModel
    {
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;


        [Display(Name = "Category")]
        public int CategoryId { get; set; } // list w user hi5tar category wahda

        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();


        [Display(Name = "Supported Devices")]
        public List<int> SelectedDevices { get; set; } = default!; // list w user hi5tar kza device

        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();

        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;

    }
}
