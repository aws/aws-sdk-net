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
    /// Container for the parameters to the AssociateKmsKey operation.
    /// Associates the specified KMS key with the specified log group.
    /// 
    ///  
    /// <para>
    /// Associating a KMS key with a log group overrides any existing associations between
    /// the log group and a KMS key. After a KMS key is associated with a log group, all newly
    /// ingested data for the log group is encrypted using the KMS key. This association is
    /// stored as long as the data encrypted with the KMS keyis still within CloudWatch Logs.
    /// This enables CloudWatch Logs to decrypt this data whenever it is requested.
    /// </para>
    ///  <important> 
    /// <para>
    /// CloudWatch Logs supports only symmetric KMS keys. Do not use an associate an asymmetric
    /// KMS key with your log group. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric Keys</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// It can take up to 5 minutes for this operation to take effect.
    /// </para>
    ///  
    /// <para>
    /// If you attempt to associate a KMS key with a log group but the KMS key does not exist
    /// or the KMS key is disabled, you receive an <code>InvalidParameterException</code>
    /// error. 
    /// </para>
    /// </summary>
    public partial class AssociateKmsKeyRequest : AmazonCloudWatchLogsRequest
    {
        private string _kmsKeyId;
        private string _logGroupName;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to use when encrypting log data. This
        /// must be a symmetric KMS key. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kms">Amazon
        /// Resource Names</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric Keys</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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

    }
}