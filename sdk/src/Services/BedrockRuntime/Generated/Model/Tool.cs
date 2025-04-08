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
    /// Information about a tool that you can use with the Converse API. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Tool
    /// use (function calling)</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class Tool
    {
        private CachePointBlock _cachePoint;
        private ToolSpecification _toolSpec;

        /// <summary>
        /// Gets and sets the property CachePoint. 
        /// <para>
        /// CachePoint to include in the tool configuration.
        /// </para>
        /// </summary>
        public CachePointBlock CachePoint
        {
            get { return this._cachePoint; }
            set { this._cachePoint = value; }
        }

        // Check to see if CachePoint property is set
        internal bool IsSetCachePoint()
        {
            return this._cachePoint != null;
        }

        /// <summary>
        /// Gets and sets the property ToolSpec. 
        /// <para>
        /// The specfication for the tool.
        /// </para>
        /// </summary>
        public ToolSpecification ToolSpec
        {
            get { return this._toolSpec; }
            set { this._toolSpec = value; }
        }

        // Check to see if ToolSpec property is set
        internal bool IsSetToolSpec()
        {
            return this._toolSpec != null;
        }

    }
}