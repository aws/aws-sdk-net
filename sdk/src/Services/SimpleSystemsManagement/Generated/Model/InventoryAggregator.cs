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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Specifies the inventory type and attribute for the aggregation execution.
    /// </summary>
    public partial class InventoryAggregator
    {
        private List<InventoryAggregator> _aggregators = AWSConfigs.InitializeCollections ? new List<InventoryAggregator>() : null;
        private string _expression;
        private List<InventoryGroup> _groups = AWSConfigs.InitializeCollections ? new List<InventoryGroup>() : null;

        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// Nested aggregators to further refine aggregation for an inventory type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<InventoryAggregator> Aggregators
        {
            get { return this._aggregators; }
            set { this._aggregators = value; }
        }

        // Check to see if Aggregators property is set
        internal bool IsSetAggregators()
        {
            return this._aggregators != null && (this._aggregators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The inventory type and attribute name for aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// A user-defined set of one or more filters on which to aggregate inventory data. Groups
        /// return a count of resources that match and don't match the specified criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<InventoryGroup> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}