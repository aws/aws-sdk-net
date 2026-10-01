/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// A package associated with a package group.
    /// </summary>
    public partial class AssociatedPackage
    {
        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// Describes the strength of the association between the package and package group. A
        /// strong match can be thought of as an exact match, and a weak match can be thought
        /// of as a variation match, for example, the package name matches a variation of the
        /// package group pattern. For more information about package group pattern matching,
        /// including strong and weak matches, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
        /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        public PackageGroupAssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// A format that specifies the type of the associated package.
        /// </para>
        /// </summary>
        public PackageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the associated package. The package component that specifies its
        /// namespace depends on its type. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package version is its <c>groupId</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm or Swift package version is its <c>scope</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The namespace of a generic package is its <c>namespace</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Python, NuGet, Ruby, and Cargo package versions do not contain a corresponding component,
        /// package versions of those formats do not have a namespace. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Package. 
        /// <para>
        ///  The name of the associated package. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;
    }
}
