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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CheckoutLicense operation.
    /// Checks out the specified license.
    /// </summary>
    public partial class CheckoutLicenseRequest : AmazonLicenseManagerRequest
    {
        private string _beneficiary;
        private CheckoutType _checkoutType;
        private string _clientToken;
        private List<EntitlementData> _entitlements = new List<EntitlementData>();
        private string _keyFingerprint;
        private string _nodeId;
        private string _productSKU;

        /// <summary>
        /// Gets and sets the property Beneficiary. 
        /// <para>
        /// License beneficiary.
        /// </para>
        /// </summary>
        public string Beneficiary
        {
            get { return this._beneficiary; }
            set { this._beneficiary = value; }
        }

        // Check to see if Beneficiary property is set
        internal bool IsSetBeneficiary()
        {
            return this._beneficiary != null;
        }

        /// <summary>
        /// Gets and sets the property CheckoutType. 
        /// <para>
        /// Checkout type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CheckoutType CheckoutType
        {
            get { return this._checkoutType; }
            set { this._checkoutType = value; }
        }

        // Check to see if CheckoutType property is set
        internal bool IsSetCheckoutType()
        {
            return this._checkoutType != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// License entitlements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EntitlementData> Entitlements
        {
            get { return this._entitlements; }
            set { this._entitlements = value; }
        }

        // Check to see if Entitlements property is set
        internal bool IsSetEntitlements()
        {
            return this._entitlements != null && this._entitlements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyFingerprint. 
        /// <para>
        /// Key fingerprint identifying the license.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KeyFingerprint
        {
            get { return this._keyFingerprint; }
            set { this._keyFingerprint = value; }
        }

        // Check to see if KeyFingerprint property is set
        internal bool IsSetKeyFingerprint()
        {
            return this._keyFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// Node ID.
        /// </para>
        /// </summary>
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductSKU. 
        /// <para>
        /// Product SKU.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductSKU
        {
            get { return this._productSKU; }
            set { this._productSKU = value; }
        }

        // Check to see if ProductSKU property is set
        internal bool IsSetProductSKU()
        {
            return this._productSKU != null;
        }

    }
}