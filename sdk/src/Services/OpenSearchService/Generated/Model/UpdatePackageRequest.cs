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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePackage operation.
    /// Updates a package for use with Amazon OpenSearch Service domains. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
    /// packages for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class UpdatePackageRequest : AmazonOpenSearchServiceRequest
    {
        private string _commitMessage;
        private PackageConfiguration _packageConfiguration;
        private string _packageDescription;
        private PackageEncryptionOptions _packageEncryptionOptions;
        private string _packageID;
        private PackageSource _packageSource;

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// Commit message for the updated file, which is shown as part of <c>GetPackageVersionHistoryResponse</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=160)]
        public string CommitMessage
        {
            get { return this._commitMessage; }
            set { this._commitMessage = value; }
        }

        // Check to see if CommitMessage property is set
        internal bool IsSetCommitMessage()
        {
            return this._commitMessage != null;
        }

        /// <summary>
        /// Gets and sets the property PackageConfiguration. 
        /// <para>
        /// The updated configuration details for a package.
        /// </para>
        /// </summary>
        public PackageConfiguration PackageConfiguration
        {
            get { return this._packageConfiguration; }
            set { this._packageConfiguration = value; }
        }

        // Check to see if PackageConfiguration property is set
        internal bool IsSetPackageConfiguration()
        {
            return this._packageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// A new description of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string PackageDescription
        {
            get { return this._packageDescription; }
            set { this._packageDescription = value; }
        }

        // Check to see if PackageDescription property is set
        internal bool IsSetPackageDescription()
        {
            return this._packageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PackageEncryptionOptions. 
        /// <para>
        /// Encryption options for a package.
        /// </para>
        /// </summary>
        public PackageEncryptionOptions PackageEncryptionOptions
        {
            get { return this._packageEncryptionOptions; }
            set { this._packageEncryptionOptions = value; }
        }

        // Check to see if PackageEncryptionOptions property is set
        internal bool IsSetPackageEncryptionOptions()
        {
            return this._packageEncryptionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// The unique identifier for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackageID
        {
            get { return this._packageID; }
            set { this._packageID = value; }
        }

        // Check to see if PackageID property is set
        internal bool IsSetPackageID()
        {
            return this._packageID != null;
        }

        /// <summary>
        /// Gets and sets the property PackageSource. 
        /// <para>
        /// Amazon S3 bucket and key for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageSource PackageSource
        {
            get { return this._packageSource; }
            set { this._packageSource = value; }
        }

        // Check to see if PackageSource property is set
        internal bool IsSetPackageSource()
        {
            return this._packageSource != null;
        }

    }
}