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

namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannelContracts operation. Lists channel
    /// contracts based on specified criteria.
    /// </summary>
    public partial class ListChannelContractsRequest : AmazonPartnerCentralChannelRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier to filter channel contracts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ContractType. 
        /// <para>
        /// Filter results by contract type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelContractType ContractType { get; set; }

        /// <summary>
        /// Checks to see if the ContractType property is set.
        /// </summary>
        internal bool IsSetContractType() => this.ContractType != null;

        /// <summary>
        /// Gets and sets the property ContractTypeFilters. 
        /// <para>
        /// Type-specific filters for channel contracts.
        /// </para>
        /// </summary>
        public ListChannelContractsTypeFilters ContractTypeFilters { get; set; }

        /// <summary>
        /// Checks to see if the ContractTypeFilters property is set.
        /// </summary>
        internal bool IsSetContractTypeFilters() => this.ContractTypeFilters != null;

        /// <summary>
        /// Gets and sets the property ContractTypeSort. 
        /// <para>
        /// Type-specific sorting options for channel contracts.
        /// </para>
        /// </summary>
        public ListChannelContractsTypeSort ContractTypeSort { get; set; }

        /// <summary>
        /// Checks to see if the ContractTypeSort property is set.
        /// </summary>
        internal bool IsSetContractTypeSort() => this.ContractTypeSort != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
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
        /// Token for retrieving the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// Filter results by channel contract status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Statuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Statuses property is set.
        /// </summary>
        internal bool IsSetStatuses() => this.Statuses != null && (this.Statuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
