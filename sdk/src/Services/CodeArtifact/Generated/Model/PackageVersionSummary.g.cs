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
    /// Details about a package version, including its status, version, and revision. The
    /// <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListPackageVersions.html">ListPackageVersions</a>
    /// operation returns a list of <c>PackageVersionSummary</c> objects.
    /// </summary>
    public partial class PackageVersionSummary
    {
        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionOrigin.html">PackageVersionOrigin</a>
        /// object that contains information about how the package version was added to the repository.
        /// </para>
        /// </summary>
        public PackageVersionOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        ///  The revision associated with a package version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  A string that contains the status of the package version. It can be one of the following:
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        ///  Information about a package version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
