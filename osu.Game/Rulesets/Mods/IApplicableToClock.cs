﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Timing;

namespace osu.Game.Rulesets.Mods
{
    /// <summary>
    /// An interface for mods that make adjustments to the track.
    /// </summary>
    public interface IApplicableToClock : IApplicableMod
    {
        void ApplyToClock(IAdjustableClock clock);
    }
}
