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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines the traffic pattern of the load test.
    /// </summary>
    public partial class TrafficPattern
    {
        private List<Phase> _phases = AWSConfigs.InitializeCollections ? new List<Phase>() : null;
        private Stairs _stairs;
        private TrafficType _trafficType;

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        /// Defines the phases traffic specification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Phase> Phases
        {
            get { return this._phases; }
            set { this._phases = value; }
        }

        // Check to see if Phases property is set
        internal bool IsSetPhases()
        {
            return this._phases != null && (this._phases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Stairs. 
        /// <para>
        /// Defines the stairs traffic pattern.
        /// </para>
        /// </summary>
        public Stairs Stairs
        {
            get { return this._stairs; }
            set { this._stairs = value; }
        }

        // Check to see if Stairs property is set
        internal bool IsSetStairs()
        {
            return this._stairs != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// Defines the traffic patterns. Choose either <c>PHASES</c> or <c>STAIRS</c>.
        /// </para>
        /// </summary>
        public TrafficType TrafficType
        {
            get { return this._trafficType; }
            set { this._trafficType = value; }
        }

        // Check to see if TrafficType property is set
        internal bool IsSetTrafficType()
        {
            return this._trafficType != null;
        }

    }
}