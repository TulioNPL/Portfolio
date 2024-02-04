using Microsoft.AspNetCore.Components;
using Portfolio.Models;

namespace Portfolio.Pages {
    public partial class Educacao {
        public List<Curso> Cursos { get; set; }
        protected override void OnInitialized()
        {
            Cursos = new List<Curso>
            {
                new Curso { Instituicao = "Cisco", Nome = "Cybersecurity Essentials Online Course", Ano = "2021", Descricao = "Conceitos básicos de segurança de rede, criptografia e leis de segurança cibernética. Princípios de Confidencialidade, Integridade e Disponibilidade." },
                new Curso { Instituicao = "Cisco", Nome = "CCNA: Introduction to Networks", Ano = "2021", Descricao = "Conhecimento de rede, endereçamento IP e como os protocolos físicos de link de dados suportam Ethernet. Configuração de conectividade entre switches, roteadores e dispositivos finais utilizando Cisco Packet Tracer." },
                new Curso { Instituicao = "Cisco", Nome = "Network Security 1.0", Ano = "2021", Descricao = "Conhecimento de segurança de rede, mitigação de ameaças para proteger e sistemas de rede contra ataques. Configuração de proteção de dispositivos, firewalls, sistemas de prevenção de intrusão e redes privadas virtuais utilizando Cisco Packet Tracer." },
                new Curso { Instituicao = "Udemy", Nome = "Pentaho for ETL & Data Integration Masterclass 2023 - PDI 9", Ano = "2023", Descricao = "Extração, limpeza e integração de dados utilizando PDI. Conceitos de Data Marts e Data Warehouses. Diferentes tipos de transformação de dados" },
                new Curso { Instituicao = "Udemy", Nome = "Spark and Python for Big Data With Pyspark", Ano = "2023", Descricao = "Uso prático de pyspark para tratamento de dados, machine learning, streaming de dados e análise estatística." }
            };
        }
    }
}
