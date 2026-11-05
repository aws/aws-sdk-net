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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Reserved-node status details, such as the source reserved-node identifier, the target
    /// reserved-node identifier, the node type, the node count, and other details.
    /// </summary>
    public partial class ReservedNodeExchangeStatus
    {
        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// A date and time that indicate when the reserved-node exchange was requested.
        /// </para>
        /// </summary>
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestTime property is set.
        /// </summary>
        internal bool IsSetRequestTime() => this.RequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedNodeExchangeRequestId. 
        /// <para>
        /// The identifier of the reserved-node exchange request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ReservedNodeExchangeRequestId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodeExchangeRequestId property is set.
        /// </summary>
        internal bool IsSetReservedNodeExchangeRequestId() => this.ReservedNodeExchangeRequestId != null;

        /// <summary>
        /// Gets and sets the property SourceReservedNodeCount. 
        /// <para>
        /// The source reserved-node count in the cluster.
        /// </para>
        /// </summary>
        public int? SourceReservedNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the SourceReservedNodeCount property is set.
        /// </summary>
        internal bool IsSetSourceReservedNodeCount() => this.SourceReservedNodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property SourceReservedNodeId. 
        /// <para>
        /// The identifier of the source reserved node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceReservedNodeId { get; set; }

        /// <summary>
        /// Checks to see if the SourceReservedNodeId property is set.
        /// </summary>
        internal bool IsSetSourceReservedNodeId() => this.SourceReservedNodeId != null;

        /// <summary>
        /// Gets and sets the property SourceReservedNodeType. 
        /// <para>
        /// The source reserved-node type, for example ra3.4xlarge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceReservedNodeType { get; set; }

        /// <summary>
        /// Checks to see if the SourceReservedNodeType property is set.
        /// </summary>
        internal bool IsSetSourceReservedNodeType() => this.SourceReservedNodeType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the reserved-node exchange request. Statuses include in-progress and
        /// requested.
        /// </para>
        /// </summary>
        public ReservedNodeExchangeStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetReservedNodeCount. 
        /// <para>
        /// The count of target reserved nodes in the cluster.
        /// </para>
        /// </summary>
        public int? TargetReservedNodeCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetReservedNodeCount property is set.
        /// </summary>
        internal bool IsSetTargetReservedNodeCount() => this.TargetReservedNodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOfferingId. 
        /// <para>
        /// The identifier of the target reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetReservedNodeOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the TargetReservedNodeOfferingId property is set.
        /// </summary>
        internal bool IsSetTargetReservedNodeOfferingId() => this.TargetReservedNodeOfferingId != null;

        /// <summary>
        /// Gets and sets the property TargetReservedNodeType. 
        /// <para>
        /// The node type of the target reserved node, for example ra3.4xlarge.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetReservedNodeType { get; set; }

        /// <summary>
        /// Checks to see if the TargetReservedNodeType property is set.
        /// </summary>
        internal bool IsSetTargetReservedNodeType() => this.TargetReservedNodeType != null;
    }
}
