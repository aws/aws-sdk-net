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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApiGatewayToolConfiguration. 
        /// <para>
        /// The configuration for defining REST API tool filters and overrides for the gateway
        /// target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApiGatewayToolConfiguration ApiGatewayToolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayToolConfiguration property is set.
        /// </summary>
        internal bool IsSetApiGatewayToolConfiguration() => this.ApiGatewayToolConfiguration != null;

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The ID of the API Gateway REST API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestApiId { get; set; }

        /// <summary>
        /// Checks to see if the RestApiId property is set.
        /// </summary>
        internal bool IsSetRestApiId() => this.RestApiId != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The ID of the stage of the REST API to add as a target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
