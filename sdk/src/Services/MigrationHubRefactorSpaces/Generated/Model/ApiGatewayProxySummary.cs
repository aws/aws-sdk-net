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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
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
    /// A wrapper object holding the Amazon API Gateway proxy summary.
    /// </summary>
    public partial class ApiGatewayProxySummary
    {
        private string _apiGatewayId;
        private ApiGatewayEndpointType _endpointType;
        private string _nlbArn;
        private string _nlbName;
        private string _proxyUrl;
        private string _stageName;
        private string _vpcLinkId;

        /// <summary>
        /// Gets and sets the property ApiGatewayId. 
        /// <para>
        /// The resource ID of the API Gateway for the proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string ApiGatewayId
        {
            get { return this._apiGatewayId; }
            set { this._apiGatewayId = value; }
        }

        // Check to see if ApiGatewayId property is set
        internal bool IsSetApiGatewayId()
        {
            return this._apiGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of API Gateway endpoint created. 
        /// </para>
        /// </summary>
        public ApiGatewayEndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property NlbArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Load Balancer configured by the API
        /// Gateway proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string NlbArn
        {
            get { return this._nlbArn; }
            set { this._nlbArn = value; }
        }

        // Check to see if NlbArn property is set
        internal bool IsSetNlbArn()
        {
            return this._nlbArn != null;
        }

        /// <summary>
        /// Gets and sets the property NlbName. 
        /// <para>
        /// The name of the Network Load Balancer that is configured by the API Gateway proxy.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NlbName
        {
            get { return this._nlbName; }
            set { this._nlbName = value; }
        }

        // Check to see if NlbName property is set
        internal bool IsSetNlbName()
        {
            return this._nlbName != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyUrl. 
        /// <para>
        /// The endpoint URL of the API Gateway proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ProxyUrl
        {
            get { return this._proxyUrl; }
            set { this._proxyUrl = value; }
        }

        // Check to see if ProxyUrl property is set
        internal bool IsSetProxyUrl()
        {
            return this._proxyUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the API Gateway stage. The name defaults to <c>prod</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcLinkId. 
        /// <para>
        /// The <c>VpcLink</c> ID of the API Gateway proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string VpcLinkId
        {
            get { return this._vpcLinkId; }
            set { this._vpcLinkId = value; }
        }

        // Check to see if VpcLinkId property is set
        internal bool IsSetVpcLinkId()
        {
            return this._vpcLinkId != null;
        }

    }
}