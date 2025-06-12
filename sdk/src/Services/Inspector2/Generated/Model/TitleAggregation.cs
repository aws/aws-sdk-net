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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The details that define an aggregation based on finding title.
    /// </summary>
    public partial class TitleAggregation
    {
        private AggregationFindingType _findingType;
        private AggregationResourceType _resourceType;
        private TitleSortBy _sortBy;
        private SortOrder _sortOrder;
        private List<StringFilter> _titles = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _vulnerabilityIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The type of finding to aggregate on.
        /// </para>
        /// </summary>
        public AggregationFindingType FindingType
        {
            get { return this._findingType; }
            set { this._findingType = value; }
        }

        // Check to see if FindingType property is set
        internal bool IsSetFindingType()
        {
            return this._findingType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type to aggregate on.
        /// </para>
        /// </summary>
        public AggregationResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value to sort results by.
        /// </para>
        /// </summary>
        public TitleSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort results by.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Titles. 
        /// <para>
        /// The finding titles to aggregate on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Titles
        {
            get { return this._titles; }
            set { this._titles = value; }
        }

        // Check to see if Titles property is set
        internal bool IsSetTitles()
        {
            return this._titles != null && (this._titles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VulnerabilityIds. 
        /// <para>
        /// The vulnerability IDs of the findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> VulnerabilityIds
        {
            get { return this._vulnerabilityIds; }
            set { this._vulnerabilityIds = value; }
        }

        // Check to see if VulnerabilityIds property is set
        internal bool IsSetVulnerabilityIds()
        {
            return this._vulnerabilityIds != null && (this._vulnerabilityIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}