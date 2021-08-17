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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// When creating or updating a cost category, you can define the <code>CostCategoryRule</code>
    /// rule type as <code>INHERITED_VALUE</code>. This rule type adds the flexibility of
    /// defining a rule that dynamically inherits the cost category value from the dimension
    /// value defined by <code>CostCategoryInheritedValueDimension</code>. For example, if
    /// you want to dynamically group costs that are based on the value of a specific tag
    /// key, first choose an inherited value rule type, then choose the tag dimension and
    /// specify the tag key to use.
    /// </summary>
    public partial class CostCategoryInheritedValueDimension
    {
        private string _dimensionKey;
        private CostCategoryInheritedValueDimensionName _dimensionName;

        /// <summary>
        /// Gets and sets the property DimensionKey. 
        /// <para>
        /// The key to extract cost category values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DimensionKey
        {
            get { return this._dimensionKey; }
            set { this._dimensionKey = value; }
        }

        // Check to see if DimensionKey property is set
        internal bool IsSetDimensionKey()
        {
            return this._dimensionKey != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionName. 
        /// <para>
        /// The name of the dimension that's used to group costs.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>LINKED_ACCOUNT_NAME</code>, the cost category value is based
        /// on account name. If you specify <code>TAG</code>, the cost category value will be
        /// based on the value of the specified tag key.
        /// </para>
        /// </summary>
        public CostCategoryInheritedValueDimensionName DimensionName
        {
            get { return this._dimensionName; }
            set { this._dimensionName = value; }
        }

        // Check to see if DimensionName property is set
        internal bool IsSetDimensionName()
        {
            return this._dimensionName != null;
        }

    }
}