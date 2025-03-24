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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// An array of objects with metadata about the requested <c>FlowOperation</c>.
    /// </summary>
    public partial class FlowOperationMetadata
    {
        private string _flowOperationId;
        private FlowOperationStatus _flowOperationStatus;
        private FlowOperationType _flowOperationType;
        private DateTime? _flowRequestTimestamp;

        /// <summary>
        /// Gets and sets the property FlowOperationId. 
        /// <para>
        /// A unique identifier for the flow operation. This ID is returned in the responses to
        /// start and list commands. You provide to describe commands.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string FlowOperationId
        {
            get { return this._flowOperationId; }
            set { this._flowOperationId = value; }
        }

        // Check to see if FlowOperationId property is set
        internal bool IsSetFlowOperationId()
        {
            return this._flowOperationId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowOperationStatus. 
        /// <para>
        /// Returns the status of the flow operation. This string is returned in the responses
        /// to start, list, and describe commands.
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>COMPLETED_WITH_ERRORS</c>, results may be returned with any number
        /// of <c>Flows</c> missing from the response. If the status is <c>FAILED</c>, <c>Flows</c>
        /// returned will be empty.
        /// </para>
        /// </summary>
        public FlowOperationStatus FlowOperationStatus
        {
            get { return this._flowOperationStatus; }
            set { this._flowOperationStatus = value; }
        }

        // Check to see if FlowOperationStatus property is set
        internal bool IsSetFlowOperationStatus()
        {
            return this._flowOperationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FlowOperationType. 
        /// <para>
        /// Defines the type of <c>FlowOperation</c>.
        /// </para>
        /// </summary>
        public FlowOperationType FlowOperationType
        {
            get { return this._flowOperationType; }
            set { this._flowOperationType = value; }
        }

        // Check to see if FlowOperationType property is set
        internal bool IsSetFlowOperationType()
        {
            return this._flowOperationType != null;
        }

        /// <summary>
        /// Gets and sets the property FlowRequestTimestamp. 
        /// <para>
        /// A timestamp indicating when the Suricata engine identified flows impacted by an operation.
        /// 
        /// </para>
        /// </summary>
        public DateTime? FlowRequestTimestamp
        {
            get { return this._flowRequestTimestamp; }
            set { this._flowRequestTimestamp = value; }
        }

        // Check to see if FlowRequestTimestamp property is set
        internal bool IsSetFlowRequestTimestamp()
        {
            return this._flowRequestTimestamp.HasValue; 
        }

    }
}