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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeleteAccountPolicy operation. Deletes a CloudWatch
    /// Logs account policy. This stops the account-wide policy from applying to log groups
    /// or data sources in the account. If you delete a data protection policy or subscription
    /// filter policy, any log-group level policies of those types remain in effect. This
    /// operation supports deletion of data source-based field index policies, including facet
    /// configurations, in addition to log group-based policies. <para> To use this operation,
    /// you must be signed on with the correct permissions depending on the type of policy
    /// that you are deleting. </para> <ul> <li> <para> To delete a data protection policy,
    /// you must have the <c>logs:DeleteDataProtectionPolicy</c> and <c>logs:DeleteAccountPolicy</c>
    /// permissions. </para> </li> <li> <para> To delete a subscription filter policy, you
    /// must have the <c>logs:DeleteSubscriptionFilter</c> and <c>logs:DeleteAccountPolicy</c>
    /// permissions. </para> </li> <li> <para> To delete a transformer policy, you must have
    /// the <c>logs:DeleteTransformer</c> and <c>logs:DeleteAccountPolicy</c> permissions.
    /// </para> </li> <li> <para> To delete a field index policy, you must have the <c>logs:DeleteIndexPolicy</c>
    /// and <c>logs:DeleteAccountPolicy</c> permissions. </para> <para> If you delete a field
    /// index policy that included facet configurations, those facets will no longer be available
    /// for interactive exploration in the CloudWatch Logs Insights console. However, facet
    /// data is retained for up to 30 days. </para> </li> </ul> <para> If you delete a field
    /// index policy, the indexing of the log events that happened before you deleted the
    /// policy will still be used for up to 30 days to improve CloudWatch Logs Insights queries.
    /// </para>
    /// </summary>
    public partial class DeleteAccountPolicyRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;
    }
}
