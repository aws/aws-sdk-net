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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWebFunction operation.
    /// Creates a web function with an initial revision and endpoint. To create a web function,
    /// you provide the function name, revision configuration (code and service settings),
    /// and endpoint configuration.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>CreateWebFunction</c> permission on the
    /// web function. You don't need separate permissions for the initial revision or endpoint.
    /// </para>
    /// </summary>
    public partial class CreateWebFunctionRequest : AmazonLambdaWebRequest
    {
        private EndpointConfig _endpointConfig;
        private string _functionName;
        private RevisionConfig _revisionConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property EndpointConfig. 
        /// <para>
        /// The configuration for the initial endpoint of the web function.
        /// </para>
        /// </summary>
        public EndpointConfig EndpointConfig
        {
            get { return this._endpointConfig; }
            set { this._endpointConfig = value; }
        }

        // Check to see if EndpointConfig property is set
        internal bool IsSetEndpointConfig()
        {
            return this._endpointConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the web function. The name can contain letters, numbers, hyphens (-),
        /// and underscores (_), and can't begin or end with a hyphen or an underscore. The length
        /// constraint applies only to the full ARN. If you specify only the function name, it
        /// is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionConfig. 
        /// <para>
        /// The configuration for the initial revision of the web function, including code and
        /// service settings.
        /// </para>
        /// </summary>
        public RevisionConfig RevisionConfig
        {
            get { return this._revisionConfig; }
            set { this._revisionConfig = value; }
        }

        // Check to see if RevisionConfig property is set
        internal bool IsSetRevisionConfig()
        {
            return this._revisionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to apply to the web function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}