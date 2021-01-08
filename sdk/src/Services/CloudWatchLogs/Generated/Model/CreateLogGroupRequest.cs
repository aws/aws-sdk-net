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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLogGroup operation.
    /// Creates a log group with the specified name. You can create up to 20,000 log groups
    /// per account.
    /// 
    ///  
    /// <para>
    /// You must use the following guidelines when naming a log group:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Log group names must be unique within a region for an AWS account.
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
    ///  </li> </ul> 
    /// <para>
    /// When you create a log group, by default the log events in the log group never expire.
    /// To set a retention policy so that events expire and are deleted after a specified
    /// time, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutRetentionPolicy.html">PutRetentionPolicy</a>.
    /// </para>
    ///  
    /// <para>
    /// If you associate a AWS Key Management Service (AWS KMS) customer master key (CMK)
    /// with the log group, ingested data is encrypted using the CMK. This association is
    /// stored as long as the data encrypted with the CMK is still within Amazon CloudWatch
    /// Logs. This enables Amazon CloudWatch Logs to decrypt this data whenever it is requested.
    /// </para>
    ///  
    /// <para>
    /// If you attempt to associate a CMK with the log group but the CMK does not exist or
    /// the CMK is disabled, you receive an <code>InvalidParameterException</code> error.
    /// 
    /// </para>
    ///  <important> 
    /// <para>
    ///  CloudWatch Logs supports only symmetric CMKs. Do not associate an asymmetric CMK
    /// with your log group. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric Keys</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateLogGroupRequest : AmazonCloudWatchLogsRequest
    {
        private string _kmsKeyId;
        private string _logGroupName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLogGroupRequest() { }

        /// <summary>
        /// Instantiates CreateLogGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        public CreateLogGroupRequest(string logGroupName)
        {
            _logGroupName = logGroupName;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CMK to use when encrypting log data. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kms">Amazon
        /// Resource Names - AWS Key Management Service (AWS KMS)</a>.
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
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}