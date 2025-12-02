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
    /// Specifies which operations from an API Gateway REST API are exposed as tools. Tool
    /// names and descriptions are derived from the operationId and description fields in
    /// the API's exported OpenAPI specification.
    /// </summary>
    public partial class ApiGatewayToolFilter
    {
        private string _filterPath;
        private List<string> _methods = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FilterPath. 
        /// <para>
        /// Resource path to match in the REST API. Supports exact paths (for example, <c>/pets</c>)
        /// or wildcard paths (for example, <c>/pets/*</c> to match all paths under <c>/pets</c>).
        /// Must match existing paths in the REST API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilterPath
        {
            get { return this._filterPath; }
            set { this._filterPath = value; }
        }

        // Check to see if FilterPath property is set
        internal bool IsSetFilterPath()
        {
            return this._filterPath != null;
        }

        /// <summary>
        /// Gets and sets the property Methods. 
        /// <para>
        /// The methods to filter for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Methods
        {
            get { return this._methods; }
            set { this._methods = value; }
        }

        // Check to see if Methods property is set
        internal bool IsSetMethods()
        {
            return this._methods != null && (this._methods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}