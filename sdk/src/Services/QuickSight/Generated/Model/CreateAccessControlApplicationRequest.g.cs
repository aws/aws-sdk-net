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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessControlApplication operation. Creates
    /// an access control application in an Amazon Quick Sight account. You use an access
    /// control application to define how an external client signs in to Quick Sight with
    /// OAuth 2.0. <para> To connect a client to Quick Sight through an inbound connector,
    /// associate the access control application with the connector by using the <c>UpdateInboundConnectorApplicationAssociations</c>
    /// operation. </para>
    /// </summary>
    public partial class CreateAccessControlApplicationRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID for the access control application. This ID is unique per Amazon Web Services
        /// Region for each Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Quick Sight reserves IDs that start with <c>quick-aca-</c> for the access control
        /// application of the Quick Sight desktop application. To create one, the ID must be
        /// <c>quick-aca-</c> followed by your Amazon Web Services account ID and the namespace,
        /// separated by a hyphen. For example, <c>quick-aca-111122223333-default</c>. In addition,
        /// <c>QuickAuthenticationType</c> must be <c>QUICK_MANAGED_PUBLIC_AUTH_CODE</c> with
        /// <c>http://localhost:18080</c> as the only redirect URI, and <c>IdpAuthorizingType</c>
        /// must be <c>IDC_AUTH_CODE</c> or <c>QUICK_MANAGED_AUTH_CODE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication protocol that the access control application uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessControlApplicationAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the Quick Sight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IdpAuthorizingConfiguration. 
        /// <para>
        /// The identity provider configuration of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdpAuthorizingConfigInput IdpAuthorizingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdpAuthorizingConfiguration property is set.
        /// </summary>
        internal bool IsSetIdpAuthorizingConfiguration() => this.IdpAuthorizingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Quick Sight namespace for the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property QuickAuthenticationConfiguration. 
        /// <para>
        /// The Quick Sight authentication configuration of the access control application. You
        /// provide redirect URIs, and Quick Sight generates the client ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QuickAuthenticationConfigInput QuickAuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QuickAuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetQuickAuthenticationConfiguration() => this.QuickAuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the access control application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
