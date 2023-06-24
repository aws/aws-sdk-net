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
    /// This is the response object from the PublishPackageVersion operation.
    /// </summary>
    public partial class PublishPackageVersionResponse : AmazonWebServiceResponse
    {
        private AssetSummary _asset;
        private PackageFormat _format;
        private string _awsNamespace;
        private string _package;
        private PackageVersionStatus _status;
        private string _version;
        private string _versionRevision;

        /// <summary>
        /// Gets and sets the property Asset. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_AssetSummary.html">AssetSummary</a>
        /// for the published asset.
        /// </para>
        /// </summary>
        public AssetSummary Asset
        {
            get { return this._asset; }
            set { this._asset = value; }
        }

        // Check to see if Asset property is set
        internal bool IsSetAsset()
        {
            return this._asset != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the package version.
        /// </para>
        /// </summary>
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
        /// The namespace of the package version.
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
        /// The name of the package.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A string that contains the status of the package version. For more information, see
        /// <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/packages-overview.html#package-version-status.html#package-version-status">Package
        /// version status</a> in the <i>CodeArtifact User Guide</i>.
        /// </para>
        /// </summary>
        public PackageVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VersionRevision. 
        /// <para>
        /// The revision of the package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string VersionRevision
        {
            get { return this._versionRevision; }
            set { this._versionRevision = value; }
        }

        // Check to see if VersionRevision property is set
        internal bool IsSetVersionRevision()
        {
            return this._versionRevision != null;
        }

    }
}