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
    /// The source of the launch template configuration for a capacity provider. The <c>launchParameters</c>
    /// member specifies the operating system, instance requirements, and other settings used
    /// to launch instances.
    /// </summary>
    public partial class LaunchTemplateSource
    {
        private LaunchParameters _launchParameters;

        /// <summary>
        /// Gets and sets the property LaunchParameters. 
        /// <para>
        /// The parameters that AgentCore uses to create the launch template.
        /// </para>
        /// </summary>
        public LaunchParameters LaunchParameters
        {
            get { return this._launchParameters; }
            set { this._launchParameters = value; }
        }

        // Check to see if LaunchParameters property is set
        internal bool IsSetLaunchParameters()
        {
            return this._launchParameters != null;
        }

    }
}