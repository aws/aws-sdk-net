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

namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// Container for the parameters to the GetRevenueAttributionAllocation operation. Retrieves
    /// a single allocation by its RevenueAttributionAllocationId. Supports optional point-in-time
    /// version queries.
    /// </summary>
    public partial class GetRevenueAttributionAllocationRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that contains the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogName Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionAllocationId. 
        /// <para>
        /// The allocation identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string RevenueAttributionAllocationId { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionAllocationId property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionAllocationId() => this.RevenueAttributionAllocationId != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionIdentifier. 
        /// <para>
        /// The revenue attribution identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1011)]
        public string RevenueAttributionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionIdentifier property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionIdentifier() => this.RevenueAttributionIdentifier != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionRevision. 
        /// <para>
        /// Point-in-time revision number to query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string RevenueAttributionRevision { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionRevision property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionRevision() => this.RevenueAttributionRevision != null;
    }
}
