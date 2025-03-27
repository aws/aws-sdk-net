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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
    /// This is the response object from the CreateUserPoolDomain operation.
    /// </summary>
    public partial class CreateUserPoolDomainResponse : AmazonWebServiceResponse
    {
        private string _cloudFrontDomain;
        private int? _managedLoginVersion;

        /// <summary>
        /// Gets and sets the property CloudFrontDomain. 
        /// <para>
        /// The fully-qualified domain name (FQDN) of the Amazon CloudFront distribution that
        /// hosts your managed login or classic hosted UI pages. Your domain-name authority must
        /// have an alias record that points requests for your custom domain to this FQDN. Amazon
        /// Cognito returns this value if you set a custom domain with <c>CustomDomainConfig</c>.
        /// If you set an Amazon Cognito prefix domain, this parameter returns null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string CloudFrontDomain
        {
            get { return this._cloudFrontDomain; }
            set { this._cloudFrontDomain = value; }
        }

        // Check to see if CloudFrontDomain property is set
        internal bool IsSetCloudFrontDomain()
        {
            return this._cloudFrontDomain != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedLoginVersion. 
        /// <para>
        /// The version of managed login branding applied your domain. A value of <c>1</c> indicates
        /// hosted UI (classic) and a version of <c>2</c> indicates managed login.
        /// </para>
        /// </summary>
        public int? ManagedLoginVersion
        {
            get { return this._managedLoginVersion; }
            set { this._managedLoginVersion = value; }
        }

        // Check to see if ManagedLoginVersion property is set
        internal bool IsSetManagedLoginVersion()
        {
            return this._managedLoginVersion.HasValue; 
        }

    }
}