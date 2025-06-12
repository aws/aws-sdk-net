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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
    /// Container for the parameters to the CreateLogGroup operation.
    /// Creates a log group with the specified name. You can create up to 1,000,000 log groups
    /// per Region per account.
    /// 
    ///  
    /// <para>
    /// You must use the following guidelines when naming a log group:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Log group names must be unique within a Region for an Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Log group names can be between 1 and 512 characters long.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Log group names consist of the following characters: a-z, A-Z, 0-9, '_' (underscore),
    /// '-' (hyphen), '/' (forward slash), '.' (period), and '#' (number sign)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Log group names can't start with the string <c>aws/</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you create a log group, by default the log events in the log group do not expire.
    /// To set a retention policy so that events expire and are deleted after a specified
    /// time, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutRetentionPolicy.html">PutRetentionPolicy</a>.
    /// </para>
    ///  
    /// <para>
    /// If you associate an KMS key with the log group, ingested data is encrypted using the
    /// KMS key. This association is stored as long as the data encrypted with the KMS key
    /// is still within CloudWatch Logs. This enables CloudWatch Logs to decrypt this data
    /// whenever it is requested.
    /// </para>
    ///  
    /// <para>
    /// If you attempt to associate a KMS key with the log group but the KMS key does not
    /// exist or the KMS key is disabled, you receive an <c>InvalidParameterException</c>
    /// error. 
    /// </para>
    ///  <important> 
    /// <para>
    /// CloudWatch Logs supports only symmetric KMS keys. Do not associate an asymmetric KMS
    /// key with your log group. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric Keys</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateLogGroupRequest : AmazonCloudWatchLogsRequest
    {
        private string _kmsKeyId;
        private LogGroupClass _logGroupClass;
        private string _logGroupName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLogGroupRequest() { }

        /// <summary>
        /// Instantiates CreateLogGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">A name for the log group.</param>
        public CreateLogGroupRequest(string logGroupName)
        {
            _logGroupName = logGroupName;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to use when encrypting log data. For
        /// more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kms">Amazon
        /// Resource Names</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property LogGroupClass. 
        /// <para>
        /// Use this parameter to specify the log group class for this log group. There are three
        /// classes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>Standard</c> log class supports all CloudWatch Logs features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Infrequent Access</c> log class supports a subset of CloudWatch Logs features
        /// and incurs lower costs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>Delivery</c> log class only for delivering Lambda logs to store in Amazon
        /// S3 or Amazon Data Firehose. Log events in log groups in the Delivery class are kept
        /// in CloudWatch Logs for only one day. This log class doesn't offer rich CloudWatch
        /// Logs capabilities such as CloudWatch Logs Insights queries.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you omit this parameter, the default of <c>STANDARD</c> is used.
        /// </para>
        ///  <important> 
        /// <para>
        /// The value of <c>logGroupClass</c> can't be changed after a log group is created.
        /// </para>
        ///  </important> 
        /// <para>
        /// For details about the features supported by each class, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch_Logs_Log_Classes.html">Log
        /// classes</a> 
        /// </para>
        /// </summary>
        public LogGroupClass LogGroupClass
        {
            get { return this._logGroupClass; }
            set { this._logGroupClass = value; }
        }

        // Check to see if LogGroupClass property is set
        internal bool IsSetLogGroupClass()
        {
            return this._logGroupClass != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// A name for the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to use for the tags.
        /// </para>
        ///  
        /// <para>
        /// You can grant users access to certain log groups while preventing them from accessing
        /// other log groups. To do so, tag your groups and use IAM policies that refer to those
        /// tags. To assign tags when you create a log group, you must have either the <c>logs:TagResource</c>
        /// or <c>logs:TagLogGroup</c> permission. For more information about tagging, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a>. For more information about using tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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