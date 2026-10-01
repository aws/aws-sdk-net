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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePackage operation. Updates a package for
    /// use with Amazon ES domains.
    /// </summary>
    public partial class UpdatePackageRequest : AmazonElasticsearchRequest
    {
        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// An info message for the new version which will be shown as part of <c>GetPackageVersionHistoryResponse</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 160)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// Checks to see if the CommitMessage property is set.
        /// </summary>
        internal bool IsSetCommitMessage() => this.CommitMessage != null;

        /// <summary>
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// New description of the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PackageDescription { get; set; }

        /// <summary>
        /// Checks to see if the PackageDescription property is set.
        /// </summary>
        internal bool IsSetPackageDescription() => this.PackageDescription != null;

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// Unique identifier for the package.
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
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageSource PackageSource { get; set; }

        /// <summary>
        /// Checks to see if the PackageSource property is set.
        /// </summary>
        internal bool IsSetPackageSource() => this.PackageSource != null;
    }
}
