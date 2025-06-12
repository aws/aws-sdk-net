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
    /// Container for the parameters to the CheckoutBorrowLicense operation.
    /// Checks out the specified license for offline use.
    /// </summary>
    public partial class CheckoutBorrowLicenseRequest : AmazonLicenseManagerRequest
    {
        private List<Metadata> _checkoutMetadata = AWSConfigs.InitializeCollections ? new List<Metadata>() : null;
        private string _clientToken;
        private DigitalSignatureMethod _digitalSignatureMethod;
        private List<EntitlementData> _entitlements = AWSConfigs.InitializeCollections ? new List<EntitlementData>() : null;
        private string _licenseArn;
        private string _nodeId;

        /// <summary>
        /// Gets and sets the property CheckoutMetadata. 
        /// <para>
        /// Information about constraints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Metadata> CheckoutMetadata
        {
            get { return this._checkoutMetadata; }
            set { this._checkoutMetadata = value; }
        }

        // Check to see if CheckoutMetadata property is set
        internal bool IsSetCheckoutMetadata()
        {
            return this._checkoutMetadata != null && (this._checkoutMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
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
        /// Gets and sets the property DigitalSignatureMethod. 
        /// <para>
        /// Digital signature method. The possible value is JSON Web Signature (JWS) algorithm
        /// PS384. For more information, see <a href="https://tools.ietf.org/html/rfc7518#section-3.5">RFC
        /// 7518 Digital Signature with RSASSA-PSS</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DigitalSignatureMethod DigitalSignatureMethod
        {
            get { return this._digitalSignatureMethod; }
            set { this._digitalSignatureMethod = value; }
        }

        // Check to see if DigitalSignatureMethod property is set
        internal bool IsSetDigitalSignatureMethod()
        {
            return this._digitalSignatureMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// License entitlements. Partial checkouts are not supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._entitlements != null && (this._entitlements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license. The license must use the borrow consumption
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
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

    }
}