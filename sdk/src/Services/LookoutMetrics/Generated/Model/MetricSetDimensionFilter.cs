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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Describes a list of filters for choosing a subset of dimension values. Each filter
    /// consists of the dimension and one of its values that you want to include. When multiple
    /// dimensions or values are specified, the dimensions are joined with an AND operation
    /// and the values are joined with an OR operation.
    /// </summary>
    public partial class MetricSetDimensionFilter
    {
        private List<Filter> _filterList = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property FilterList. 
        /// <para>
        /// The list of filters that you are applying.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Filter> FilterList
        {
            get { return this._filterList; }
            set { this._filterList = value; }
        }

        // Check to see if FilterList property is set
        internal bool IsSetFilterList()
        {
            return this._filterList != null && (this._filterList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The dimension that you want to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}