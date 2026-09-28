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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBillingTransferPreference operation. Sets
    /// the auto billing group creation preference for a billing transfer. When the preference
    /// is enabled, Billing Conductor automatically creates an indirect billing transfer billing
    /// group in your account, with the pricing plan that you specify, for each account that
    /// transfers its bill to the bill source account of this billing transfer. The preference
    /// applies only to billing groups that are created after you enable it. <para> Enabling
    /// the preference requires the <c>iam:CreateServiceLinkedRole</c> permission. While a
    /// pricing plan is specified in an enabled preference, you can't delete that pricing
    /// plan. </para>
    /// </summary>
    public partial class UpdateBillingTransferPreferenceRequest : AmazonBillingConductorRequest
    {
        /// <summary>
        /// Gets and sets the property AutoBillingTransferBillingGroupCreation. 
        /// <para>
        /// The auto billing group creation preference to set for the billing transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoTransferBillingGroupCreationPreference AutoBillingTransferBillingGroupCreation { get; set; }

        /// <summary>
        /// Checks to see if the AutoBillingTransferBillingGroupCreation property is set.
        /// </summary>
        internal bool IsSetAutoBillingTransferBillingGroupCreation() => this.AutoBillingTransferBillingGroupCreation != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you specify to ensure idempotency of the
        /// request. Idempotency ensures that an API request completes no more than one time.
        /// With an idempotent request, if the original request completes successfully, any subsequent
        /// retries complete successfully without performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ResponsibilityTransferArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the billing transfer whose preference you want to
        /// set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResponsibilityTransferArn { get; set; }

        /// <summary>
        /// Checks to see if the ResponsibilityTransferArn property is set.
        /// </summary>
        internal bool IsSetResponsibilityTransferArn() => this.ResponsibilityTransferArn != null;
    }
}
