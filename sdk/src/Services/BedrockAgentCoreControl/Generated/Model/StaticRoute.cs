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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A static route to a single gateway target.
    /// </summary>
    public partial class StaticRoute
    {
        private Fallback _fallback;
        private string _model;
        private string _targetName;

        /// <summary>
        /// Gets and sets the property Fallback. 
        /// <para>
        /// The fallback configuration for this route. Supported only for inference targets.
        /// </para>
        /// </summary>
        public Fallback Fallback
        {
            get { return this._fallback; }
            set { this._fallback = value; }
        }

        // Check to see if Fallback property is set
        internal bool IsSetFallback()
        {
            return this._fallback != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model ID to send to the target. Supported only for inference targets. If you don't
        /// specify a model, the gateway sends the model from the original request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the target to route requests to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string TargetName
        {
            get { return this._targetName; }
            set { this._targetName = value; }
        }

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this._targetName != null;
        }

    }
}