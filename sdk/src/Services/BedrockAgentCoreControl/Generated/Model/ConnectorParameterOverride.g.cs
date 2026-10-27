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
    /// Specifies a parameter override for a connector tool, allowing you to control parameter
    /// visibility and descriptions.
    /// </summary>
    public partial class ConnectorParameterOverride
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An agent-facing description override for this parameter.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// A JSON Pointer path identifying the parameter (for example, <c>/numberOfResults</c>
        /// or <c>/filter</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Visible. 
        /// <para>
        /// Whether this parameter is visible to the agent. If not specified, uses the service
        /// default.
        /// </para>
        /// </summary>
        public bool? Visible { get; set; }

        /// <summary>
        /// Checks to see if the Visible property is set.
        /// </summary>
        internal bool IsSetVisible() => this.Visible.HasValue;
    }
}
