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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The state of a cloned blue/green upgrade. Members that don't apply are omitted.
    /// </summary>
    public partial class ClonedBlueGreenUpgradeDetails
    {
        /// <summary>
        /// Gets and sets the property RetentionInHours. 
        /// <para>
        /// The retention period, in hours, for the cluster that you cut over from.
        /// </para>
        /// </summary>
        public int? RetentionInHours { get; set; }

        /// <summary>
        /// Checks to see if the RetentionInHours property is set.
        /// </summary>
        internal bool IsSetRetentionInHours() => this.RetentionInHours.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduledAction. 
        /// <para>
        /// The action that the service takes automatically if you don't act before the scheduled
        /// time.
        /// </para>
        /// </summary>
        public ClonedBlueGreenScheduledAction ScheduledAction { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAction property is set.
        /// </summary>
        internal bool IsSetScheduledAction() => this.ScheduledAction != null;

        /// <summary>
        /// Gets and sets the property TrafficSplit. 
        /// <para>
        /// The current split of search traffic between the primary and cloned clusters.
        /// </para>
        /// </summary>
        public TrafficPercents TrafficSplit { get; set; }

        /// <summary>
        /// Checks to see if the TrafficSplit property is set.
        /// </summary>
        internal bool IsSetTrafficSplit() => this.TrafficSplit != null;
    }
}
