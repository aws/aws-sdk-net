/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Specifies the inventory type and attribute for the aggregation execution.
    /// </summary>
    public partial class InventoryAggregator
    {
        private List<InventoryAggregator> _aggregators = new List<InventoryAggregator>();
        private string _expression;

        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// Nested aggregators to further refine aggregation for an inventory type.
        /// </para>
        /// </summary>
        public List<InventoryAggregator> Aggregators
        {
            get { return this._aggregators; }
            set { this._aggregators = value; }
        }

        // Check to see if Aggregators property is set
        internal bool IsSetAggregators()
        {
            return this._aggregators != null && this._aggregators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The inventory type and attribute name for aggregation.
        /// </para>
        /// </summary>
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

    }
}