﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWebApi.Application.DTO.DTO
{
    public class ClienteDTO
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }
    }
}
