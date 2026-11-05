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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about a software package installed on one or more of your resources.
    /// </summary>
    public partial class SoftwareResult
    {
        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the software package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of the software package, for example <c>operating-system</c>, <c>application</c>,
        /// or <c>library</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PackageType { get; set; }

        /// <summary>
        /// Checks to see if the PackageType property is set.
        /// </summary>
        internal bool IsSetPackageType() => this.PackageType != null;

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The version of the software package.
        /// </para>
        /// </summary>
        public string PackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersion property is set.
        /// </summary>
        internal bool IsSetPackageVersion() => this.PackageVersion != null;

        /// <summary>
        /// Gets and sets the property ResourceCount. 
        /// <para>
        /// The number of resources that contain this software package. To list these resources,
        /// call <c>GetSoftwareResourcesV2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCount property is set.
        /// </summary>
        internal bool IsSetResourceCount() => this.ResourceCount.HasValue;
    }
}
