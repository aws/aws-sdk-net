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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// A trace for a routing classifier.
    /// </summary>
    public partial class RoutingClassifierTrace
    {
        private InvocationInput _invocationInput;
        private ModelInvocationInput _modelInvocationInput;
        private RoutingClassifierModelInvocationOutput _modelInvocationOutput;
        private Observation _observation;

        /// <summary>
        /// Gets and sets the property InvocationInput. 
        /// <para>
        /// The classifier's invocation input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public InvocationInput InvocationInput
        {
            get { return this._invocationInput; }
            set { this._invocationInput = value; }
        }

        // Check to see if InvocationInput property is set
        internal bool IsSetInvocationInput()
        {
            return this._invocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property ModelInvocationInput. 
        /// <para>
        /// The classifier's model invocation input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ModelInvocationInput ModelInvocationInput
        {
            get { return this._modelInvocationInput; }
            set { this._modelInvocationInput = value; }
        }

        // Check to see if ModelInvocationInput property is set
        internal bool IsSetModelInvocationInput()
        {
            return this._modelInvocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property ModelInvocationOutput. 
        /// <para>
        /// The classifier's model invocation output.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RoutingClassifierModelInvocationOutput ModelInvocationOutput
        {
            get { return this._modelInvocationOutput; }
            set { this._modelInvocationOutput = value; }
        }

        // Check to see if ModelInvocationOutput property is set
        internal bool IsSetModelInvocationOutput()
        {
            return this._modelInvocationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property Observation. 
        /// <para>
        /// The classifier's observation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Observation Observation
        {
            get { return this._observation; }
            set { this._observation = value; }
        }

        // Check to see if Observation property is set
        internal bool IsSetObservation()
        {
            return this._observation != null;
        }

    }
}