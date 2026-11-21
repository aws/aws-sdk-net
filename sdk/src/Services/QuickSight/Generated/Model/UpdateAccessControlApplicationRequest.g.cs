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
    /// Container for the parameters to the UpdateAccessControlApplication operation. Updates
    /// an access control application. You can change its name, description, status, IdP settings
    /// such as the client ID and issuer URL, and its Quick Sight authentication settings
    /// such as redirect URIs. <para> You can't change the <c>IdpAuthorizingType</c>, the
    /// <c>QuickAuthenticationType</c>, or the trusted token issuer after the application
    /// is created. To manage client secrets, use <c>CreateAccessControlApplicationSecret</c>,
    /// <c>UpdateAccessControlApplicationSecret</c>, and <c>DeleteAccessControlApplicationSecret</c>.
    /// </para>
    /// </summary>
    public partial class UpdateAccessControlApplicationRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

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
        /// The new description of the access control application.
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
        /// The identity provider settings to update, such as the client ID and issuer URL. You
        /// can't change the <c>IdpAuthorizingType</c> or the trusted token issuer. To manage
        /// client secrets, use the client secret operations.
        /// </para>
        /// </summary>
        public IdpAuthorizingConfigUpdateInput IdpAuthorizingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdpAuthorizingConfiguration property is set.
        /// </summary>
        internal bool IsSetIdpAuthorizingConfiguration() => this.IdpAuthorizingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QuickAuthenticationConfiguration. 
        /// <para>
        /// The Quick Sight authentication settings to update, such as redirect URIs. You can't
        /// change the <c>QuickAuthenticationType</c>.
        /// </para>
        /// </summary>
        public QuickAuthenticationConfigInput QuickAuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QuickAuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetQuickAuthenticationConfiguration() => this.QuickAuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status of the access control application.
        /// </para>
        /// </summary>
        public AccessControlApplicationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
