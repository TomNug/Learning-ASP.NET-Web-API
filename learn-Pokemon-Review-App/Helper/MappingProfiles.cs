﻿using AutoMapper;
using learn_Pokemon_Review_App.Dto;
using learn_Pokemon_Review_App.Models;

namespace learn_Pokemon_Review_App.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}