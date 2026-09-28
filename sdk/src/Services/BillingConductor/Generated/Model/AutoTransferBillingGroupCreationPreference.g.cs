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
    /// The auto billing group creation preference for a billing transfer. When the preference
    /// is enabled, Billing Conductor automatically creates an indirect billing transfer billing
    /// group, with the specified pricing plan, for each account that transfers its bill to
    /// the bill source account of the billing transfer.
    /// </summary>
    public partial class AutoTransferBillingGroupCreationPreference
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  Specifies whether Billing Conductor automatically creates billing groups for the
        /// billing transfer. The preference is disabled by default. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property PricingPlanArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the pricing plan to apply to the automatically
        /// created billing groups. This value is required when <c>Enabled</c> is <c>true</c>,
        /// and must be omitted when <c>Enabled</c> is <c>false</c>. 
        /// </para>
        /// </summary>
        public string PricingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlanArn property is set.
        /// </summary>
        internal bool IsSetPricingPlanArn() => this.PricingPlanArn != null;
    }
}
