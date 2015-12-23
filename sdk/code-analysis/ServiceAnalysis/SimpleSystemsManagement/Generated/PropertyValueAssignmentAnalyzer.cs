using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

using Amazon.CodeAnalysis.Shared;

namespace Amazon.SimpleSystemsManagement.CodeAnalysis
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PropertyValueAssignmentAnalyzer : AbstractPropertyValueAssignmentAnalyzer
    {
        public override string GetServiceName()
        {
            return "SimpleSystemsManagement";
        }
    }
}