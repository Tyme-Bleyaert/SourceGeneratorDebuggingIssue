using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace SourceGenerator
{
    [Generator]
    public class EnumSourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
#if DEBUG
            if (!Debugger.IsAttached)
            {
                Debugger.Launch();
            }
#endif
            //var enums = new List<EnumDeclarationSyntax>();
            //foreach (var syntaxTree in from syntaxTree in context.Compilation.SyntaxTrees
            //                           let semanticModel = context.Compilation.GetSemanticModel(syntaxTree)
            //                           select syntaxTree)
            //{
            //    enums.AddRange(syntaxTree.GetRoot().DescendantNodesAndSelf()
            //                    .OfType<EnumDeclarationSyntax>());
            //}
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }

    }
}

