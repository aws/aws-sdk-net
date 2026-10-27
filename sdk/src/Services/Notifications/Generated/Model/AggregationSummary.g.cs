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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Provides additional information about the aggregation key.
    /// </summary>
    public partial class AggregationSummary
    {
        /// <summary>
        /// Gets and sets the property AdditionalSummarizationDimensions. 
        /// <para>
        /// List of additional dimensions used to group and summarize data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizationDimensionOverview> AdditionalSummarizationDimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<SummarizationDimensionOverview>() : null;

        /// <summary>
        /// Checks to see if the AdditionalSummarizationDimensions property is set.
        /// </summary>
        internal bool IsSetAdditionalSummarizationDimensions() => this.AdditionalSummarizationDimensions != null && (this.AdditionalSummarizationDimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AggregatedAccounts. 
        /// <para>
        /// Indicates the Amazon Web Services accounts in the aggregation key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SummarizationDimensionOverview AggregatedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedAccounts property is set.
        /// </summary>
        internal bool IsSetAggregatedAccounts() => this.AggregatedAccounts != null;

        /// <summary>
        /// Gets and sets the property AggregatedBy. 
        /// <para>
        /// Indicates the criteria or rules by which notifications have been grouped together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AggregationKey> AggregatedBy { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregationKey>() : null;

        /// <summary>
        /// Checks to see if the AggregatedBy property is set.
        /// </summary>
        internal bool IsSetAggregatedBy() => this.AggregatedBy != null && (this.AggregatedBy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AggregatedOrganizationalUnits. 
        /// <para>
        /// Indicates the collection of organizational units that are involved in the aggregation
        /// key.
        /// </para>
        /// </summary>
        public SummarizationDimensionOverview AggregatedOrganizationalUnits { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedOrganizationalUnits property is set.
        /// </summary>
        internal bool IsSetAggregatedOrganizationalUnits() => this.AggregatedOrganizationalUnits != null;

        /// <summary>
        /// Gets and sets the property AggregatedRegions. 
        /// <para>
        /// Indicates the Amazon Web Services Regions in the aggregation key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SummarizationDimensionOverview AggregatedRegions { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedRegions property is set.
        /// </summary>
        internal bool IsSetAggregatedRegions() => this.AggregatedRegions != null;

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// Indicates the number of events associated with the aggregation key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EventCount { get; set; }

        /// <summary>
        /// Checks to see if the EventCount property is set.
        /// </summary>
        internal bool IsSetEventCount() => this.EventCount.HasValue;
    }
}
