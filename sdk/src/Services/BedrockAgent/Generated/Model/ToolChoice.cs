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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Defines which tools the model should request when invoked. For more information, see
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Use a
    /// tool to complete an Amazon Bedrock model response</a>.
    /// </summary>
    public partial class ToolChoice
    {
        private AnyToolChoice _any;
        private AutoToolChoice _auto;
        private SpecificToolChoice _tool;

        /// <summary>
        /// Gets and sets the property Any. 
        /// <para>
        /// Defines tools, at least one of which must be requested by the model. No text is generated
        /// but the results of tool use are sent back to the model to help generate a response.
        /// </para>
        /// </summary>
        public AnyToolChoice Any
        {
            get { return this._any; }
            set { this._any = value; }
        }

        // Check to see if Any property is set
        internal bool IsSetAny()
        {
            return this._any != null;
        }

        /// <summary>
        /// Gets and sets the property Auto. 
        /// <para>
        /// Defines tools. The model automatically decides whether to call a tool or to generate
        /// text instead.
        /// </para>
        /// </summary>
        public AutoToolChoice Auto
        {
            get { return this._auto; }
            set { this._auto = value; }
        }

        // Check to see if Auto property is set
        internal bool IsSetAuto()
        {
            return this._auto != null;
        }

        /// <summary>
        /// Gets and sets the property Tool. 
        /// <para>
        /// Defines a specific tool that the model must request. No text is generated but the
        /// results of tool use are sent back to the model to help generate a response.
        /// </para>
        /// </summary>
        public SpecificToolChoice Tool
        {
            get { return this._tool; }
            set { this._tool = value; }
        }

        // Check to see if Tool property is set
        internal bool IsSetTool()
        {
            return this._tool != null;
        }

    }
}