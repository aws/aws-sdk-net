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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Object that allows filtering on product title.
    /// </summary>
    public partial class SaaSProductTitleFilter
    {
        private List<string> _valueList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _wildCardValue;

        /// <summary>
        /// Gets and sets the property ValueList. 
        /// <para>
        /// A string array of unique product title values to be filtered on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ValueList
        {
            get { return this._valueList; }
            set { this._valueList = value; }
        }

        // Check to see if ValueList property is set
        internal bool IsSetValueList()
        {
            return this._valueList != null && (this._valueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WildCardValue. 
        /// <para>
        /// A string that will be the <c>wildCard</c> input for product tile filter. It matches
        /// the provided value as a substring in the actual value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WildCardValue
        {
            get { return this._wildCardValue; }
            set { this._wildCardValue = value; }
        }

        // Check to see if WildCardValue property is set
        internal bool IsSetWildCardValue()
        {
            return this._wildCardValue != null;
        }

    }
}