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
    /// Information about the topic reassignment of an UpdateBrokerType operation that upgrades
    /// a cluster from Standard brokers to Express brokers. Present only on the operation
    /// that initiated the upgrade.
    /// </summary>
    public partial class BrokerTypeUpgradeInfo
    {
        /// <summary>
        /// Gets and sets the property TopicReassignmentMode. 
        /// <para>
        /// How topics are reassigned to the Express brokers.
        /// </para>
        /// </summary>
        public TopicReassignmentMode TopicReassignmentMode { get; set; }

        /// <summary>
        /// Checks to see if the TopicReassignmentMode property is set.
        /// </summary>
        internal bool IsSetTopicReassignmentMode() => this.TopicReassignmentMode != null;

        /// <summary>
        /// Gets and sets the property TopicReassignmentOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the topic reassignment operation that Amazon MSK
        /// started for this upgrade. Present once that reassignment has started. Under MANUAL
        /// you start reassignments yourself, so Amazon MSK starts none.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string TopicReassignmentOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the TopicReassignmentOperationArn property is set.
        /// </summary>
        internal bool IsSetTopicReassignmentOperationArn() => this.TopicReassignmentOperationArn != null;
    }
}
