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
    /// An action that applies a configuration bundle override, either as a static override
    /// or a weighted split for A/B testing.
    /// </summary>
    public partial class ConfigurationBundleAction
    {
        private StaticOverride _staticOverride;
        private WeightedOverride _weightedOverride;

        /// <summary>
        /// Gets and sets the property StaticOverride. 
        /// <para>
        /// A static configuration bundle override that applies a single bundle version to all
        /// matching requests.
        /// </para>
        /// </summary>
        public StaticOverride StaticOverride
        {
            get { return this._staticOverride; }
            set { this._staticOverride = value; }
        }

        // Check to see if StaticOverride property is set
        internal bool IsSetStaticOverride()
        {
            return this._staticOverride != null;
        }

        /// <summary>
        /// Gets and sets the property WeightedOverride. 
        /// <para>
        /// A weighted configuration bundle override that splits traffic between multiple bundle
        /// versions based on configured weights.
        /// </para>
        /// </summary>
        public WeightedOverride WeightedOverride
        {
            get { return this._weightedOverride; }
            set { this._weightedOverride = value; }
        }

        // Check to see if WeightedOverride property is set
        internal bool IsSetWeightedOverride()
        {
            return this._weightedOverride != null;
        }

    }
}