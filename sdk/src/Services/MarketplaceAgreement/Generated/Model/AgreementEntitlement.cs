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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
        private string _licenseArn;
        private string _registrationToken;
        private Resource _resource;
        private AgreementEntitlementStatus _status;
        private AgreementEntitlementStatusReasonCode _statusReasonCode;
        private string _type;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS License Manager license associated with
        /// the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property RegistrationToken. 
        /// <para>
        /// A short-lived token required by acceptors to register their account with the product
        /// provider. The token is only valid for 30 minutes after creation and is only applicable
        /// for purchase agreements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RegistrationToken
        {
            get { return this._registrationToken; }
            set { this._registrationToken = value; }
        }

        // Check to see if RegistrationToken property is set
        internal bool IsSetRegistrationToken()
        {
            return this._registrationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource that the entitlement is provisioned to, such as a product.
        /// </para>
        /// </summary>
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of an entitlement.
        /// </para>
        /// </summary>
        public AgreementEntitlementStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReasonCode. 
        /// <para>
        /// Provides more information about the status of an entitlement.
        /// </para>
        /// </summary>
        public AgreementEntitlementStatusReasonCode StatusReasonCode
        {
            get { return this._statusReasonCode; }
            set { this._statusReasonCode = value; }
        }

        // Check to see if StatusReasonCode property is set
        internal bool IsSetStatusReasonCode()
        {
            return this._statusReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}