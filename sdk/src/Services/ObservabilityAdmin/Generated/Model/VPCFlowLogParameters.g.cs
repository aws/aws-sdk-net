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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration parameters specific to VPC Flow Logs.
    /// </summary>
    public partial class VPCFlowLogParameters
    {
        /// <summary>
        /// Gets and sets the property LogFormat. 
        /// <para>
        ///  The format in which VPC Flow Log entries should be logged. 
        /// </para>
        /// </summary>
        public string LogFormat { get; set; }

        /// <summary>
        /// Checks to see if the LogFormat property is set.
        /// </summary>
        internal bool IsSetLogFormat() => this.LogFormat != null;

        /// <summary>
        /// Gets and sets the property MaxAggregationInterval. 
        /// <para>
        ///  The maximum interval in seconds between the capture of flow log records. 
        /// </para>
        /// </summary>
        public int? MaxAggregationInterval { get; set; }

        /// <summary>
        /// Checks to see if the MaxAggregationInterval property is set.
        /// </summary>
        internal bool IsSetMaxAggregationInterval() => this.MaxAggregationInterval.HasValue;

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        ///  The type of traffic to log (ACCEPT, REJECT, or ALL). 
        /// </para>
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// Checks to see if the TrafficType property is set.
        /// </summary>
        internal bool IsSetTrafficType() => this.TrafficType != null;
    }
}
