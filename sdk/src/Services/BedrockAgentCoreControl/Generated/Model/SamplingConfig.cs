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
    /// The configuration that controls what percentage of agent traces are sampled for evaluation
    /// to manage evaluation volume and costs.
    /// </summary>
    public partial class SamplingConfig
    {
        private double? _samplingPercentage;

        /// <summary>
        /// Gets and sets the property SamplingPercentage. 
        /// <para>
        ///  The percentage of agent traces to sample for evaluation, ranging from 0.01% to 100%.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public double? SamplingPercentage
        {
            get { return this._samplingPercentage; }
            set { this._samplingPercentage = value; }
        }

        // Check to see if SamplingPercentage property is set
        internal bool IsSetSamplingPercentage()
        {
            return this._samplingPercentage.HasValue; 
        }

    }
}