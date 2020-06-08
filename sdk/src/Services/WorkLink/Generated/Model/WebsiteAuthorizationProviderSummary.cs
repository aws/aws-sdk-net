/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// The summary of the website authorization provider.
    /// </summary>
    public partial class WebsiteAuthorizationProviderSummary
    {
        private string _authorizationProviderId;
        private AuthorizationProviderType _authorizationProviderType;
        private DateTime? _createdTime;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property AuthorizationProviderId. 
        /// <para>
        /// A unique identifier for the authorization provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AuthorizationProviderId
        {
            get { return this._authorizationProviderId; }
            set { this._authorizationProviderId = value; }
        }

        // Check to see if AuthorizationProviderId property is set
        internal bool IsSetAuthorizationProviderId()
        {
            return this._authorizationProviderId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationProviderType. 
        /// <para>
        /// The authorization provider type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthorizationProviderType AuthorizationProviderType
        {
            get { return this._authorizationProviderType; }
            set { this._authorizationProviderType = value; }
        }

        // Check to see if AuthorizationProviderType property is set
        internal bool IsSetAuthorizationProviderType()
        {
            return this._authorizationProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time of creation.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the authorization provider. This applies only to SAML-based authorization
        /// providers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}