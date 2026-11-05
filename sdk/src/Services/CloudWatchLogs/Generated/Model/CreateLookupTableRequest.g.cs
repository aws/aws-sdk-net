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
    /// Container for the parameters to the CreateLookupTable operation. Creates a lookup
    /// table by uploading CSV data or from CloudWatch Logs query results. You can use lookup
    /// tables to enrich log data in CloudWatch Logs queries with reference data such as user
    /// details, application names, or error descriptions. <para> The table name must be unique
    /// within your account and Region. You must specify either <c>tableBody</c> or <c>queryId</c>,
    /// but not both. If you use <c>tableBody</c>, the CSV content must include a header row
    /// with column names, use UTF-8 encoding, and not exceed 10 MB. </para>
    /// </summary>
    public partial class CreateLookupTableRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the lookup table. The description can be up to 1024 characters long.
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
        /// The ARN of the KMS key to use to encrypt the lookup table data. If you don't specify
        /// a key, the data is encrypted with an Amazon Web Services-owned key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LookupTableName. 
        /// <para>
        /// The name of the lookup table. The name must be unique within your account and Region.
        /// The name can contain only alphanumeric characters and underscores, and can be up to
        /// 256 characters long.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string LookupTableName { get; set; }

        /// <summary>
        /// Checks to see if the LookupTableName property is set.
        /// </summary>
        internal bool IsSetLookupTableName() => this.LookupTableName != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of a completed or cancelled CloudWatch Logs query whose results populate the
        /// lookup table. A cancelled query populates the table with the partial results that
        /// were available when the query was stopped.
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
        /// The CSV content of the lookup table. The first row must be a header row with column
        /// names. The content must use UTF-8 encoding and not exceed 10 MB.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the lookup table. You can associate as
        /// many as 50 tags with a lookup table. Tags can help you organize and categorize your
        /// resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
