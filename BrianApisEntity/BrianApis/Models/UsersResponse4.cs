using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    public class UsersResponse4
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string tituloMeta { get; set; }
        public int años { get; set; }
        public double inversionInicial { get; set; }
        public double aporteMensual { get; set; }
        public double montoObjetivo { get; set; }
        public string entidadFinanciera { get; set; }
        public string portafolioTitle { get; set; }
        public string portafolioDes { get; set; }
        public string portafolioUuid { get; set; }
        public double portafolioMaxyear { get; set; }
        public double portafolioMinyear { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public string nivelRiesgo { get; set; }
        public bool isDefault { get; set; }
        public string investmentStrategyid { get; set; }
        public string version { get; set; }
        public string extraProfitabilityCurrencyCode { get; set; }
        public double estimatedProfitability{ get; set; }
        public double bpcomission { get; set; }
    }
}
