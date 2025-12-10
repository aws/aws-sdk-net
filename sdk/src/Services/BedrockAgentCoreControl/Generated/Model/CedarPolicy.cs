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
    /// Represents a Cedar policy statement within the AgentCore Policy system. Cedar is a
    /// policy language designed for authorization that provides human-readable, analyzable,
    /// and high-performance policy evaluation for controlling agent behavior and access decisions.
    /// </summary>
    public partial class CedarPolicy
    {
        private string _statement;

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// The Cedar policy statement that defines the authorization logic. This statement follows
        /// Cedar syntax and specifies principals, actions, resources, and conditions that determine
        /// when access should be allowed or denied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=35, Max=153600)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}