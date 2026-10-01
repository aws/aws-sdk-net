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

namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// Container for the parameters to the StartSearchResultExportJob operation. This operations
    /// starts a job to export the results of search job to a designated S3 bucket.
    /// </summary>
    public partial class StartSearchResultExportJobRequest : AmazonBackupSearchRequest
    {
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
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExportSpecification. 
        /// <para>
        /// This specification contains a required string of the destination bucket; optionally,
        /// you can include the destination prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportSpecification ExportSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ExportSpecification property is set.
        /// </summary>
        internal bool IsSetExportSpecification() => this.ExportSpecification != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// This parameter specifies the role ARN used to start the search results export jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SearchJobIdentifier. 
        /// <para>
        /// The unique string that specifies the search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SearchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SearchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetSearchJobIdentifier() => this.SearchJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional tags to include. A tag is a key-value pair you can use to manage, filter,
        /// and search for your resources. Allowed characters include UTF-8 letters, numbers,
        /// spaces, and the following characters: + - = . _ : /. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
