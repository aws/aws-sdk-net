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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A static route to a single gateway target.
    /// </summary>
    public partial class StaticRoute
    {
        /// <summary>
        /// Gets and sets the property Fallback. 
        /// <para>
        /// The fallback configuration for this route. Supported only for inference targets.
        /// </para>
        /// </summary>
        public Fallback Fallback { get; set; }

        /// <summary>
        /// Checks to see if the Fallback property is set.
        /// </summary>
        internal bool IsSetFallback() => this.Fallback != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model ID to send to the target. Supported only for inference targets. If you don't
        /// specify a model, the gateway sends the model from the original request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the target to route requests to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string TargetName { get; set; }

        /// <summary>
        /// Checks to see if the TargetName property is set.
        /// </summary>
        internal bool IsSetTargetName() => this.TargetName != null;
    }
}
