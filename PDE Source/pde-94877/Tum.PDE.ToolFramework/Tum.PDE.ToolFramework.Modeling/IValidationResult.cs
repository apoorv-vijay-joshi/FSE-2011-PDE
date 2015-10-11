﻿using System.Collections;
using System.Collections.Generic;

namespace Tum.PDE.ToolFramework.Modeling
{
    /// <summary>
    /// This interface describes a validation result, which is a collection of gathered validation messages.
    /// </summary>
    public interface IValidationResult : IEnumerable<IValidationMessage>, IEnumerable
    {
    }
}
