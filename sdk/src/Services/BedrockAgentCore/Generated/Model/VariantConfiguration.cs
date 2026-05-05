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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The configuration for an A/B test variant.
    /// </summary>
    public partial class VariantConfiguration
    {
        private ConfigurationBundleRef _configurationBundle;
        private TargetRef _target;

        /// <summary>
        /// Gets and sets the property ConfigurationBundle. 
        /// <para>
        /// A reference to a configuration bundle version to use for this variant.
        /// </para>
        /// </summary>
        public ConfigurationBundleRef ConfigurationBundle
        {
            get { return this._configurationBundle; }
            set { this._configurationBundle = value; }
        }

        // Check to see if ConfigurationBundle property is set
        internal bool IsSetConfigurationBundle()
        {
            return this._configurationBundle != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// A reference to a gateway target to route traffic to for this variant.
        /// </para>
        /// </summary>
        public TargetRef Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}