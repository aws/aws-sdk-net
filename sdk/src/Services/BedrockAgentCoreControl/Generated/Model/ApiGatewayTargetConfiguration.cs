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
    /// The configuration for an Amazon API Gateway target.
    /// </summary>
    public partial class ApiGatewayTargetConfiguration
    {
        private ApiGatewayToolConfiguration _apiGatewayToolConfiguration;
        private string _restApiId;
        private string _stage;

        /// <summary>
        /// Gets and sets the property ApiGatewayToolConfiguration. 
        /// <para>
        /// The configuration for defining REST API tool filters and overrides for the gateway
        /// target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApiGatewayToolConfiguration ApiGatewayToolConfiguration
        {
            get { return this._apiGatewayToolConfiguration; }
            set { this._apiGatewayToolConfiguration = value; }
        }

        // Check to see if ApiGatewayToolConfiguration property is set
        internal bool IsSetApiGatewayToolConfiguration()
        {
            return this._apiGatewayToolConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The ID of the API Gateway REST API.
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

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The ID of the stage of the REST API to add as a target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}