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
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Creates or updates a resource policy allowing other Amazon Web Services services to
    /// put log events to this account, such as Amazon Route 53. An account can have up to
    /// 10 resource policies per Amazon Web Services Region.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _policyDocument;
        private string _policyName;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// Details of the new policy, including the identity of the principal that is enabled
        /// to put logs to this account. This is formatted as a JSON string. This parameter is
        /// required.
        /// </para>
        ///  
        /// <para>
        /// The following example creates a resource policy enabling the Route 53 service to put
        /// DNS query logs in to the specified log group. Replace <code>"logArn"</code> with the
        /// ARN of your CloudWatch Logs resource, such as a log group or log stream.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs also supports <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_condition-keys.html#condition-keys-sourcearn">aws:SourceArn</a>
        /// and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_condition-keys.html#condition-keys-sourceaccount">aws:SourceAccount</a>
        /// condition context keys.
        /// </para>
        ///  
        /// <para>
        /// In the example resource policy, you would replace the value of <code>SourceArn</code>
        /// with the resource making the call from Route 53 to CloudWatch Logs. You would also
        /// replace the value of <code>SourceAccount</code> with the Amazon Web Services account
        /// ID making that call.
        /// </para>
        ///   
        /// <para>
        ///  <code>{ "Version": "2012-10-17", "Statement": [ { "Sid": "Route53LogsToCloudWatchLogs",
        /// "Effect": "Allow", "Principal": { "Service": [ "route53.amazonaws.com" ] }, "Action":
        /// "logs:PutLogEvents", "Resource": "logArn", "Condition": { "ArnLike": { "aws:SourceArn":
        /// "myRoute53ResourceArn" }, "StringEquals": { "aws:SourceAccount": "myAwsAccountId"
        /// } } } ] }</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5120)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Name of the new policy. This parameter is required.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

    }
}