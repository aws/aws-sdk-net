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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains <c>SageMakerFlowDefinition</c> object. The object is used to specify the
    /// prompt dataset, task type, rating method and metric names.
    /// </summary>
    public partial class HumanWorkflowConfig
    {
        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) for the flow definition
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string FlowDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionArn property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionArn() => this.FlowDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// Instructions for the flow definition
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 5000)]
        public string Instructions { get; set; }

        /// <summary>
        /// Checks to see if the Instructions property is set.
        /// </summary>
        internal bool IsSetInstructions() => this.Instructions != null;
    }
}
