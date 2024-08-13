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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private DateTime? _requestTime;
        private string _reservedNodeExchangeRequestId;
        private int? _sourceReservedNodeCount;
        private string _sourceReservedNodeId;
        private string _sourceReservedNodeType;
        private ReservedNodeExchangeStatusType _status;
        private int? _targetReservedNodeCount;
        private string _targetReservedNodeOfferingId;
        private string _targetReservedNodeType;

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// A date and time that indicate when the reserved-node exchange was requested.
        /// </para>
        /// </summary>
        public DateTime? RequestTime
        {
            get { return this._requestTime; }
            set { this._requestTime = value; }
        }

        // Check to see if RequestTime property is set
        internal bool IsSetRequestTime()
        {
            return this._requestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedNodeExchangeRequestId. 
        /// <para>
        /// The identifier of the reserved-node exchange request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ReservedNodeExchangeRequestId
        {
            get { return this._reservedNodeExchangeRequestId; }
            set { this._reservedNodeExchangeRequestId = value; }
        }

        // Check to see if ReservedNodeExchangeRequestId property is set
        internal bool IsSetReservedNodeExchangeRequestId()
        {
            return this._reservedNodeExchangeRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceReservedNodeCount. 
        /// <para>
        /// The source reserved-node count in the cluster.
        /// </para>
        /// </summary>
        public int? SourceReservedNodeCount
        {
            get { return this._sourceReservedNodeCount; }
            set { this._sourceReservedNodeCount = value; }
        }

        // Check to see if SourceReservedNodeCount property is set
        internal bool IsSetSourceReservedNodeCount()
        {
            return this._sourceReservedNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceReservedNodeId. 
        /// <para>
        /// The identifier of the source reserved node.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SourceReservedNodeId
        {
            get { return this._sourceReservedNodeId; }
            set { this._sourceReservedNodeId = value; }
        }

        // Check to see if SourceReservedNodeId property is set
        internal bool IsSetSourceReservedNodeId()
        {
            return this._sourceReservedNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceReservedNodeType. 
        /// <para>
        /// The source reserved-node type, for example ra3.4xlarge.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SourceReservedNodeType
        {
            get { return this._sourceReservedNodeType; }
            set { this._sourceReservedNodeType = value; }
        }

        // Check to see if SourceReservedNodeType property is set
        internal bool IsSetSourceReservedNodeType()
        {
            return this._sourceReservedNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the reserved-node exchange request. Statuses include in-progress and
        /// requested.
        /// </para>
        /// </summary>
        public ReservedNodeExchangeStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeCount. 
        /// <para>
        /// The count of target reserved nodes in the cluster.
        /// </para>
        /// </summary>
        public int? TargetReservedNodeCount
        {
            get { return this._targetReservedNodeCount; }
            set { this._targetReservedNodeCount = value; }
        }

        // Check to see if TargetReservedNodeCount property is set
        internal bool IsSetTargetReservedNodeCount()
        {
            return this._targetReservedNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOfferingId. 
        /// <para>
        /// The identifier of the target reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string TargetReservedNodeOfferingId
        {
            get { return this._targetReservedNodeOfferingId; }
            set { this._targetReservedNodeOfferingId = value; }
        }

        // Check to see if TargetReservedNodeOfferingId property is set
        internal bool IsSetTargetReservedNodeOfferingId()
        {
            return this._targetReservedNodeOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeType. 
        /// <para>
        /// The node type of the target reserved node, for example ra3.4xlarge.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string TargetReservedNodeType
        {
            get { return this._targetReservedNodeType; }
            set { this._targetReservedNodeType = value; }
        }

        // Check to see if TargetReservedNodeType property is set
        internal bool IsSetTargetReservedNodeType()
        {
            return this._targetReservedNodeType != null;
        }

    }
}