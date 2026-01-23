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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Tool invocation message content
    /// </summary>
    public partial class SpanToolUseValue
    {
        private Amazon.Runtime.Documents.Document _arguments;
        private string _name;
        private string _toolUseId;

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The tool input arguments
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Amazon.Runtime.Documents.Document Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return !this._arguments.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The tool name
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// Unique ID for this tool invocation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ToolUseId
        {
            get { return this._toolUseId; }
            set { this._toolUseId = value; }
        }

        // Check to see if ToolUseId property is set
        internal bool IsSetToolUseId()
        {
            return this._toolUseId != null;
        }

    }
}