﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Collections.Generic;
using osu.Game.Rulesets.Catch.Judgements;
using osu.Game.Rulesets.Judgements;

namespace osu.Game.Rulesets.Catch.Objects
{
    public class Droplet : CatchHitObject
    {
        protected override IEnumerable<Judgement> CreateJudgements() => new[] { new CatchDropletJudgement() };
    }
}
