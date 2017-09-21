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
    /// Container for the parameters to the DisassociateKmsKey operation.
    /// Disassociates the associated AWS Key Management Service (AWS KMS) customer master
    /// key (CMK) from the specified log group.
    /// 
    ///  
    /// <para>
    /// After the AWS KMS CMK is disassociated from the log group, AWS CloudWatch Logs stops
    /// encrypting newly ingested data for the log group. All previously ingested data remains
    /// encrypted, and AWS CloudWatch Logs requires permissions for the CMK whenever the encrypted
    /// data is requested.
    /// </para>
    ///  
    /// <para>
    /// Note that it can take up to 5 minutes for this operation to take effect.
    /// </para>
    /// </summary>
    public partial class DisassociateKmsKeyRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupName;

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