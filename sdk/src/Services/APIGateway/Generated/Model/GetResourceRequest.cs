/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetResource operation.
    /// Lists information about a resource.
    /// </summary>
    public partial class GetResourceRequest : AmazonAPIGatewayRequest
    {
        private List<string> _embed = new List<string>();
        private string _resourceId;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property Embed. 
        /// <para>
        /// A query parameter to retrieve the specified resources embedded in the returned <a>Resource</a>
        /// representation in the response. This <code>embed</code> parameter value is a list
        /// of comma-separated strings. Currently, the request supports only retrieval of the
        /// embedded <a>Method</a> resources this way. The query parameter value must be a single-valued
        /// list and contain the <code>"methods"</code> string. For example, <code>GET /restapis/{restapi_id}/resources/{resource_id}?embed=methods</code>.
        /// </para>
        /// </summary>
        public List<string> Embed
        {
            get { return this._embed; }
            set { this._embed = value; }
        }

        // Check to see if Embed property is set
        internal bool IsSetEmbed()
        {
            return this._embed != null && this._embed.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// [Required] The identifier for the <a>Resource</a> resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

    }
}