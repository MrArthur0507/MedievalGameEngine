﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.EntityComponentSystem.Core.Entities.Contracts
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
