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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Details about a package dependency.
    /// </summary>
    public partial class PackageDependency
    {
        private string _dependencyType;
        private string _awsNamespace;
        private string _package;
        private string _versionRequirement;

        /// <summary>
        /// Gets and sets the property DependencyType. 
        /// <para>
        ///  The type of a package dependency. The possible values depend on the package type.
        /// Example types are <code>compile</code>, <code>runtime</code>, and <code>test</code>
        /// for Maven packages, and <code>dev</code>, <code>prod</code>, and <code>optional</code>
        /// for npm packages. 
        /// </para>
        /// </summary>
        public string DependencyType
        {
            get { return this._dependencyType; }
            set { this._dependencyType = value; }
        }

        // Check to see if DependencyType property is set
        internal bool IsSetDependencyType()
        {
            return this._dependencyType != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package that this package depends on. The package component that
        /// specifies its namespace depends on its type. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package is its <code>groupId</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm package is its <code>scope</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Python and NuGet packages do not contain a corresponding component, packages of those
        /// formats do not have a namespace. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Package. 
        /// <para>
        ///  The name of the package that this package depends on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Package
        {
            get { return this._package; }
            set { this._package = value; }
        }

        // Check to see if Package property is set
        internal bool IsSetPackage()
        {
            return this._package != null;
        }

        /// <summary>
        /// Gets and sets the property VersionRequirement. 
        /// <para>
        ///  The required version, or version range, of the package that this package depends
        /// on. The version format is specific to the package type. For example, the following
        /// are possible valid required versions: <code>1.2.3</code>, <code>^2.3.4</code>, or
        /// <code>4.x</code>. 
        /// </para>
        /// </summary>
        public string VersionRequirement
        {
            get { return this._versionRequirement; }
            set { this._versionRequirement = value; }
        }

        // Check to see if VersionRequirement property is set
        internal bool IsSetVersionRequirement()
        {
            return this._versionRequirement != null;
        }

    }
}