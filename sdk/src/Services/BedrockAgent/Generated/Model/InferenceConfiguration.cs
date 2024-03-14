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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configuration for inference in prompt configuration
    /// </summary>
    public partial class InferenceConfiguration
    {
        private int? _maximumLength;
        private List<string> _stopSequences = new List<string>();
        private float? _temperature;
        private int? _topk;
        private float? _topp;

        /// <summary>
        /// Gets and sets the property MaximumLength.
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public int? MaximumLength
        {
            get { return this._maximumLength; }
            set { this._maximumLength = value; }
        }

        // Check to see if MaximumLength property is set
        internal bool IsSetMaximumLength()
        {
            return this._maximumLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopSequences.
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public List<string> StopSequences
        {
            get { return this._stopSequences; }
            set { this._stopSequences = value; }
        }

        // Check to see if StopSequences property is set
        internal bool IsSetStopSequences()
        {
            return this._stopSequences != null && this._stopSequences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Temperature.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? Temperature
        {
            get { return this._temperature; }
            set { this._temperature = value; }
        }

        // Check to see if Temperature property is set
        internal bool IsSetTemperature()
        {
            return this._temperature.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopK.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int? TopK
        {
            get { return this._topk; }
            set { this._topk = value; }
        }

        // Check to see if TopK property is set
        internal bool IsSetTopK()
        {
            return this._topk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopP.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? TopP
        {
            get { return this._topp; }
            set { this._topp = value; }
        }

        // Check to see if TopP property is set
        internal bool IsSetTopP()
        {
            return this._topp.HasValue; 
        }

    }
}