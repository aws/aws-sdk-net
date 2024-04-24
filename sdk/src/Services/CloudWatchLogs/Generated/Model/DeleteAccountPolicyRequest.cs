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
    /// Container for the parameters to the DeleteAccountPolicy operation.
    /// Deletes a CloudWatch Logs account policy. This stops the policy from applying to all
    /// log groups or a subset of log groups in the account. Log-group level policies will
    /// still be in effect.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must be signed on with the correct permissions depending
    /// on the type of policy that you are deleting.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To delete a data protection policy, you must have the <c>logs:DeleteDataProtectionPolicy</c>
    /// and <c>logs:DeleteAccountPolicy</c> permissions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To delete a subscription filter policy, you must have the <c>logs:DeleteSubscriptionFilter</c>
    /// and <c>logs:DeleteAccountPolicy</c> permissions.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteAccountPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _policyName;
        private PolicyType _policyType;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}