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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSocialConnectionAuthorizationUrl operation.
    /// Creates a single-use URL the partner visits to authorize publishing on a platform.
    /// Serves a first connect, connecting a further account, and re-authorizing an expired
    /// one: consenting with an account that is already connected re-authorizes that connection
    /// and keeps its id; any other account adds a connection. Poll ListSocialConnections
    /// for the outcome. Deliberately not idempotent and takes no client token: every call
    /// must mint a fresh single-use URL, so replaying a cached response would hand back a
    /// dead one.
    /// </summary>
    public partial class CreateSocialConnectionAuthorizationUrlRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. Catalog the connection belongs to.
        /// </summary>
        [AWSProperty(Required = true)]
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Platform. Social platform to authorize.
        /// </summary>
        [AWSProperty(Required = true)]
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;
    }
}
