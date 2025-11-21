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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Traffic options for the route.
    /// </summary>
    public partial class RouteTrafficOptions
    {
        private long? _flowEventThresholdOverride;
        private TrafficUsage _usage;

        /// <summary>
        /// Gets and sets the property FlowEventThresholdOverride. 
        /// <para>
        /// Duration for which flow traffic is considered valid. For this period, the flow traffic
        /// is used over historical traffic data. Flow traffic refers to congestion, which changes
        /// very quickly. Duration in seconds for which flow traffic event would be considered
        /// valid. While flow traffic event is valid it will be used over the historical traffic
        /// data. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? FlowEventThresholdOverride
        {
            get { return this._flowEventThresholdOverride; }
            set { this._flowEventThresholdOverride = value; }
        }

        // Check to see if FlowEventThresholdOverride property is set
        internal bool IsSetFlowEventThresholdOverride()
        {
            return this._flowEventThresholdOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// Determines if traffic should be used or ignored while calculating the route.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>UseTrafficData</c> 
        /// </para>
        /// </summary>
        public TrafficUsage Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}