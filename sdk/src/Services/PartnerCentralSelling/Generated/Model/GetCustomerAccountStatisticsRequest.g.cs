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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the GetCustomerAccountStatistics operation. Use <c>GetCustomerAccountStatistics</c>
    /// to count your customer accounts and group them by fields such as industry, geography,
    /// or enrichment status. You can use the same filters as <c>SearchCustomerAccounts</c>.
    /// </summary>
    public partial class GetCustomerAccountStatisticsRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Aggregations. 
        /// <para>
        /// Specifies how to group the customer accounts. Each aggregation returns the number
        /// of accounts for each value of a field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<AggregationRequest> Aggregations { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregationRequest>() : null;

        /// <summary>
        /// Checks to see if the Aggregations property is set.
        /// </summary>
        internal bool IsSetAggregations() => this.Aggregations != null && (this.Aggregations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog for the request. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c>: Production.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sandbox</c>: Testing environments.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies a filter tree that narrows the customer accounts. Each node either combines
        /// child filters or compares a single field to a value. If you omit this field, the statistics
        /// cover all of your customer accounts.
        /// </para>
        /// </summary>
        public Filter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property IncludeMissing. 
        /// <para>
        /// Specifies whether to include a group for customer accounts that have no value for
        /// the grouped field.
        /// </para>
        /// </summary>
        public bool? IncludeMissing { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMissing property is set.
        /// </summary>
        internal bool IsSetIncludeMissing() => this.IncludeMissing.HasValue;
    }
}
