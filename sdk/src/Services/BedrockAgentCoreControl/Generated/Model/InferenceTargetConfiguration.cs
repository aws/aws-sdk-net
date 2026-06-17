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
    /// The configuration for an inference target. An inference target routes requests to
    /// a large language model (LLM) provider, either through a built-in connector or an explicitly
    /// configured provider.
    /// </summary>
    public partial class InferenceTargetConfiguration
    {
        private InferenceConnectorTargetConfiguration _connector;
        private InferenceProviderTargetConfiguration _provider;

        /// <summary>
        /// Gets and sets the property Connector. 
        /// <para>
        /// The connector-based inference configuration. Use this option to route requests to
        /// an LLM provider through a built-in connector that includes predefined provider rules.
        /// </para>
        /// </summary>
        public InferenceConnectorTargetConfiguration Connector
        {
            get { return this._connector; }
            set { this._connector = value; }
        }

        // Check to see if Connector property is set
        internal bool IsSetConnector()
        {
            return this._connector != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider-based inference configuration. Use this option to explicitly configure
        /// the endpoint, model mapping, and operations for an LLM provider.
        /// </para>
        /// </summary>
        public InferenceProviderTargetConfiguration Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

    }
}