using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Glossary.Model;
using Glossary.Web.Models;

namespace Glossary.Web.App_Start
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            Mapper.CreateMap<GlossaryTerm, GlossaryTermViewModel>();
            Mapper.CreateMap<GlossaryTermViewModel, GlossaryTerm>();
        }
    }
}