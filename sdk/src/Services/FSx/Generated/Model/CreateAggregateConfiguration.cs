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
    /// Used to specify the configuration options for an FSx for ONTAP volume's storage aggregate
    /// or aggregates.
    /// </summary>
    public partial class CreateAggregateConfiguration
    {
        private List<string> _aggregates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _constituentsPerAggregate;

        /// <summary>
        /// Gets and sets the property Aggregates. 
        /// <para>
        /// Used to specify the names of aggregates on which the volume will be created.
        /// </para>
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
        /// Gets and sets the property ConstituentsPerAggregate. 
        /// <para>
        /// Used to explicitly set the number of constituents within the FlexGroup per storage
        /// aggregate. This field is optional when creating a FlexGroup volume. If unspecified,
        /// the default value will be 8. This field cannot be provided when creating a FlexVol
        /// volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public int? ConstituentsPerAggregate
        {
            get { return this._constituentsPerAggregate; }
            set { this._constituentsPerAggregate = value; }
        }

        // Check to see if ConstituentsPerAggregate property is set
        internal bool IsSetConstituentsPerAggregate()
        {
            return this._constituentsPerAggregate.HasValue; 
        }

    }
}