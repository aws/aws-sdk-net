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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A software package that's installed on an image, as detected by Amazon Web Services
    /// Systems Manager Inventory at build time. The list includes packages that shipped with
    /// the base image.
    /// </summary>
    public partial class ImagePackage
    {
        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the package that's reported to the operating system package manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The version of the package that's reported to the operating system package manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersion property is set.
        /// </summary>
        internal bool IsSetPackageVersion() => this.PackageVersion != null;
    }
}
