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
    /// The evaluation rule that defines sampling configuration, filtering criteria, and
    /// session detection settings for online evaluation.
    /// </summary>
    public partial class Rule
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private SamplingConfig _samplingConfig;
        private SessionConfig _sessionConfig;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  The list of filters that determine which agent traces should be included in the evaluation
        /// based on trace properties. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SamplingConfig. 
        /// <para>
        ///  The sampling configuration that determines what percentage of agent traces to evaluate.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SamplingConfig SamplingConfig
        {
            get { return this._samplingConfig; }
            set { this._samplingConfig = value; }
        }

        // Check to see if SamplingConfig property is set
        internal bool IsSetSamplingConfig()
        {
            return this._samplingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SessionConfig. 
        /// <para>
        ///  The session configuration that defines timeout settings for detecting when agent
        /// sessions are complete and ready for evaluation. 
        /// </para>
        /// </summary>
        public SessionConfig SessionConfig
        {
            get { return this._sessionConfig; }
            set { this._sessionConfig = value; }
        }

        // Check to see if SessionConfig property is set
        internal bool IsSetSessionConfig()
        {
            return this._sessionConfig != null;
        }

    }
}