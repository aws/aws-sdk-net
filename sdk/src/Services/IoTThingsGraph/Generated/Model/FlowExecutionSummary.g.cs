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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// An object that contains summary information about a flow execution.
    /// </summary>
    public partial class FlowExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the flow execution summary was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FlowExecutionId. 
        /// <para>
        /// The ID of the flow execution.
        /// </para>
        /// </summary>
        public string FlowExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the FlowExecutionId property is set.
        /// </summary>
        internal bool IsSetFlowExecutionId() => this.FlowExecutionId != null;

        /// <summary>
        /// Gets and sets the property FlowTemplateId. 
        /// <para>
        /// The ID of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 160)]
        public string FlowTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the FlowTemplateId property is set.
        /// </summary>
        internal bool IsSetFlowTemplateId() => this.FlowTemplateId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the flow execution.
        /// </para>
        /// </summary>
        public FlowExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemInstanceId. 
        /// <para>
        /// The ID of the system instance that contains the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 160)]
        public string SystemInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the SystemInstanceId property is set.
        /// </summary>
        internal bool IsSetSystemInstanceId() => this.SystemInstanceId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the flow execution summary was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
