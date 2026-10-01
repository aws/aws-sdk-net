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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the GetOutpostSupportedInstanceTypes operation. Gets
    /// the instance types that an Outpost can support in <c>InstanceTypeCapacity</c>. This
    /// will generally include instance types that are not currently configured and therefore
    /// cannot be launched with the current Outpost capacity configuration.
    /// </summary>
    public partial class GetOutpostSupportedInstanceTypesRequest : AmazonOutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the Outpost asset. An Outpost asset can be a single server within an Outposts
        /// rack or an Outposts server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// The ID for the Amazon Web Services Outposts order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string OrderId { get; set; }

        /// <summary>
        /// Checks to see if the OrderId property is set.
        /// </summary>
        internal bool IsSetOrderId() => this.OrderId != null;

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 180)]
        public string OutpostIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OutpostIdentifier property is set.
        /// </summary>
        internal bool IsSetOutpostIdentifier() => this.OutpostIdentifier != null;
    }
}
