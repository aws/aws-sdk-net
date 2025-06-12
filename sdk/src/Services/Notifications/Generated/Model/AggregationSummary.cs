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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
        private List<SummarizationDimensionOverview> _additionalSummarizationDimensions = AWSConfigs.InitializeCollections ? new List<SummarizationDimensionOverview>() : null;
        private SummarizationDimensionOverview _aggregatedAccounts;
        private List<AggregationKey> _aggregatedBy = AWSConfigs.InitializeCollections ? new List<AggregationKey>() : null;
        private SummarizationDimensionOverview _aggregatedOrganizationalUnits;
        private SummarizationDimensionOverview _aggregatedRegions;
        private int? _eventCount;

        /// <summary>
        /// Gets and sets the property AdditionalSummarizationDimensions. 
        /// <para>
        /// List of additional dimensions used to group and summarize data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizationDimensionOverview> AdditionalSummarizationDimensions
        {
            get { return this._additionalSummarizationDimensions; }
            set { this._additionalSummarizationDimensions = value; }
        }

        // Check to see if AdditionalSummarizationDimensions property is set
        internal bool IsSetAdditionalSummarizationDimensions()
        {
            return this._additionalSummarizationDimensions != null && (this._additionalSummarizationDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AggregatedAccounts. 
        /// <para>
        /// Indicates the Amazon Web Services accounts in the aggregation key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SummarizationDimensionOverview AggregatedAccounts
        {
            get { return this._aggregatedAccounts; }
            set { this._aggregatedAccounts = value; }
        }

        // Check to see if AggregatedAccounts property is set
        internal bool IsSetAggregatedAccounts()
        {
            return this._aggregatedAccounts != null;
        }

        /// <summary>
        /// Gets and sets the property AggregatedBy. 
        /// <para>
        /// Indicates the criteria or rules by which notifications have been grouped together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AggregationKey> AggregatedBy
        {
            get { return this._aggregatedBy; }
            set { this._aggregatedBy = value; }
        }

        // Check to see if AggregatedBy property is set
        internal bool IsSetAggregatedBy()
        {
            return this._aggregatedBy != null && (this._aggregatedBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AggregatedOrganizationalUnits. 
        /// <para>
        /// Indicates the collection of organizational units that are involved in the aggregation
        /// key.
        /// </para>
        /// </summary>
        public SummarizationDimensionOverview AggregatedOrganizationalUnits
        {
            get { return this._aggregatedOrganizationalUnits; }
            set { this._aggregatedOrganizationalUnits = value; }
        }

        // Check to see if AggregatedOrganizationalUnits property is set
        internal bool IsSetAggregatedOrganizationalUnits()
        {
            return this._aggregatedOrganizationalUnits != null;
        }

        /// <summary>
        /// Gets and sets the property AggregatedRegions. 
        /// <para>
        /// Indicates the Amazon Web Services Regions in the aggregation key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SummarizationDimensionOverview AggregatedRegions
        {
            get { return this._aggregatedRegions; }
            set { this._aggregatedRegions = value; }
        }

        // Check to see if AggregatedRegions property is set
        internal bool IsSetAggregatedRegions()
        {
            return this._aggregatedRegions != null;
        }

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// Indicates the number of events associated with the aggregation key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EventCount
        {
            get { return this._eventCount; }
            set { this._eventCount = value; }
        }

        // Check to see if EventCount property is set
        internal bool IsSetEventCount()
        {
            return this._eventCount.HasValue; 
        }

    }
}