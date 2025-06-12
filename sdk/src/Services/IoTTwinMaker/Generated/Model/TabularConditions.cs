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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The tabular conditions.
    /// </summary>
    public partial class TabularConditions
    {
        private List<OrderBy> _orderBy = AWSConfigs.InitializeCollections ? new List<OrderBy>() : null;
        private List<PropertyFilter> _propertyFilters = AWSConfigs.InitializeCollections ? new List<PropertyFilter>() : null;

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Filter criteria that orders the output. It can be sorted in ascending or descending
        /// order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<OrderBy> OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null && (this._orderBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PropertyFilters. 
        /// <para>
        /// You can filter the request using various logical operators and a key-value format.
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"key": "serverType", "value": "webServer"}</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<PropertyFilter> PropertyFilters
        {
            get { return this._propertyFilters; }
            set { this._propertyFilters = value; }
        }

        // Check to see if PropertyFilters property is set
        internal bool IsSetPropertyFilters()
        {
            return this._propertyFilters != null && (this._propertyFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}