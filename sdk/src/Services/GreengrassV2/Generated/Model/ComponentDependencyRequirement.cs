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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a component dependency for a Lambda function component.
    /// </summary>
    public partial class ComponentDependencyRequirement
    {
        private ComponentDependencyType _dependencyType;
        private string _versionRequirement;

        /// <summary>
        /// Gets and sets the property DependencyType. 
        /// <para>
        /// The type of this dependency. Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SOFT</c> – The component doesn't restart if the dependency changes state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HARD</c> – The component restarts if the dependency changes state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>HARD</c> 
        /// </para>
        /// </summary>
        public ComponentDependencyType DependencyType
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
        /// Gets and sets the property VersionRequirement. 
        /// <para>
        /// The component version requirement for the component dependency.
        /// </para>
        ///  
        /// <para>
        /// IoT Greengrass V2 uses semantic version constraints. For more information, see <a
        /// href="https://semver.org/">Semantic Versioning</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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