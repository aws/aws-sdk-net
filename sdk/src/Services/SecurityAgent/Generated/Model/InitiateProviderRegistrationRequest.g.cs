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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateProviderRegistration operation. Initiates
    /// the OAuth registration flow with a third-party provider. Returns a redirect URL and
    /// CSRF state token for completing the authorization.
    /// </summary>
    public partial class InitiateProviderRegistrationRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID of the OAuth application registered on your self-managed provider instance.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret of the OAuth application registered on your self-managed provider
        /// instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// The name of the organization to connect.
        /// </para>
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationName property is set.
        /// </summary>
        internal bool IsSetOrganizationName() => this.OrganizationName != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider to initiate registration with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// The HTTPS URL of a self-managed provider instance. Omit for SaaS providers.
        /// </para>
        /// </summary>
        public string TargetUrl { get; set; }

        /// <summary>
        /// Checks to see if the TargetUrl property is set.
        /// </summary>
        internal bool IsSetTargetUrl() => this.TargetUrl != null;
    }
}
