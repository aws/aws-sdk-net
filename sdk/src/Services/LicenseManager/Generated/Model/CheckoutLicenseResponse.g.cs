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
    /// This is the response object from the CheckoutLicense operation.
    /// </summary>
    public partial class CheckoutLicenseResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CheckoutType. 
        /// <para>
        /// Checkout type.
        /// </para>
        /// </summary>
        public CheckoutType CheckoutType { get; set; }

        /// <summary>
        /// Checks to see if the CheckoutType property is set.
        /// </summary>
        internal bool IsSetCheckoutType() => this.CheckoutType != null;

        /// <summary>
        /// Gets and sets the property EntitlementsAllowed. 
        /// <para>
        /// Allowed license entitlements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntitlementData> EntitlementsAllowed { get; set; } = AWSConfigs.InitializeCollections ? new List<EntitlementData>() : null;

        /// <summary>
        /// Checks to see if the EntitlementsAllowed property is set.
        /// </summary>
        internal bool IsSetEntitlementsAllowed() => this.EntitlementsAllowed != null && (this.EntitlementsAllowed.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// Date and time at which the license checkout expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration != null;

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// Date and time at which the license checkout is issued.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt != null;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the checkout license.
        /// </para>
        /// </summary>
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property LicenseConsumptionToken. 
        /// <para>
        /// License consumption token.
        /// </para>
        /// </summary>
        public string LicenseConsumptionToken { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConsumptionToken property is set.
        /// </summary>
        internal bool IsSetLicenseConsumptionToken() => this.LicenseConsumptionToken != null;

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
        /// Gets and sets the property SignedToken. 
        /// <para>
        /// Signed token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4096)]
        public string SignedToken { get; set; }

        /// <summary>
        /// Checks to see if the SignedToken property is set.
        /// </summary>
        internal bool IsSetSignedToken() => this.SignedToken != null;
    }
}
