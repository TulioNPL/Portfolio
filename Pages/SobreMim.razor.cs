using Microsoft.AspNetCore.Components;
using BlazorTypewriter;

namespace Portfolio.Pages
{
    public partial class SobreMim
    {
            TypewriterBuilder typewriter1 = new TypewriterBuilder(defaultCharacterPause: 50)
                .Pause(1700)
                .TypeString("Túlio Nunes Polido Lopes");

            TypewriterBuilder typewriter2 = new TypewriterBuilder(defaultCharacterPause: 50)
                .Pause(3200)
                .TypeString("20/10/1995");

            TypewriterBuilder typewriter3 = new TypewriterBuilder(defaultCharacterPause: 50)
                .Pause(3800)
                .TypeString("Belo Horizonte - Minas Gerais");

            TypewriterBuilder typewriter4 = new TypewriterBuilder(defaultCharacterPause: 50)
                .Pause(5500)
                .TypeString("tulionp.lopes@gmail.com");

            TypewriterBuilder typewriter5 = new TypewriterBuilder(defaultCharacterPause: 50)
                .Pause(7000)
                .TypeString("+55 (31) 9 9600 2103");

            TypewriterBuilder typewriter6 = new TypewriterBuilder(defaultCharacterPause: 50)
                .Pause(8500)
                .TypeString("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");

        protected override void OnInitialized()
        {
        }
    }
}