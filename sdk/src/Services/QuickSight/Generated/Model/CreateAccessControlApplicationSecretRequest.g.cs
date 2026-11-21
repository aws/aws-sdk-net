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
    /// Container for the parameters to the CreateAccessControlApplicationSecret operation.
    /// Creates a client secret for an access control application. An access control application
    /// can have up to two client secrets, so that you can rotate a secret without downtime.
    /// <para> Provide the Amazon Web Services Secrets Manager (Secrets Manager) secret ARN
    /// for each Region where the client secret, issued by your identity provider (IdP), is
    /// stored. </para>
    /// </summary>
    public partial class CreateAccessControlApplicationSecretRequest : AmazonQuickSightRequest
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
        /// Gets and sets the property ClientSecretConfiguration. 
        /// <para>
        /// The source of the client secret, which is your IdP, and the Amazon Web Services Secrets
        /// Manager ARNs of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientSecretConfiguration ClientSecretConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretConfiguration property is set.
        /// </summary>
        internal bool IsSetClientSecretConfiguration() => this.ClientSecretConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the client secret, for example <c>rotation-june-2026</c>. If you
        /// don't provide a description, the client secret has no description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
