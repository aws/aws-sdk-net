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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CheckoutLicense operation. Checks out the specified
    /// license. <note> <para> If the account that created the license is the same that is
    /// performing the check out, you must specify the account as the beneficiary. </para>
    /// </note>
    /// </summary>
    public partial class CheckoutLicenseRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Beneficiary. 
        /// <para>
        /// License beneficiary.
        /// </para>
        /// </summary>
        public string Beneficiary { get; set; }

        /// <summary>
        /// Checks to see if the Beneficiary property is set.
        /// </summary>
        internal bool IsSetBeneficiary() => this.Beneficiary != null;

        /// <summary>
        /// Gets and sets the property CheckoutType. 
        /// <para>
        /// Checkout type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CheckoutType CheckoutType { get; set; }

        /// <summary>
        /// Checks to see if the CheckoutType property is set.
        /// </summary>
        internal bool IsSetCheckoutType() => this.CheckoutType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// License entitlements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EntitlementData> Entitlements { get; set; } = AWSConfigs.InitializeCollections ? new List<EntitlementData>() : null;

        /// <summary>
        /// Checks to see if the Entitlements property is set.
        /// </summary>
        internal bool IsSetEntitlements() => this.Entitlements != null && (this.Entitlements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyFingerprint. 
        /// <para>
        /// Key fingerprint identifying the license.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KeyFingerprint { get; set; }

        /// <summary>
        /// Checks to see if the KeyFingerprint property is set.
        /// </summary>
        internal bool IsSetKeyFingerprint() => this.KeyFingerprint != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// Node ID.
        /// </para>
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property ProductSKU. 
        /// <para>
        /// Product SKU.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductSKU { get; set; }

        /// <summary>
        /// Checks to see if the ProductSKU property is set.
        /// </summary>
        internal bool IsSetProductSKU() => this.ProductSKU != null;
    }
}
