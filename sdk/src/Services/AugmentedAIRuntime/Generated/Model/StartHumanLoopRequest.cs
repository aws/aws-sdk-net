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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
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
    /// Container for the parameters to the StartHumanLoop operation.
    /// Starts a human loop, provided that at least one activation condition is met.
    /// </summary>
    public partial class StartHumanLoopRequest : AmazonAugmentedAIRuntimeRequest
    {
        private HumanLoopDataAttributes _dataAttributes;
        private string _flowDefinitionArn;
        private HumanLoopInput _humanLoopInput;
        private string _humanLoopName;

        /// <summary>
        /// Gets and sets the property DataAttributes. 
        /// <para>
        /// Attributes of the specified data. Use <c>DataAttributes</c> to specify if your data
        /// is free of personally identifiable information and/or free of adult content.
        /// </para>
        /// </summary>
        public HumanLoopDataAttributes DataAttributes
        {
            get { return this._dataAttributes; }
            set { this._dataAttributes = value; }
        }

        // Check to see if DataAttributes property is set
        internal bool IsSetDataAttributes()
        {
            return this._dataAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow definition associated with this human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string FlowDefinitionArn
        {
            get { return this._flowDefinitionArn; }
            set { this._flowDefinitionArn = value; }
        }

        // Check to see if FlowDefinitionArn property is set
        internal bool IsSetFlowDefinitionArn()
        {
            return this._flowDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopInput. 
        /// <para>
        /// An object that contains information about the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HumanLoopInput HumanLoopInput
        {
            get { return this._humanLoopInput; }
            set { this._humanLoopInput = value; }
        }

        // Check to see if HumanLoopInput property is set
        internal bool IsSetHumanLoopInput()
        {
            return this._humanLoopInput != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopName. 
        /// <para>
        /// The name of the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string HumanLoopName
        {
            get { return this._humanLoopName; }
            set { this._humanLoopName = value; }
        }

        // Check to see if HumanLoopName property is set
        internal bool IsSetHumanLoopName()
        {
            return this._humanLoopName != null;
        }

    }
}