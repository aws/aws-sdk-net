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
    /// Container for the parameters to the CheckoutBorrowLicense operation. Checks out the
    /// specified license for offline use.
    /// </summary>
    public partial class CheckoutBorrowLicenseRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property CheckoutMetadata. 
        /// <para>
        /// Information about constraints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Metadata> CheckoutMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<Metadata>() : null;

        /// <summary>
        /// Checks to see if the CheckoutMetadata property is set.
        /// </summary>
        internal bool IsSetCheckoutMetadata() => this.CheckoutMetadata != null && (this.CheckoutMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property DigitalSignatureMethod. 
        /// <para>
        /// Digital signature method. The possible value is JSON Web Signature (JWS) algorithm
        /// PS384. For more information, see <a href="https://tools.ietf.org/html/rfc7518#section-3.5">RFC
        /// 7518 Digital Signature with RSASSA-PSS</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DigitalSignatureMethod DigitalSignatureMethod { get; set; }

        /// <summary>
        /// Checks to see if the DigitalSignatureMethod property is set.
        /// </summary>
        internal bool IsSetDigitalSignatureMethod() => this.DigitalSignatureMethod != null;

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// License entitlements. Partial checkouts are not supported.
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
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license. The license must use the borrow consumption
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

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
    }
}
