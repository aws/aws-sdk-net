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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetResources operation.
    /// Lists information about a collection of Resource resources.
    /// </summary>
    public partial class GetResourcesRequest : AmazonAPIGatewayRequest
    {
        private List<string> _embed = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _limit;
        private string _position;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property Embed. 
        /// <para>
        /// A query parameter used to retrieve the specified resources embedded in the returned
        /// Resources resource in the response. This <c>embed</c> parameter value is a list of
        /// comma-separated strings. Currently, the request supports only retrieval of the embedded
        /// Method resources this way. The query parameter value must be a single-valued list
        /// and contain the <c>"methods"</c> string. For example, <c>GET /restapis/{restapi_id}/resources?embed=methods</c>.
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
            return this._embed != null && (this._embed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The current pagination position in the paged result set.
        /// </para>
        /// </summary>
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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