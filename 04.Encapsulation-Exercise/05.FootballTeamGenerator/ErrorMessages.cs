﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class ErrorMessages
    {
        public const string NullOrWhitespaceName = "A name should not be empty.";
        public const string StatInvalidValue = "{0} should be between 0 and 100.";
        public const string PlayerNotInTeam = "Player {0} is not in {1} team.";
        public const string TeamNotExists = "Team {0} does not exist.";
    }
}
