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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScheduledQuery operation. Create a scheduled
    /// query that will be run on your behalf at the configured schedule. Timestream assumes
    /// the execution role provided as part of the <c>ScheduledQueryExecutionRoleArn</c> parameter
    /// to run the query. You can use the <c>NotificationConfiguration</c> parameter to configure
    /// notification for your scheduled query operations.
    /// </summary>
    public partial class CreateScheduledQueryRequest : AmazonTimestreamQueryRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Using a ClientToken makes the call to CreateScheduledQuery idempotent, in other words,
        /// making the same request repeatedly will produce the same result. Making multiple identical
        /// CreateScheduledQuery requests has the same effect as making a single request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If CreateScheduledQuery is called without a <c>ClientToken</c>, the Query SDK generates
        /// a <c>ClientToken</c> on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After 8 hours, any request with the same <c>ClientToken</c> is treated as a new request.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 32, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ErrorReportConfiguration. 
        /// <para>
        /// Configuration for error reporting. Error reports will be generated when a problem
        /// is encountered when writing the query results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ErrorReportConfiguration ErrorReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReportConfiguration property is set.
        /// </summary>
        internal bool IsSetErrorReportConfiguration() => this.ErrorReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon KMS key used to encrypt the scheduled query resource, at-rest. If the Amazon
        /// KMS key is not specified, the scheduled query resource will be encrypted with a Timestream
        /// owned Amazon KMS key. To specify a KMS key, use the key ID, key ARN, alias name, or
        /// alias ARN. When using an alias name, prefix the name with <i>alias/</i> 
        /// </para>
        ///  
        /// <para>
        /// If ErrorReportConfiguration uses <c>SSE_KMS</c> as encryption type, the same KmsKeyId
        /// is used to encrypt the error report at rest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Notification configuration for the scheduled query. A notification is sent by Timestream
        /// when a query run finishes, when the state is updated or when you delete it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationConfiguration NotificationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfiguration property is set.
        /// </summary>
        internal bool IsSetNotificationConfiguration() => this.NotificationConfiguration != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to run. Parameter names can be specified in the query string <c>@</c>
        /// character followed by an identifier. The named Parameter <c>@scheduled_runtime</c>
        /// is reserved and can be used in the query to get the time at which the query is scheduled
        /// to run.
        /// </para>
        ///  
        /// <para>
        /// The timestamp calculated according to the ScheduleConfiguration parameter, will be
        /// the value of <c>@scheduled_runtime</c> paramater for each query run. For example,
        /// consider an instance of a scheduled query executing on 2021-12-01 00:00:00. For this
        /// instance, the <c>@scheduled_runtime</c> parameter is initialized to the timestamp
        /// 2021-12-01 00:00:00 when invoking the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 262144)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule configuration for the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduleConfiguration() => this.ScheduleConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScheduledQueryExecutionRoleArn. 
        /// <para>
        /// The ARN for the IAM role that Timestream will assume when running the scheduled query.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ScheduledQueryExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledQueryExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetScheduledQueryExecutionRoleArn() => this.ScheduledQueryExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to label the scheduled query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Configuration used for writing the result of a query.
        /// </para>
        /// </summary>
        public TargetConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;
    }
}
