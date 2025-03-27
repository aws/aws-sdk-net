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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// This is the response object from the CreateProvisioningProfile operation.
    /// </summary>
    public partial class CreateProvisioningProfileResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _claimCertificate;
        private string _claimCertificatePrivateKey;
        private string _id;
        private string _name;
        private ProvisioningType _provisioningType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the provisioning template used in the provisioning
        /// profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClaimCertificate. 
        /// <para>
        /// The id of the claim certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ClaimCertificate
        {
            get { return this._claimCertificate; }
            set { this._claimCertificate = value; }
        }

        // Check to see if ClaimCertificate property is set
        internal bool IsSetClaimCertificate()
        {
            return this._claimCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ClaimCertificatePrivateKey. 
        /// <para>
        /// The private key of the claim certificate. This is stored securely on the device for
        /// validating the connection endpoint with IoT managed integrations using the public
        /// key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ClaimCertificatePrivateKey
        {
            get { return this._claimCertificatePrivateKey; }
            set { this._claimCertificatePrivateKey = value; }
        }

        // Check to see if ClaimCertificatePrivateKey property is set
        internal bool IsSetClaimCertificatePrivateKey()
        {
            return this._claimCertificatePrivateKey != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the provisioning profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningType. 
        /// <para>
        /// The type of provisioning workflow the device uses for onboarding to IoT managed integrations.
        /// </para>
        /// </summary>
        public ProvisioningType ProvisioningType
        {
            get { return this._provisioningType; }
            set { this._provisioningType = value; }
        }

        // Check to see if ProvisioningType property is set
        internal bool IsSetProvisioningType()
        {
            return this._provisioningType != null;
        }

    }
}