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
    /// Container for the parameters to the PublishPackageVersion operation.
    /// Creates a new package version containing one or more assets (or files).
    /// 
    ///  
    /// <para>
    /// The <code>unfinished</code> flag can be used to keep the package version in the <code>Unfinished</code>
    /// state until all of it’s assets have been uploaded (see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status.html#package-version-status">Package
    /// version status</a> in the <i>CodeArtifact user guide</i>). To set the package version’s
    /// status to <code>Published</code>, omit the <code>unfinished</code> flag when uploading
    /// the final asset, or set the status using <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageVersionsStatus.html">UpdatePackageVersionStatus</a>.
    /// Once a package version’s status is set to <code>Published</code>, it cannot change
    /// back to <code>Unfinished</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Only generic packages can be published using this API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PublishPackageVersionRequest : AmazonCodeArtifactRequest
    {
        private Stream _assetContent;
        private string _assetName;
        private string _assetsha256;
        private string _domain;
        private string _domainOwner;
        private PackageFormat _format;
        private string _awsNamespace;
        private string _package;
        private string _packageVersion;
        private string _repository;
        private bool? _unfinished;

        /// <summary>
        /// Gets and sets the property AssetContent. 
        /// <para>
        /// The content of the asset to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream AssetContent
        {
            get { return this._assetContent; }
            set { this._assetContent = value; }
        }

        // Check to see if AssetContent property is set
        internal bool IsSetAssetContent()
        {
            return this._assetContent != null;
        }

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the asset to publish. Asset names can include Unicode letters and numbers,
        /// and the following special characters: <code>~ ! @ ^ &amp; ( ) - ` _ + [ ] { } ; ,
        /// . `</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetSHA256. 
        /// <para>
        /// The SHA256 hash of the <code>assetContent</code> to publish. This value must be calculated
        /// by the caller and provided with the request.
        /// </para>
        ///  
        /// <para>
        /// This value is used as an integrity check to verify that the <code>assetContent</code>
        /// has not changed after it was originally sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=64, Max=64)]
        public string AssetSHA256
        {
            get { return this._assetsha256; }
            set { this._assetsha256 = value; }
        }

        // Check to see if AssetSHA256 property is set
        internal bool IsSetAssetSHA256()
        {
            return this._assetsha256 != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that contains the repository that contains the package version
        /// to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        /// The 12-digit account number of the AWS account that owns the domain. It does not include
        /// dashes or spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// A format that specifies the type of the package version with the requested asset file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package version to publish.
        /// </para>
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
        /// The name of the package version to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The package version to publish (for example, <code>3.5.2</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the repository that the package version will be published to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property Unfinished. 
        /// <para>
        /// Specifies whether the package version should remain in the <code>unfinished</code>
        /// state. If omitted, the package version status will be set to <code>Published</code>
        /// (see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status.html#package-version-status">Package
        /// version status</a> in the <i>CodeArtifact User Guide</i>).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>unfinished</code> 
        /// </para>
        /// </summary>
        public bool Unfinished
        {
            get { return this._unfinished.GetValueOrDefault(); }
            set { this._unfinished = value; }
        }

        // Check to see if Unfinished property is set
        internal bool IsSetUnfinished()
        {
            return this._unfinished.HasValue; 
        }

    }
}