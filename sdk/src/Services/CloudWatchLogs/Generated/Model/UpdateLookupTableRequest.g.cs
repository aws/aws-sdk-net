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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLookupTable operation. Updates an existing
    /// lookup table by replacing all of its content with new CSV data or CloudWatch Logs
    /// query results. After the update completes, queries that use this table use the new
    /// data. <para> This is a full replacement operation. All existing content is replaced.
    /// You must specify either <c>tableBody</c> or <c>queryId</c>, but not both. </para>
    /// </summary>
    public partial class UpdateLookupTableRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description of the lookup table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key to use to encrypt the lookup table data. You can use this parameter
        /// to add, update, or remove the KMS key. To remove the KMS key and use an Amazon Web
        /// Services-owned key instead, specify an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LookupTableArn. 
        /// <para>
        /// The ARN of the lookup table to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LookupTableArn { get; set; }

        /// <summary>
        /// Checks to see if the LookupTableArn property is set.
        /// </summary>
        internal bool IsSetLookupTableArn() => this.LookupTableArn != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of a completed or cancelled CloudWatch Logs query whose results replace the
        /// lookup table content. A cancelled query replaces the content with the partial results
        /// that were available when the query was stopped.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>tableBody</c> or <c>queryId</c>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property TableBody. 
        /// <para>
        /// The new CSV content to replace the existing data. The first row must be a header row
        /// with column names. The content must use UTF-8 encoding and not exceed 10 MB.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>tableBody</c> or <c>queryId</c>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10485760)]
        public string TableBody { get; set; }

        /// <summary>
        /// Checks to see if the TableBody property is set.
        /// </summary>
        internal bool IsSetTableBody() => this.TableBody != null;
    }
}
