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
    /// A single billing preference entry returned by <c>GetBillingPreferences</c>.
    /// </summary>
    public partial class BillingPreferenceSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The associated Amazon Web Services account ID. Populated for account-list keys; <c>null</c>
        /// otherwise.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The display name of the account. Populated together with <c>accountId</c>; <c>null</c>
        /// otherwise.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period associated with the preference change. Populated only for the history
        /// features <c>RI_SHARING_HISTORY</c> and <c>CREDIT_SHARING_HISTORY</c>.
        /// </para>
        /// </summary>
        public BillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The feature this preference belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillingFeature Feature { get; set; }

        /// <summary>
        /// Checks to see if the Feature property is set.
        /// </summary>
        internal bool IsSetFeature() => this.Feature != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The preference key. Format depends on the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2148)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The preference value. Valid values: <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PreferenceValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
