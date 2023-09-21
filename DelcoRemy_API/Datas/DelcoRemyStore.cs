using DelcoRemy_API.Models;
using DelcoRemy_API.Models.Dtos;

namespace DelcoRemy_API.Datas
{
    public static class DelcoRemyStore
    {
        public static List<reguladorDto> reguladorsList = new List<reguladorDto>()
        {
                 new reguladorDto{Id=1, Name="AR123", Manufacturer="Delco Remy"},
                 new reguladorDto{Id=2,Name="AR456", Manufacturer="Delco Remy"},
                 new reguladorDto{Id=3,Name="AR789", Manufacturer="Delco Remy"}
        };
    }
}