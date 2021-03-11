﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Testing.TestGenerators
{
    public class AddMultiLineCommentFile
        : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public virtual void Execute(GeneratorExecutionContext context)
        {
            context.AddSource("MultiLineCommentGeneratedFile", "\n// Comment1\n// Comment2");
        }
    }
}
