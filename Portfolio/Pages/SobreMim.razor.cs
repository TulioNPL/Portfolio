using Microsoft.AspNetCore.Components;
using BlazorTypewriter;

namespace Portfolio.Pages
{
    public partial class SobreMim
    {
            TypewriterBuilder typewriter1 = new TypewriterBuilder(defaultCharacterPause: 30)
                .Pause(1700)
                .TypeString("Túlio Nunes Polido Lopes");

            TypewriterBuilder typewriter2 = new TypewriterBuilder(defaultCharacterPause: 30)
                .Pause(2700)
                .TypeString("20/10/1995");

            TypewriterBuilder typewriter3 = new TypewriterBuilder(defaultCharacterPause: 30)
                .Pause(3300)
                .TypeString("Belo Horizonte - Minas Gerais");

            TypewriterBuilder typewriter4 = new TypewriterBuilder(defaultCharacterPause: 30)
                .Pause(4700)
                .TypeString("tulionp.lopes@gmail.com");

            TypewriterBuilder typewriter5 = new TypewriterBuilder(defaultCharacterPause: 30)
                .Pause(5800)
                .TypeString("+55 (31) 9 9600 2103");

            TypewriterBuilder typewriter6 = new TypewriterBuilder(defaultCharacterPause: 10)
                .Pause(7000)
                .TypeString("Profissional altamente motivado e experiente em desenvolvimento de sistema e ciência de dados. Eficaz em solucionar desafios, contribuindo para o progresso de projetos e equipes. Proativo, amigável e compromissado. Torcedor do Clube Atlético Mineiro 🐓.");

        protected override void OnInitialized()
        {
        }
    }
}