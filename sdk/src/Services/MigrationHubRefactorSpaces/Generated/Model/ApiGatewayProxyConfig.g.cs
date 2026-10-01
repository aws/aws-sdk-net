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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// A wrapper object holding the Amazon API Gateway proxy configuration.
    /// </summary>
    public partial class ApiGatewayProxyConfig
    {
        /// <summary>
        /// Gets and sets the property ApiGatewayId. 
        /// <para>
        /// The resource ID of the API Gateway for the proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string ApiGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayId property is set.
        /// </summary>
        internal bool IsSetApiGatewayId() => this.ApiGatewayId != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of API Gateway endpoint created. 
        /// </para>
        /// </summary>
        public ApiGatewayEndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property NlbArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Load Balancer configured by the API
        /// Gateway proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string NlbArn { get; set; }

        /// <summary>
        /// Checks to see if the NlbArn property is set.
        /// </summary>
        internal bool IsSetNlbArn() => this.NlbArn != null;

        /// <summary>
        /// Gets and sets the property NlbName. 
        /// <para>
        /// The name of the Network Load Balancer that is configured by the API Gateway proxy.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NlbName { get; set; }

        /// <summary>
        /// Checks to see if the NlbName property is set.
        /// </summary>
        internal bool IsSetNlbName() => this.NlbName != null;

        /// <summary>
        /// Gets and sets the property ProxyUrl. 
        /// <para>
        /// The endpoint URL of the API Gateway proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ProxyUrl { get; set; }

        /// <summary>
        /// Checks to see if the ProxyUrl property is set.
        /// </summary>
        internal bool IsSetProxyUrl() => this.ProxyUrl != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the API Gateway stage. The name defaults to <c>prod</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;

        /// <summary>
        /// Gets and sets the property VpcLinkId. 
        /// <para>
        /// The <c>VpcLink</c> ID of the API Gateway proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string VpcLinkId { get; set; }

        /// <summary>
        /// Checks to see if the VpcLinkId property is set.
        /// </summary>
        internal bool IsSetVpcLinkId() => this.VpcLinkId != null;
    }
}
