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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The aggregation for an attribute.
    /// </summary>
    public partial class AggregationOutput
    {
        private string _attribute;
        private string _displayValue;
        private List<AggregationOutputItem> _items = AWSConfigs.InitializeCollections ? new List<AggregationOutputItem>() : null;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The attribute for this aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayValue. 
        /// <para>
        /// The display value of the aggregation output item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayValue
        {
            get { return this._displayValue; }
            set { this._displayValue = value; }
        }

        // Check to see if DisplayValue property is set
        internal bool IsSetDisplayValue()
        {
            return this._displayValue != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A list of aggregation output items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AggregationOutputItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}