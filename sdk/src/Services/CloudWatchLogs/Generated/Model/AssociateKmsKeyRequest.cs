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
    /// Container for the parameters to the AssociateKmsKey operation.
    /// Associates the specified KMS key with either one log group in the account, or with
    /// all stored CloudWatch Logs query insights results in the account.
    /// 
    ///  
    /// <para>
    /// When you use <c>AssociateKmsKey</c>, you specify either the <c>logGroupName</c> parameter
    /// or the <c>resourceIdentifier</c> parameter. You can't specify both of those parameters
    /// in the same operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the <c>logGroupName</c> parameter to cause log events ingested into that log
    /// group to be encrypted with that key. Only the log events ingested after the key is
    /// associated are encrypted with that key.
    /// </para>
    ///  
    /// <para>
    /// Associating a KMS key with a log group overrides any existing associations between
    /// the log group and a KMS key. After a KMS key is associated with a log group, all newly
    /// ingested data for the log group is encrypted using the KMS key. This association is
    /// stored as long as the data encrypted with the KMS key is still within CloudWatch Logs.
    /// This enables CloudWatch Logs to decrypt this data whenever it is requested.
    /// </para>
    ///  
    /// <para>
    /// Associating a key with a log group does not cause the results of queries of that log
    /// group to be encrypted with that key. To have query results encrypted with a KMS key,
    /// you must use an <c>AssociateKmsKey</c> operation with the <c>resourceIdentifier</c>
    /// parameter that specifies a <c>query-result</c> resource. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify the <c>resourceIdentifier</c> parameter with a <c>query-result</c> resource,
    /// to use that key to encrypt the stored results of all future <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
    /// operations in the account. The response from a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
    /// operation will still return the query results in plain text.
    /// </para>
    ///  
    /// <para>
    /// Even if you have not associated a key with your query results, the query results are
    /// encrypted when stored, using the default CloudWatch Logs method.
    /// </para>
    ///  
    /// <para>
    /// If you run a query from a monitoring account that queries logs in a source account,
    /// the query results key from the monitoring account, if any, is used.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// If you delete the key that is used to encrypt log events or log group query results,
    /// then all the associated stored log events or query results that were encrypted with
    /// that key will be unencryptable and unusable.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// CloudWatch Logs supports only symmetric KMS keys. Do not associate an asymmetric KMS
    /// key with your log group or query results. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric Keys</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// It can take up to 5 minutes for this operation to take effect.
    /// </para>
    ///  
    /// <para>
    /// If you attempt to associate a KMS key with a log group but the KMS key does not exist
    /// or the KMS key is disabled, you receive an <c>InvalidParameterException</c> error.
    /// 
    /// </para>
    /// </summary>
    public partial class AssociateKmsKeyRequest : AmazonCloudWatchLogsRequest
    {
        private string _kmsKeyId;
        private string _logGroupName;
        private string _resourceIdentifier;

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
        ///  
        /// <para>
        /// In your <c>AssociateKmsKey</c> operation, you must specify either the <c>resourceIdentifier</c>
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
        /// Specify the following ARN to have future <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
        /// operations in this account encrypt the results with the specified KMS key. Replace
        /// <i>REGION</i> and <i>ACCOUNT_ID</i> with your Region and account ID.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:<i>REGION</i>:<i>ACCOUNT_ID</i>:query-result:*</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the ARN of a log group to have CloudWatch Logs use the KMS key to encrypt
        /// log events that are ingested and stored by that log group. The log group ARN must
        /// be in the following format. Replace <i>REGION</i> and <i>ACCOUNT_ID</i> with your
        /// Region and account ID.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:<i>REGION</i>:<i>ACCOUNT_ID</i>:log-group:<i>LOG_GROUP_NAME</i> </c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In your <c>AssociateKmsKey</c> operation, you must specify either the <c>resourceIdentifier</c>
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