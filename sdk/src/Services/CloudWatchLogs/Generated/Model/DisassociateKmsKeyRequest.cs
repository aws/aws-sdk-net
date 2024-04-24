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
    /// Container for the parameters to the DisassociateKmsKey operation.
    /// Disassociates the specified KMS key from the specified log group or from all CloudWatch
    /// Logs Insights query results in the account.
    /// 
    ///  
    /// <para>
    /// When you use <c>DisassociateKmsKey</c>, you specify either the <c>logGroupName</c>
    /// parameter or the <c>resourceIdentifier</c> parameter. You can't specify both of those
    /// parameters in the same operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the <c>logGroupName</c> parameter to stop using the KMS key to encrypt future
    /// log events ingested and stored in the log group. Instead, they will be encrypted with
    /// the default CloudWatch Logs method. The log events that were ingested while the key
    /// was associated with the log group are still encrypted with that key. Therefore, CloudWatch
    /// Logs will need permissions for the key whenever that data is accessed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify the <c>resourceIdentifier</c> parameter with the <c>query-result</c> resource
    /// to stop using the KMS key to encrypt the results of all future <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
    /// operations in the account. They will instead be encrypted with the default CloudWatch
    /// Logs method. The results from queries that ran while the key was associated with the
    /// account are still encrypted with that key. Therefore, CloudWatch Logs will need permissions
    /// for the key whenever that data is accessed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// It can take up to 5 minutes for this operation to take effect.
    /// </para>
    /// </summary>
    public partial class DisassociateKmsKeyRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupName;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        ///  
        /// <para>
        /// In your <c>DisassociateKmsKey</c> operation, you must specify either the <c>resourceIdentifier</c>
        /// parameter or the <c>logGroup</c> parameter, but you can't specify both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Specifies the target for this operation. You must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the ARN of a log group to stop having CloudWatch Logs use the KMS key to encrypt
        /// log events that are ingested and stored by that log group. After you run this operation,
        /// CloudWatch Logs encrypts ingested log events with the default CloudWatch Logs method.
        /// The log group ARN must be in the following format. Replace <i>REGION</i> and <i>ACCOUNT_ID</i>
        /// with your Region and account ID.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:<i>REGION</i>:<i>ACCOUNT_ID</i>:log-group:<i>LOG_GROUP_NAME</i> </c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the following ARN to stop using this key to encrypt the results of future
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// operations in this account. Replace <i>REGION</i> and <i>ACCOUNT_ID</i> with your
        /// Region and account ID.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:<i>REGION</i>:<i>ACCOUNT_ID</i>:query-result:*</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In your <c>DisssociateKmsKey</c> operation, you must specify either the <c>resourceIdentifier</c>
        /// parameter or the <c>logGroup</c> parameter, but you can't specify both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}