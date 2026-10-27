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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Represents an entitlement associated with an agreement, including the provisioning
    /// status, resource, and type.
    /// </summary>
    public partial class AgreementEntitlement
    {
        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS License Manager license associated with
        /// the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property RegistrationToken. 
        /// <para>
        /// A short-lived token required by acceptors to register their account with the product
        /// provider. The token is only valid for 30 minutes after creation and is only applicable
        /// for purchase agreements.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string RegistrationToken { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationToken property is set.
        /// </summary>
        internal bool IsSetRegistrationToken() => this.RegistrationToken != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource that the entitlement is provisioned to, such as a product.
        /// </para>
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of an entitlement.
        /// </para>
        /// </summary>
        public AgreementEntitlementStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReasonCode. 
        /// <para>
        /// Provides more information about the status of an entitlement.
        /// </para>
        /// </summary>
        public AgreementEntitlementStatusReasonCode StatusReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusReasonCode property is set.
        /// </summary>
        internal bool IsSetStatusReasonCode() => this.StatusReasonCode != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
