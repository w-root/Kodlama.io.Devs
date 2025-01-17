﻿using Application.Features.TechnologyFeature.Dtos;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TechnologyFeature.Models
{
    public class TechnologyListModel : BasePageableModel
    {
        public IList<TechnologyListDto> Items { get; set; }
    }
}
