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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePackage operation. Updates a package for
    /// use with Amazon OpenSearch Service domains. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
    /// packages for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class UpdatePackageRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// Commit message for the updated file, which is shown as part of <c>GetPackageVersionHistoryResponse</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 160)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// Checks to see if the CommitMessage property is set.
        /// </summary>
        internal bool IsSetCommitMessage() => this.CommitMessage != null;

        /// <summary>
        /// Gets and sets the property PackageConfiguration. 
        /// <para>
        /// The updated configuration details for a package.
        /// </para>
        /// </summary>
        public PackageConfiguration PackageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PackageConfiguration property is set.
        /// </summary>
        internal bool IsSetPackageConfiguration() => this.PackageConfiguration != null;

        /// <summary>
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// A new description of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PackageDescription { get; set; }

        /// <summary>
        /// Checks to see if the PackageDescription property is set.
        /// </summary>
        internal bool IsSetPackageDescription() => this.PackageDescription != null;

        /// <summary>
        /// Gets and sets the property PackageEncryptionOptions. 
        /// <para>
        /// Encryption options for a package.
        /// </para>
        /// </summary>
        public PackageEncryptionOptions PackageEncryptionOptions { get; set; }

        /// <summary>
        /// Checks to see if the PackageEncryptionOptions property is set.
        /// </summary>
        internal bool IsSetPackageEncryptionOptions() => this.PackageEncryptionOptions != null;

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// The unique identifier for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PackageID { get; set; }

        /// <summary>
        /// Checks to see if the PackageID property is set.
        /// </summary>
        internal bool IsSetPackageID() => this.PackageID != null;

        /// <summary>
        /// Gets and sets the property PackageSource. 
        /// <para>
        /// Amazon S3 bucket and key for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageSource PackageSource { get; set; }

        /// <summary>
        /// Checks to see if the PackageSource property is set.
        /// </summary>
        internal bool IsSetPackageSource() => this.PackageSource != null;
    }
}
