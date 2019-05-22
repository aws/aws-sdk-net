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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateWebsiteAuthorizationProvider operation.
    /// Associates a website authorization provider with a specified fleet. This is used to
    /// authorize users against associated websites in the company network.
    /// </summary>
    public partial class AssociateWebsiteAuthorizationProviderRequest : AmazonWorkLinkRequest
    {
        private AuthorizationProviderType _authorizationProviderType;
        private string _domainName;
        private string _fleetArn;

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

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The ARN of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

    }
}