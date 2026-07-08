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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
    /// Container for the parameters to the UpdateBillingPreferences operation.
    /// Updates billing preferences for the specified feature. Each feature targets a distinct
    /// billing capability and has its own set of supported keys. The action sets the value
    /// for each provided key; keys not present in the request are unchanged.
    /// 
    ///  
    /// <para>
    /// Sharing keys (<c>RI_SHARING</c>, <c>CREDIT_SHARING</c>, <c>CREDIT_LEVEL_SHARING</c>,
    /// and sharing keys under <c>CREDIT_PREFERENCE_OPTIONS</c>) may only be set by the management
    /// account of a consolidated billing family. The <c>credit/{creditId}/status</c> key
    /// may be set by member accounts for credits they own, or by the management account for
    /// any credit in the family.
    /// </para>
    /// </summary>
    public partial class UpdateBillingPreferencesRequest : AmazonBillingRequest
    {
        private List<BillingPreferenceForKey> _billingPreferencesPerKey = AWSConfigs.InitializeCollections ? new List<BillingPreferenceForKey>() : null;
        private BillingFeature _feature;

        /// <summary>
        /// Gets and sets the property BillingPreferencesPerKey. 
        /// <para>
        /// Key/value pairs to apply. All keys in a single request must be valid for the specified
        /// <c>feature</c> and must not be duplicated. For <c>CREDIT_PREFERENCE_OPTIONS</c>, all
        /// keys must reference the same <c>creditId</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<BillingPreferenceForKey> BillingPreferencesPerKey
        {
            get { return this._billingPreferencesPerKey; }
            set { this._billingPreferencesPerKey = value; }
        }

        // Check to see if BillingPreferencesPerKey property is set
        internal bool IsSetBillingPreferencesPerKey()
        {
            return this._billingPreferencesPerKey != null && (this._billingPreferencesPerKey.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The feature to update. Valid values: <c>BILLING_ALERTS</c>, <c>RI_SHARING</c>, <c>CREDIT_SHARING</c>,
        /// <c>CREDIT_LEVEL_SHARING</c>, <c>CREDIT_PREFERENCE_OPTIONS</c>. The history features
        /// (<c>RI_SHARING_HISTORY</c> and <c>CREDIT_SHARING_HISTORY</c>) are read-only and cannot
        /// be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BillingFeature Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

    }
}