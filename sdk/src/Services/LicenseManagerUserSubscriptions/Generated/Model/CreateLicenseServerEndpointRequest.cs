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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLicenseServerEndpoint operation.
    /// Creates a network endpoint for the Remote Desktop Services (RDS) license server.
    /// </summary>
    public partial class CreateLicenseServerEndpointRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        private string _identityProviderArn;
        private LicenseServerSettings _licenseServerSettings;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the <c>IdentityProvider</c> resource
        /// that contains details about a registered identity provider. In the case of Active
        /// Directory, that can be a self-managed Active Directory or an Amazon Web Services Managed
        /// Active Directory that contains user identity details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityProviderArn
        {
            get { return this._identityProviderArn; }
            set { this._identityProviderArn = value; }
        }

        // Check to see if IdentityProviderArn property is set
        internal bool IsSetIdentityProviderArn()
        {
            return this._identityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseServerSettings. 
        /// <para>
        /// The <c>LicenseServerSettings</c> resource to create for the endpoint. The settings
        /// include the type of license server and the Secrets Manager secret that enables administrators
        /// to add or remove users associated with the license server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LicenseServerSettings LicenseServerSettings
        {
            get { return this._licenseServerSettings; }
            set { this._licenseServerSettings = value; }
        }

        // Check to see if LicenseServerSettings property is set
        internal bool IsSetLicenseServerSettings()
        {
            return this._licenseServerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply for the license server endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}