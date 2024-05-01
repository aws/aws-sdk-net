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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// An object that contains summary information about a flow execution.
    /// </summary>
    public partial class FlowExecutionSummary
    {
        private DateTime? _createdAt;
        private string _flowExecutionId;
        private string _flowTemplateId;
        private FlowExecutionStatus _status;
        private string _systemInstanceId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the flow execution summary was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FlowExecutionId. 
        /// <para>
        /// The ID of the flow execution.
        /// </para>
        /// </summary>
        public string FlowExecutionId
        {
            get { return this._flowExecutionId; }
            set { this._flowExecutionId = value; }
        }

        // Check to see if FlowExecutionId property is set
        internal bool IsSetFlowExecutionId()
        {
            return this._flowExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowTemplateId. 
        /// <para>
        /// The ID of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=160)]
        public string FlowTemplateId
        {
            get { return this._flowTemplateId; }
            set { this._flowTemplateId = value; }
        }

        // Check to see if FlowTemplateId property is set
        internal bool IsSetFlowTemplateId()
        {
            return this._flowTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the flow execution.
        /// </para>
        /// </summary>
        public FlowExecutionStatus Status
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
        /// Gets and sets the property SystemInstanceId. 
        /// <para>
        /// The ID of the system instance that contains the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=160)]
        public string SystemInstanceId
        {
            get { return this._systemInstanceId; }
            set { this._systemInstanceId = value; }
        }

        // Check to see if SystemInstanceId property is set
        internal bool IsSetSystemInstanceId()
        {
            return this._systemInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the flow execution summary was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}