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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Used to specify configuration options for a volume’s storage aggregate or aggregates.
    /// </summary>
    public partial class AggregateConfiguration
    {
        private List<string> _aggregates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _totalConstituents;

        /// <summary>
        /// Gets and sets the property Aggregates. 
        /// <para>
        /// The list of aggregates that this volume resides on. Aggregates are storage pools which
        /// make up your primary storage tier. Each high-availability (HA) pair has one aggregate.
        /// The names of the aggregates map to the names of the aggregates in the ONTAP CLI and
        /// REST API. For FlexVols, there will always be a single entry.
        /// </para>
        ///  
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) for the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The strings in the value of <c>Aggregates</c> are not are not formatted as <c>aggrX</c>,
        /// where X is a number between 1 and 12.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>Aggregates</c> contains aggregates that are not present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more of the aggregates supplied are too close to the volume limit to support
        /// adding more volumes.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=6)]
        public List<string> Aggregates
        {
            get { return this._aggregates; }
            set { this._aggregates = value; }
        }

        // Check to see if Aggregates property is set
        internal bool IsSetAggregates()
        {
            return this._aggregates != null && (this._aggregates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalConstituents. 
        /// <para>
        /// The total number of constituents this FlexGroup volume has. Not applicable for FlexVols.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public int? TotalConstituents
        {
            get { return this._totalConstituents; }
            set { this._totalConstituents = value; }
        }

        // Check to see if TotalConstituents property is set
        internal bool IsSetTotalConstituents()
        {
            return this._totalConstituents.HasValue; 
        }

    }
}