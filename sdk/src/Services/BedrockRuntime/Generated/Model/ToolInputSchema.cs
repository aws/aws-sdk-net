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
    /// The schema for the tool. The top level schema type must be <c>object</c>.
    /// </summary>
    public partial class ToolInputSchema
    {
        private Amazon.Runtime.Documents.Document _json;

        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// The JSON schema for the tool. For more information, see <a href="https://json-schema.org/understanding-json-schema/reference">JSON
        /// Schema Reference</a>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Json
        {
            get { return this._json; }
            set { this._json = value; }
        }

        // Check to see if Json property is set
        internal bool IsSetJson()
        {
            return !this._json.IsNull();
        }

    }
}