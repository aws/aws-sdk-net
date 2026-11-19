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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBillingPreferences operation. Updates billing
    /// preferences for the specified feature. Each feature targets a distinct billing capability
    /// and has its own set of supported keys. The action sets the value for each provided
    /// key; keys not present in the request are unchanged. <para> To set sharing keys (<c>RI_SHARING</c>,
    /// <c>CREDIT_SHARING</c>, <c>CREDIT_LEVEL_SHARING</c>, <c>BENEFIT_LEVEL_SHARING</c>,
    /// and sharing keys under <c>CREDIT_PREFERENCE_OPTIONS</c>), you must use the management
    /// account of a consolidated billing family. To set the <c>credit/{creditId}/status</c>
    /// key, you must own the credit or use the management account of its family. </para>
    /// </summary>
    public partial class UpdateBillingPreferencesRequest : AmazonBillingRequest
    {
        /// <summary>
        /// Gets and sets the property BillingPreferencesPerKey. 
        /// <para>
        /// Key/value pairs to apply. All keys in a single request must be valid for the specified
        /// <c>feature</c> and must not be duplicated. For <c>CREDIT_PREFERENCE_OPTIONS</c>, all
        /// keys must reference the same <c>creditId</c>.
        /// </para>
        ///  
        /// <para>
        /// For <c>BENEFIT_LEVEL_SHARING</c>, all keys must reference the same Reserved Instance
        /// or Savings Plan. To share it with the accounts in one Cost Category rule, send these
        /// three keys with the value <c>ENABLED</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>benefit/{ri|sp}/{benefitId}/sharing/costCategoryArn/{costCategoryArn}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>benefit/{ri|sp}/{benefitId}/sharing/ruleName/{ruleName}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>benefit/{ri|sp}/{benefitId}/sharing/mode/{prioritized|restricted}</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// With <c>prioritized</c>, any benefit that the rule's accounts don't use goes to the
        /// rest of your consolidated billing family, following your family sharing settings.
        /// With <c>restricted</c>, only the owner and the rule's accounts receive it. The Cost
        /// Category must belong to your account. To stop sharing, send the same three keys with
        /// the value <c>DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// For <c>RI_SHARING</c> and <c>CREDIT_SHARING</c>, you can share benefits by account
        /// group. Each rule in a Cost Category is one group. Send exactly one of these group
        /// keys with the value <c>ENABLED</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>open-sharing</c> - Share across the whole consolidated billing family, with no
        /// groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>costcategory-prioritized/{costCategoryArn}</c> - Share within each group first,
        /// then with the rest of the family.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>costcategory-restricted/{costCategoryArn}</c> - An account in a group shares only
        /// with accounts in the same group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For <c>RI_SHARING</c>, the <c>costcategory-</c> keys use a Cost Category that supports
        /// the <c>billing:rispgroupsharing</c> resource type. To use a Cost Category that supports
        /// the <c>billing:benefitgroupsharing</c> resource type, use the <c>benefitgroup-prioritized/</c>
        /// or <c>benefitgroup-restricted/</c> prefix instead. For <c>CREDIT_SHARING</c>, the
        /// Cost Category must support the <c>billing:benefitgroupsharing</c> resource type. The
        /// Cost Category must belong to your account. <c>GetBillingPreferences</c> returns the
        /// group key that is in effect.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<BillingPreferenceForKey> BillingPreferencesPerKey { get; set; } = AWSConfigs.InitializeCollections ? new List<BillingPreferenceForKey>() : null;

        /// <summary>
        /// Checks to see if the BillingPreferencesPerKey property is set.
        /// </summary>
        internal bool IsSetBillingPreferencesPerKey() => this.BillingPreferencesPerKey != null && (this.BillingPreferencesPerKey.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The feature to update. Valid values: <c>BILLING_ALERTS</c>, <c>RI_SHARING</c>, <c>CREDIT_SHARING</c>,
        /// <c>CREDIT_LEVEL_SHARING</c>, <c>CREDIT_PREFERENCE_OPTIONS</c>, <c>BENEFIT_LEVEL_SHARING</c>.
        /// The history features (<c>RI_SHARING_HISTORY</c> and <c>CREDIT_SHARING_HISTORY</c>)
        /// are read-only and cannot be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillingFeature Feature { get; set; }

        /// <summary>
        /// Checks to see if the Feature property is set.
        /// </summary>
        internal bool IsSetFeature() => this.Feature != null;
    }
}
