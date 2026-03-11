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
    /// Contains configurations for a custom reflection strategy.
    /// </summary>
    public partial class CustomReflectionConfiguration
    {
        private EpisodicReflectionOverride _episodicReflectionOverride;

        /// <summary>
        /// Gets and sets the property EpisodicReflectionOverride. 
        /// <para>
        /// The configuration for a reflection strategy to override the default one.
        /// </para>
        /// </summary>
        public EpisodicReflectionOverride EpisodicReflectionOverride
        {
            get { return this._episodicReflectionOverride; }
            set { this._episodicReflectionOverride = value; }
        }

        // Check to see if EpisodicReflectionOverride property is set
        internal bool IsSetEpisodicReflectionOverride()
        {
            return this._episodicReflectionOverride != null;
        }

    }
}