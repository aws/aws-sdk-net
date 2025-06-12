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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetDeployment operation.
    /// Gets information about a Deployment resource.
    /// </summary>
    public partial class GetDeploymentRequest : AmazonAPIGatewayRequest
    {
        private string _deploymentId;
        private List<string> _embed = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the Deployment resource to get information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property Embed. 
        /// <para>
        /// A query parameter to retrieve the specified embedded resources of the returned Deployment
        /// resource in the response. In a REST API call, this <c>embed</c> parameter value is
        /// a list of comma-separated strings, as in <c>GET /restapis/{restapi_id}/deployments/{deployment_id}?embed=var1,var2</c>.
        /// The SDK and other platform-dependent libraries might use a different format for the
        /// list. Currently, this request supports only retrieval of the embedded API summary
        /// this way. Hence, the parameter value must be a single-valued list containing only
        /// the <c>"apisummary"</c> string. For example, <c>GET /restapis/{restapi_id}/deployments/{deployment_id}?embed=apisummary</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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