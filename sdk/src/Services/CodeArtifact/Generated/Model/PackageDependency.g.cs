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
    /// Details about a package dependency.
    /// </summary>
    public partial class PackageDependency
    {
        /// <summary>
        /// Gets and sets the property DependencyType. 
        /// <para>
        ///  The type of a package dependency. The possible values depend on the package type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// npm: <c>regular</c>, <c>dev</c>, <c>peer</c>, <c>optional</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// maven: <c>optional</c>, <c>parent</c>, <c>compile</c>, <c>runtime</c>, <c>test</c>,
        /// <c>system</c>, <c>provided</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Note that <c>parent</c> is not a regular Maven dependency type; instead this is extracted
        /// from the <c>&lt;parent&gt;</c> element if one is defined in the package version's
        /// POM file.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// nuget: The <c>dependencyType</c> field is never set for NuGet packages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// pypi: <c>Requires-Dist</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DependencyType { get; set; }

        /// <summary>
        /// Checks to see if the DependencyType property is set.
        /// </summary>
        internal bool IsSetDependencyType() => this.DependencyType != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package that this package depends on. The package component that
        /// specifies its namespace depends on its type. For example:
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
        ///  The name of the package that this package depends on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;

        /// <summary>
        /// Gets and sets the property VersionRequirement. 
        /// <para>
        ///  The required version, or version range, of the package that this package depends
        /// on. The version format is specific to the package type. For example, the following
        /// are possible valid required versions: <c>1.2.3</c>, <c>^2.3.4</c>, or <c>4.x</c>.
        /// 
        /// </para>
        /// </summary>
        public string VersionRequirement { get; set; }

        /// <summary>
        /// Checks to see if the VersionRequirement property is set.
        /// </summary>
        internal bool IsSetVersionRequirement() => this.VersionRequirement != null;
    }
}
