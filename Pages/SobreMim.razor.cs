using Microsoft.AspNetCore.Components;

namespace Portfolio.Pages{
    public partial class SobreMim
    {
        public string Name { get; set; } = "pessoal";

        protected override void OnInitialized()
        {
            Name = "gente";
        }
    }
}