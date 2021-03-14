// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.Testing.TestGenerators
{
    public class AddSimpleAttribute : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public virtual void Execute(GeneratorExecutionContext context)
        {
            context.AddSource("SimpleAttribute", "using System;[AttributeUsage(AttributeTargets.All)] internal sealed class SimpleAttribute : Attribute { }");
        }
    }
}
