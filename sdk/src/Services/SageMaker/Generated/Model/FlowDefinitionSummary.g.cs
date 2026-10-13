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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains summary information about the flow definition.
    /// </summary>
    public partial class FlowDefinitionSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when SageMaker created the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why the flow definition creation failed. A failure reason is returned only
        /// when the flow definition status is <c>Failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string FlowDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionArn property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionArn() => this.FlowDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionName. 
        /// <para>
        /// The name of the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string FlowDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionName property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionName() => this.FlowDefinitionName != null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionStatus. 
        /// <para>
        /// The status of the flow definition. Valid values:
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowDefinitionStatus FlowDefinitionStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionStatus property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionStatus() => this.FlowDefinitionStatus != null;
    }
}
