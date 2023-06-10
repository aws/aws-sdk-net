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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScheduledQuery operation.
    /// Create a scheduled query that will be run on your behalf at the configured schedule.
    /// Timestream assumes the execution role provided as part of the <code>ScheduledQueryExecutionRoleArn</code>
    /// parameter to run the query. You can use the <code>NotificationConfiguration</code>
    /// parameter to configure notification for your scheduled query operations.
    /// </summary>
    public partial class CreateScheduledQueryRequest : AmazonTimestreamQueryRequest
    {
        private string _clientToken;
        private ErrorReportConfiguration _errorReportConfiguration;
        private string _kmsKeyId;
        private string _name;
        private NotificationConfiguration _notificationConfiguration;
        private string _queryString;
        private ScheduleConfiguration _scheduleConfiguration;
        private string _scheduledQueryExecutionRoleArn;
        private List<Tag> _tags = new List<Tag>();
        private TargetConfiguration _targetConfiguration;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Using a ClientToken makes the call to CreateScheduledQuery idempotent, in other words,
        /// making the same request repeatedly will produce the same result. Making multiple identical
        /// CreateScheduledQuery requests has the same effect as making a single request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If CreateScheduledQuery is called without a <code>ClientToken</code>, the Query SDK
        /// generates a <code>ClientToken</code> on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After 8 hours, any request with the same <code>ClientToken</code> is treated as a
        /// new request. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=32, Max=128)]
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
        /// Gets and sets the property ErrorReportConfiguration. 
        /// <para>
        /// Configuration for error reporting. Error reports will be generated when a problem
        /// is encountered when writing the query results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ErrorReportConfiguration ErrorReportConfiguration
        {
            get { return this._errorReportConfiguration; }
            set { this._errorReportConfiguration = value; }
        }

        // Check to see if ErrorReportConfiguration property is set
        internal bool IsSetErrorReportConfiguration()
        {
            return this._errorReportConfiguration != null;
        }

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
        /// If ErrorReportConfiguration uses <code>SSE_KMS</code> as encryption type, the same
        /// KmsKeyId is used to encrypt the error report at rest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Notification configuration for the scheduled query. A notification is sent by Timestream
        /// when a query run finishes, when the state is updated or when you delete it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationConfiguration NotificationConfiguration
        {
            get { return this._notificationConfiguration; }
            set { this._notificationConfiguration = value; }
        }

        // Check to see if NotificationConfiguration property is set
        internal bool IsSetNotificationConfiguration()
        {
            return this._notificationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to run. Parameter names can be specified in the query string <code>@</code>
        /// character followed by an identifier. The named Parameter <code>@scheduled_runtime</code>
        /// is reserved and can be used in the query to get the time at which the query is scheduled
        /// to run.
        /// </para>
        ///  
        /// <para>
        /// The timestamp calculated according to the ScheduleConfiguration parameter, will be
        /// the value of <code>@scheduled_runtime</code> paramater for each query run. For example,
        /// consider an instance of a scheduled query executing on 2021-12-01 00:00:00. For this
        /// instance, the <code>@scheduled_runtime</code> parameter is initialized to the timestamp
        /// 2021-12-01 00:00:00 when invoking the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=262144)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule configuration for the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledQueryExecutionRoleArn. 
        /// <para>
        /// The ARN for the IAM role that Timestream will assume when running the scheduled query.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ScheduledQueryExecutionRoleArn
        {
            get { return this._scheduledQueryExecutionRoleArn; }
            set { this._scheduledQueryExecutionRoleArn = value; }
        }

        // Check to see if ScheduledQueryExecutionRoleArn property is set
        internal bool IsSetScheduledQueryExecutionRoleArn()
        {
            return this._scheduledQueryExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to label the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Configuration used for writing the result of a query.
        /// </para>
        /// </summary>
        public TargetConfiguration TargetConfiguration
        {
            get { return this._targetConfiguration; }
            set { this._targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this._targetConfiguration != null;
        }

    }
}