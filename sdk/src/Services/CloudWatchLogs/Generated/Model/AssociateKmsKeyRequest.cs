/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateKmsKey operation.
    /// Associates the specified AWS Key Management Service (AWS KMS) customer master key
    /// (CMK) with the specified log group.
    /// 
    ///  
    /// <para>
    /// Associating an AWS KMS CMK with a log group overrides any existing associations between
    /// the log group and a CMK. After a CMK is associated with a log group, all newly ingested
    /// data for the log group is encrypted using the CMK. This association is stored as long
    /// as the data encrypted with the CMK is still within Amazon CloudWatch Logs. This enables
    /// Amazon CloudWatch Logs to decrypt this data whenever it is requested.
    /// </para>
    ///  
    /// <para>
    /// Note that it can take up to 5 minutes for this operation to take effect.
    /// </para>
    ///  
    /// <para>
    /// If you attempt to associate a CMK with a log group but the CMK does not exist or the
    /// CMK is disabled, you will receive an <code>InvalidParameterException</code> error.
    /// 
    /// </para>
    /// </summary>
    public partial class AssociateKmsKeyRequest : AmazonCloudWatchLogsRequest
    {
        private string _kmsKeyId;
        private string _logGroupName;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CMK to use when encrypting log data. For more
        /// information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kms">Amazon
        /// Resource Names - AWS Key Management Service (AWS KMS)</a>.
        /// </para>
        /// </summary>
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