// Partially adapted from:
//      https://raw.githubusercontent.com/dotnet/runtime/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/DynamicallyAccessedMemberTypes.cs
//      https://raw.githubusercontent.com/dotnet/runtime/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/DynamicallyAccessedMembersAttribute.cs
//      https://raw.githubusercontent.com/dotnet/runtime/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/UnconditionalSuppressMessageAttribute.cs
//      https://raw.githubusercontent.com/dotnet/runtime/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/RequiresUnreferencedCodeAttribute.cs
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if !NET8_0_OR_GREATER
using System;

namespace ThirdParty.RuntimeBackports
{
    [Flags]
#pragma warning disable CA2217 // Do not mark enums with FlagsAttribute
    public enum DynamicallyAccessedMemberTypes
#pragma warning restore CA2217 // Do not mark enums with FlagsAttribute
    {
        All = -1,
        None = 0,
        PublicParameterlessConstructor = 1,
        PublicConstructors = 3,
        NonPublicConstructors = 4,
        PublicMethods = 8,
        NonPublicMethods = 16,
        PublicFields = 32,
        NonPublicFields = 64,
        PublicNestedTypes = 128,
        NonPublicNestedTypes = 256,
        PublicProperties = 512,
        NonPublicProperties = 1024,
        PublicEvents = 2048,
        NonPublicEvents = 4096,
        Interfaces = 8192
    }

    [AttributeUsage(
        AttributeTargets.Field | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter |
        AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Method |
        AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct,
        Inherited = false)]

    public sealed class DynamicallyAccessedMembersAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicallyAccessedMembersAttribute"/> class
        /// with the specified member types.
        /// </summary>
        /// <param name="memberTypes">The types of members dynamically accessed.</param>
        public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes)
        {
            MemberTypes = memberTypes;
        }

        /// <summary>
        /// Gets the <see cref="DynamicallyAccessedMemberTypes"/> which specifies the type
        /// of members dynamically accessed.
        /// </summary>
        public DynamicallyAccessedMemberTypes MemberTypes { get; }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class UnconditionalSuppressMessageAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnconditionalSuppressMessageAttribute"/>
        /// class, specifying the category of the tool and the identifier for an analysis rule.
        /// </summary>
        /// <param name="category">The category for the attribute.</param>
        /// <param name="checkId">The identifier of the analysis rule the attribute applies to.</param>
        public UnconditionalSuppressMessageAttribute(string category, string checkId)
        {
            Category = category;
            CheckId = checkId;
        }

        /// <summary>
        /// Gets the category identifying the classification of the attribute.
        /// </summary>
        /// <remarks>
        /// The <see cref="Category"/> property describes the tool or tool analysis category
        /// for which a message suppression attribute applies.
        /// </remarks>
        public string Category { get; }

        /// <summary>
        /// Gets the identifier of the analysis tool rule to be suppressed.
        /// </summary>
        /// <remarks>
        /// Concatenated together, the <see cref="Category"/> and <see cref="CheckId"/>
        /// properties form a unique check identifier.
        /// </remarks>
        public string CheckId { get; }

        /// <summary>
        /// Gets or sets the scope of the code that is relevant for the attribute.
        /// </summary>
        /// <remarks>
        /// The Scope property is an optional argument that specifies the metadata scope for which
        /// the attribute is relevant.
        /// </remarks>
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets a fully qualified path that represents the target of the attribute.
        /// </summary>
        /// <remarks>
        /// The <see cref="Target"/> property is an optional argument identifying the analysis target
        /// of the attribute. An example value is "System.IO.Stream.ctor():System.Void".
        /// Because it is fully qualified, it can be long, particularly for targets such as parameters.
        /// The analysis tool user interface should be capable of automatically formatting the parameter.
        /// </remarks>
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets an optional argument expanding on exclusion criteria.
        /// </summary>
        /// <remarks>
        /// The <see cref="MessageId "/> property is an optional argument that specifies additional
        /// exclusion where the literal metadata target is not sufficiently precise. For example,
        /// the <see cref="UnconditionalSuppressMessageAttribute"/> cannot be applied within a method,
        /// and it may be desirable to suppress a violation against a statement in the method that will
        /// give a rule violation, but not against all statements in the method.
        /// </remarks>
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the justification for suppressing the code analysis message.
        /// </summary>
        public string Justification { get; set; }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Class, Inherited = false)]
    public sealed class RequiresUnreferencedCodeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiresUnreferencedCodeAttribute"/> class
        /// with the specified message.
        /// </summary>
        /// <param name="message">
        /// A message that contains information about the usage of unreferenced code.
        /// </param>
        public RequiresUnreferencedCodeAttribute(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Gets a message that contains information about the usage of unreferenced code.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets or sets an optional URL that contains more information about the method,
        /// why it requries unreferenced code, and what options a consumer has to deal with it.
        /// </summary>
        public string Url { get; set; }
    }
}
#endif