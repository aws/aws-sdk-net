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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// This is the response object from the UpdateUserPoolDomain operation.
    /// </summary>
    public partial class UpdateUserPoolDomainResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CloudFrontDomain. 
        /// <para>
        /// The fully-qualified domain name (FQDN) of the Amazon CloudFront distribution that
        /// hosts your managed login or classic hosted UI pages. You domain-name authority must
        /// have an alias record that points requests for your custom domain to this FQDN. Amazon
        /// Cognito returns this value if you set a custom domain with <c>CustomDomainConfig</c>.
        /// If you set an Amazon Cognito prefix domain, this operation returns a blank response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string CloudFrontDomain { get; set; }

        /// <summary>
        /// Checks to see if the CloudFrontDomain property is set.
        /// </summary>
        internal bool IsSetCloudFrontDomain() => this.CloudFrontDomain != null;

        /// <summary>
        /// Gets and sets the property ManagedLoginVersion. 
        /// <para>
        /// A version number that indicates the state of managed login for your domain. Version
        /// <c>1</c> is hosted UI (classic). Version <c>2</c> is the newer managed login with
        /// the branding editor. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html">Managed
        /// login</a>.
        /// </para>
        /// </summary>
        public int? ManagedLoginVersion { get; set; }

        /// <summary>
        /// Checks to see if the ManagedLoginVersion property is set.
        /// </summary>
        internal bool IsSetManagedLoginVersion() => this.ManagedLoginVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Routing. 
        /// <para>
        /// The updated routing configuration for the user pool domain.
        /// </para>
        /// </summary>
        public RoutingType Routing { get; set; }

        /// <summary>
        /// Checks to see if the Routing property is set.
        /// </summary>
        internal bool IsSetRouting() => this.Routing != null;
    }
}
