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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The resize specification for On-Demand and Spot Instances in the fleet.
    /// </summary>
    public partial class InstanceFleetResizingSpecifications
    {
        private OnDemandResizingSpecification _onDemandResizeSpecification;
        private SpotResizingSpecification _spotResizeSpecification;

        /// <summary>
        /// Gets and sets the property OnDemandResizeSpecification. 
        /// <para>
        /// The resize specification for On-Demand Instances in the instance fleet, which contains
        /// the resize timeout period. 
        /// </para>
        /// </summary>
        public OnDemandResizingSpecification OnDemandResizeSpecification
        {
            get { return this._onDemandResizeSpecification; }
            set { this._onDemandResizeSpecification = value; }
        }

        // Check to see if OnDemandResizeSpecification property is set
        internal bool IsSetOnDemandResizeSpecification()
        {
            return this._onDemandResizeSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property SpotResizeSpecification. 
        /// <para>
        /// The resize specification for Spot Instances in the instance fleet, which contains
        /// the resize timeout period. 
        /// </para>
        /// </summary>
        public SpotResizingSpecification SpotResizeSpecification
        {
            get { return this._spotResizeSpecification; }
            set { this._spotResizeSpecification = value; }
        }

        // Check to see if SpotResizeSpecification property is set
        internal bool IsSetSpotResizeSpecification()
        {
            return this._spotResizeSpecification != null;
        }

    }
}