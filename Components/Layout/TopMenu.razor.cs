using BlazorTypewriter;

namespace Portfolio.Components.Layout {
    public partial class TopMenu {
        TypewriterBuilder typewriter1 = new TypewriterBuilder(defaultCharacterPause: 50)
            .TypeString("Sobre mim");
        TypewriterBuilder typewriter2 = new TypewriterBuilder(defaultCharacterPause: 50)
            .Pause(600)
            .TypeString("Educação");
        TypewriterBuilder typewriter3 = new TypewriterBuilder(defaultCharacterPause: 50)
            .Pause(1000)
            .TypeString("Profissional");
            
        protected override void OnInitialized()
        {
        }
    }
}
