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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceConfigurations operation. Lists the
    /// resource configurations owned by or shared with this account.
    /// </summary>
    public partial class ListResourceConfigurationsRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property DomainVerificationIdentifier. 
        /// <para>
        ///  The domain verification ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DomainVerificationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainVerificationIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainVerificationIdentifier() => this.DomainVerificationIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationGroupIdentifier. 
        /// <para>
        /// The ID of the resource configuration of type <c>Group</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceConfigurationGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationGroupIdentifier() => this.ResourceConfigurationGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceGatewayIdentifier. 
        /// <para>
        /// The ID of the resource gateway for the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 17, Max = 2048)]
        public string ResourceGatewayIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGatewayIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceGatewayIdentifier() => this.ResourceGatewayIdentifier != null;
    }
}
