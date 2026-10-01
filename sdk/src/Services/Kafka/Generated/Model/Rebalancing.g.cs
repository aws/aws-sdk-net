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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Specifies whether or not intelligent rebalancing is turned on for a newly created
    /// MSK Provisioned cluster with Express brokers. Intelligent rebalancing performs automatic
    /// partition balancing operations when you scale your clusters up or down. By default,
    /// intelligent rebalancing is ACTIVE for all new Express-based clusters.
    /// </summary>
    public partial class Rebalancing
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Intelligent rebalancing status. The default intelligent rebalancing status is ACTIVE
        /// for all new Express-based clusters.
        /// </para>
        /// </summary>
        public RebalancingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
