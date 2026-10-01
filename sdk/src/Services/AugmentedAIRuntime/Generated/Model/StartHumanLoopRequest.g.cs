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

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the StartHumanLoop operation. Starts a human loop,
    /// provided that at least one activation condition is met.
    /// </summary>
    public partial class StartHumanLoopRequest : AmazonAugmentedAIRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property DataAttributes. 
        /// <para>
        /// Attributes of the specified data. Use <c>DataAttributes</c> to specify if your data
        /// is free of personally identifiable information and/or free of adult content.
        /// </para>
        /// </summary>
        public HumanLoopDataAttributes DataAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DataAttributes property is set.
        /// </summary>
        internal bool IsSetDataAttributes() => this.DataAttributes != null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow definition associated with this human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string FlowDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionArn property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionArn() => this.FlowDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property HumanLoopInput. 
        /// <para>
        /// An object that contains information about the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HumanLoopInput HumanLoopInput { get; set; }

        /// <summary>
        /// Checks to see if the HumanLoopInput property is set.
        /// </summary>
        internal bool IsSetHumanLoopInput() => this.HumanLoopInput != null;

        /// <summary>
        /// Gets and sets the property HumanLoopName. 
        /// <para>
        /// The name of the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string HumanLoopName { get; set; }

        /// <summary>
        /// Checks to see if the HumanLoopName property is set.
        /// </summary>
        internal bool IsSetHumanLoopName() => this.HumanLoopName != null;
    }
}
