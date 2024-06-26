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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Determines which tools the model should request in a call to <c>Converse</c> or <c>ConverseStream</c>.
    /// <c>ToolChoice</c> is only supported by Anthropic Claude 3 models and by Mistral AI
    /// Mistral Large.
    /// </summary>
    public partial class ToolChoice
    {
        private AnyToolChoice _any;
        private AutoToolChoice _auto;
        private SpecificToolChoice _tool;

        /// <summary>
        /// Gets and sets the property Any. 
        /// <para>
        /// The model must request at least one tool (no text is generated).
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
        /// (Default). The Model automatically decides if a tool should be called or whether to
        /// generate text instead. 
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
        /// The Model must request the specified tool. Only supported by Anthropic Claude 3 models.
        /// 
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