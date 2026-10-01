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
    /// Container for the parameters to the PublishPackageVersion operation. Creates a new
    /// package version containing one or more assets (or files). <para> The <c>unfinished</c>
    /// flag can be used to keep the package version in the <c>Unfinished</c> state until
    /// all of its assets have been uploaded (see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status.html#package-version-status">Package
    /// version status</a> in the <i>CodeArtifact user guide</i>). To set the package version’s
    /// status to <c>Published</c>, omit the <c>unfinished</c> flag when uploading the final
    /// asset, or set the status using <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageVersionsStatus.html">UpdatePackageVersionStatus</a>.
    /// Once a package version’s status is set to <c>Published</c>, it cannot change back
    /// to <c>Unfinished</c>. </para> <note> <para> Only generic packages can be published
    /// using this API. For more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-generic.html">Using
    /// generic packages</a> in the <i>CodeArtifact User Guide</i>. </para> </note>
    /// </summary>
    public partial class PublishPackageVersionRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property AssetContent. 
        /// <para>
        /// The content of the asset to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Stream AssetContent { get; set; }

        /// <summary>
        /// Checks to see if the AssetContent property is set.
        /// </summary>
        internal bool IsSetAssetContent() => this.AssetContent != null;

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the asset to publish. Asset names can include Unicode letters and numbers,
        /// and the following special characters: <c>~ ! @ ^ &amp; ( ) - ` _ + [ ] { } ; , . `</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AssetName { get; set; }

        /// <summary>
        /// Checks to see if the AssetName property is set.
        /// </summary>
        internal bool IsSetAssetName() => this.AssetName != null;

        /// <summary>
        /// Gets and sets the property AssetSHA256. 
        /// <para>
        /// The SHA256 hash of the <c>assetContent</c> to publish. This value must be calculated
        /// by the caller and provided with the request (see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/using-generic.html#publishing-generic-packages">Publishing
        /// a generic package</a> in the <i>CodeArtifact User Guide</i>).
        /// </para>
        ///  
        /// <para>
        /// This value is used as an integrity check to verify that the <c>assetContent</c> has
        /// not changed after it was originally sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 64)]
        public string AssetSHA256 { get; set; }

        /// <summary>
        /// Checks to see if the AssetSHA256 property is set.
        /// </summary>
        internal bool IsSetAssetSHA256() => this.AssetSHA256 != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that contains the repository that contains the package version
        /// to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        /// The 12-digit account number of the AWS account that owns the domain. It does not include
        /// dashes or spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainOwner { get; set; }

        /// <summary>
        /// Checks to see if the DomainOwner property is set.
        /// </summary>
        internal bool IsSetDomainOwner() => this.DomainOwner != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// A format that specifies the type of the package version with the requested asset file.
        /// </para>
        ///  
        /// <para>
        /// The only supported value is <c>generic</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package version to publish.
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
        /// The name of the package version to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The package version to publish (for example, <c>3.5.2</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersion property is set.
        /// </summary>
        internal bool IsSetPackageVersion() => this.PackageVersion != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the repository that the package version will be published to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;

        /// <summary>
        /// Gets and sets the property Unfinished. 
        /// <para>
        /// Specifies whether the package version should remain in the <c>unfinished</c> state.
        /// If omitted, the package version status will be set to <c>Published</c> (see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status">Package
        /// version status</a> in the <i>CodeArtifact User Guide</i>).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>unfinished</c> 
        /// </para>
        /// </summary>
        public bool? Unfinished { get; set; }

        /// <summary>
        /// Checks to see if the Unfinished property is set.
        /// </summary>
        internal bool IsSetUnfinished() => this.Unfinished.HasValue;
    }
}
