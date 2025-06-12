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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
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
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of the line item filter for your custom line item. You can use line
    /// item filters to include or exclude specific resource values from the billing group's
    /// total cost. For example, if you create a custom line item and you want to filter out
    /// a value, such as Savings Plan discounts, you can update <c>LineItemFilter</c> to exclude
    /// it.
    /// </summary>
    public partial class LineItemFilter
    {
        private LineItemFilterAttributeName _attribute;
        private MatchOption _matchOption;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The attribute of the line item filter. This specifies what attribute that you can
        /// filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LineItemFilterAttributeName Attribute
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
        /// Gets and sets the property MatchOption. 
        /// <para>
        /// The match criteria of the line item filter. This parameter specifies whether not to
        /// include the resource value from the billing group total cost.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MatchOption MatchOption
        {
            get { return this._matchOption; }
            set { this._matchOption = value; }
        }

        // Check to see if MatchOption property is set
        internal bool IsSetMatchOption()
        {
            return this._matchOption != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the line item filter. This specifies the values to filter on. Currently,
        /// you can only exclude Savings Plan discounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}