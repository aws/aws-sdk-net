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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLicenseServerEndpoint operation. Creates
    /// a network endpoint for the Remote Desktop Services (RDS) license server.
    /// </summary>
    public partial class CreateLicenseServerEndpointRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the <c>IdentityProvider</c> resource
        /// that contains details about a registered identity provider. In the case of Active
        /// Directory, that can be a self-managed Active Directory or an Amazon Web Services Managed
        /// Active Directory that contains user identity details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IdentityProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderArn property is set.
        /// </summary>
        internal bool IsSetIdentityProviderArn() => this.IdentityProviderArn != null;

        /// <summary>
        /// Gets and sets the property LicenseServerSettings. 
        /// <para>
        /// The <c>LicenseServerSettings</c> resource to create for the endpoint. The settings
        /// include the type of license server and the Secrets Manager secret that enables administrators
        /// to add or remove users associated with the license server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LicenseServerSettings LicenseServerSettings { get; set; }

        /// <summary>
        /// Checks to see if the LicenseServerSettings property is set.
        /// </summary>
        internal bool IsSetLicenseServerSettings() => this.LicenseServerSettings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply for the license server endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
