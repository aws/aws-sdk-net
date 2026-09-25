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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// This is the response object from the CreateAccountAssociation operation.
    /// </summary>
    public partial class CreateAccountAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier for the account association request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AccountAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AccountAssociationId property is set.
        /// </summary>
        internal bool IsSetAccountAssociationId() => this.AccountAssociationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 67, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The current state of the account association request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationState AssociationState { get; set; }

        /// <summary>
        /// Checks to see if the AssociationState property is set.
        /// </summary>
        internal bool IsSetAssociationState() => this.AssociationState != null;

        /// <summary>
        /// Gets and sets the property OAuthAuthorizationUrl. 
        /// <para>
        /// Third-party IoT platform OAuth authorization server URL backed with all the required
        /// parameters to perform end-user authentication. This field will be empty when using
        /// General Authorization flows that do not require OAuth.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 1024)]
        public string OAuthAuthorizationUrl { get; set; }

        /// <summary>
        /// Checks to see if the OAuthAuthorizationUrl property is set.
        /// </summary>
        internal bool IsSetOAuthAuthorizationUrl() => this.OAuthAuthorizationUrl != null;
    }
}
