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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
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
namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// Contains information on a promotion. A promotion defines additional business rules
    /// that apply to a configurable subset of recommended items.
    /// </summary>
    public partial class Promotion
    {
        private string _filterArn;
        private Dictionary<string, string> _filterValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _name;
        private int? _percentPromotedItems;

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the filter used by the promotion. This filter defines
        /// the criteria for promoted items. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/promoting-items.html#promotion-filters">Promotion
        /// filters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FilterArn
        {
            get { return this._filterArn; }
            set { this._filterArn = value; }
        }

        // Check to see if FilterArn property is set
        internal bool IsSetFilterArn()
        {
            return this._filterArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The values to use when promoting items. For each placeholder parameter in your promotion's
        /// filter expression, provide the parameter name (in matching case) as a key and the
        /// filter value(s) as the corresponding value. Separate multiple values for one parameter
        /// with a comma. 
        /// </para>
        ///  
        /// <para>
        /// For filter expressions that use an <c>INCLUDE</c> element to include items, you must
        /// provide values for all parameters that are defined in the expression. For filters
        /// with expressions that use an <c>EXCLUDE</c> element to exclude items, you can omit
        /// the <c>filter-values</c>. In this case, Amazon Personalize doesn't use that portion
        /// of the expression to filter recommendations.
        /// </para>
        ///  
        /// <para>
        /// For more information on creating filters, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// recommendations and user segments</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=25)]
        public Dictionary<string, string> FilterValues
        {
            get { return this._filterValues; }
            set { this._filterValues = value; }
        }

        // Check to see if FilterValues property is set
        internal bool IsSetFilterValues()
        {
            return this._filterValues != null && (this._filterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the promotion.
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

        /// <summary>
        /// Gets and sets the property PercentPromotedItems. 
        /// <para>
        /// The percentage of recommended items to apply the promotion to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? PercentPromotedItems
        {
            get { return this._percentPromotedItems; }
            set { this._percentPromotedItems = value; }
        }

        // Check to see if PercentPromotedItems property is set
        internal bool IsSetPercentPromotedItems()
        {
            return this._percentPromotedItems.HasValue; 
        }

    }
}