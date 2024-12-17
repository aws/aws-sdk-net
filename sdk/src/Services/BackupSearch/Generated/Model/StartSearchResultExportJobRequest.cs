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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// Container for the parameters to the StartSearchResultExportJob operation.
    /// This operations starts a job to export the results of search job to a designated S3
    /// bucket.
    /// </summary>
    public partial class StartSearchResultExportJobRequest : AmazonBackupSearchRequest
    {
        private string _clientToken;
        private ExportSpecification _exportSpecification;
        private string _roleArn;
        private string _searchJobIdentifier;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Include this parameter to allow multiple identical calls for idempotency.
        /// </para>
        ///  
        /// <para>
        /// A client token is valid for 8 hours after the first request that uses it is completed.
        /// After this time, any request with the same token is treated as a new request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExportSpecification. 
        /// <para>
        /// This specification contains a required string of the destination bucket; optionally,
        /// you can include the destination prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportSpecification ExportSpecification
        {
            get { return this._exportSpecification; }
            set { this._exportSpecification = value; }
        }

        // Check to see if ExportSpecification property is set
        internal bool IsSetExportSpecification()
        {
            return this._exportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// This parameter specifies the role ARN used to start the search results export jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SearchJobIdentifier. 
        /// <para>
        /// The unique string that specifies the search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SearchJobIdentifier
        {
            get { return this._searchJobIdentifier; }
            set { this._searchJobIdentifier = value; }
        }

        // Check to see if SearchJobIdentifier property is set
        internal bool IsSetSearchJobIdentifier()
        {
            return this._searchJobIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional tags to include. A tag is a key-value pair you can use to manage, filter,
        /// and search for your resources. Allowed characters include UTF-8 letters, numbers,
        /// spaces, and the following characters: + - = . _ : /. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}