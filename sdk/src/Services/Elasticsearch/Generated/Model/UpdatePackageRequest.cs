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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
    /// Container for the parameters to the UpdatePackage operation.
    /// Updates a package for use with Amazon ES domains.
    /// </summary>
    public partial class UpdatePackageRequest : AmazonElasticsearchRequest
    {
        private string _commitMessage;
        private string _packageDescription;
        private string _packageID;
        private PackageSource _packageSource;

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// An info message for the new version which will be shown as part of <c>GetPackageVersionHistoryResponse</c>.
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
        /// Gets and sets the property PackageDescription. 
        /// <para>
        /// New description of the package.
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
        /// Gets and sets the property PackageID. 
        /// <para>
        /// Unique identifier for the package.
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