﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace webapi.healthclinic.codefirst.Domains
{
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique = true)]
    [Index(nameof(Endereco), IsUnique = true)] 
    [Index(nameof(RazaoSocial), IsUnique = true)]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome fantasia da clínica é obrigatório!")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Razão social da clínica é obrigatória!")]
        public string? RazaoSocial { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "CNPJ da clínica é obrigatório!")]
        [StringLength(14, ErrorMessage = "Confira os dígitos do CNPJ e os insira corretamente! (Apenas números)")]
        public string? CNPJ { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereço da clínica é obrigatório!")]
        public string? Endereco { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Obrigatório")]
        public TimeSpan? HoraInicio { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Obrigatório")]
        public TimeSpan? HoraFinal { get; set; }
    }
}
