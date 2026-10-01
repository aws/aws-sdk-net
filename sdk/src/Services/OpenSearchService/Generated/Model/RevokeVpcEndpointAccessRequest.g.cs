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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeVpcEndpointAccess operation. Revokes access
    /// to an Amazon OpenSearch Service domain that was provided through an interface VPC
    /// endpoint.
    /// </summary>
    public partial class RevokeVpcEndpointAccessRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The account ID to revoke access from.
        /// </para>
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the OpenSearch Service domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service SP to revoke access from.
        /// </para>
        /// </summary>
        public AWSServicePrincipal Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property ServiceOptions. 
        /// <para>
        /// The options for the service, including the supported Regions for the endpoint access.
        /// </para>
        /// </summary>
        public ServiceOptions ServiceOptions { get; set; }

        /// <summary>
        /// Checks to see if the ServiceOptions property is set.
        /// </summary>
        internal bool IsSetServiceOptions() => this.ServiceOptions != null;
    }
}
