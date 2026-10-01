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
    /// This is the response object from the PublishPackageVersion operation.
    /// </summary>
    public partial class PublishPackageVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Asset. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_AssetSummary.html">AssetSummary</a>
        /// for the published asset.
        /// </para>
        /// </summary>
        public AssetSummary Asset { get; set; }

        /// <summary>
        /// Checks to see if the Asset property is set.
        /// </summary>
        internal bool IsSetAsset() => this.Asset != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the package version.
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
        /// The namespace of the package version.
        /// </para>
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
        /// The name of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A string that contains the status of the package version. For more information, see
        /// <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status.html#package-version-status">Package
        /// version status</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        public PackageVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property VersionRevision. 
        /// <para>
        /// The revision of the package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string VersionRevision { get; set; }

        /// <summary>
        /// Checks to see if the VersionRevision property is set.
        /// </summary>
        internal bool IsSetVersionRevision() => this.VersionRevision != null;
    }
}
