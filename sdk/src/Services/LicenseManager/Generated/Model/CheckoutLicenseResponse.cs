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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the CheckoutLicense operation.
    /// </summary>
    public partial class CheckoutLicenseResponse : AmazonWebServiceResponse
    {
        private CheckoutType _checkoutType;
        private List<EntitlementData> _entitlementsAllowed = AWSConfigs.InitializeCollections ? new List<EntitlementData>() : null;
        private string _expiration;
        private string _issuedAt;
        private string _licenseArn;
        private string _licenseConsumptionToken;
        private string _nodeId;
        private string _signedToken;

        /// <summary>
        /// Gets and sets the property CheckoutType. 
        /// <para>
        /// Checkout type.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EntitlementsAllowed. 
        /// <para>
        /// Allowed license entitlements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntitlementData> EntitlementsAllowed
        {
            get { return this._entitlementsAllowed; }
            set { this._entitlementsAllowed = value; }
        }

        // Check to see if EntitlementsAllowed property is set
        internal bool IsSetEntitlementsAllowed()
        {
            return this._entitlementsAllowed != null && (this._entitlementsAllowed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// Date and time at which the license checkout expires.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// Date and time at which the license checkout is issued.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string IssuedAt
        {
            get { return this._issuedAt; }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the checkout license.
        /// </para>
        /// </summary>
        public string LicenseArn
        {
            get { return this._licenseArn; }
            set { this._licenseArn = value; }
        }

        // Check to see if LicenseArn property is set
        internal bool IsSetLicenseArn()
        {
            return this._licenseArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConsumptionToken. 
        /// <para>
        /// License consumption token.
        /// </para>
        /// </summary>
        public string LicenseConsumptionToken
        {
            get { return this._licenseConsumptionToken; }
            set { this._licenseConsumptionToken = value; }
        }

        // Check to see if LicenseConsumptionToken property is set
        internal bool IsSetLicenseConsumptionToken()
        {
            return this._licenseConsumptionToken != null;
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
        /// Gets and sets the property SignedToken. 
        /// <para>
        /// Signed token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4096)]
        public string SignedToken
        {
            get { return this._signedToken; }
            set { this._signedToken = value; }
        }

        // Check to see if SignedToken property is set
        internal bool IsSetSignedToken()
        {
            return this._signedToken != null;
        }

    }
}