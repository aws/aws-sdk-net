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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an Amazon Web Services Migration Hub Refactor Spaces application. The account
    /// that owns the environment also owns the applications created inside the environment,
    /// regardless of the account that creates the application. Refactor Spaces provisions
    /// an Amazon API Gateway, API Gateway VPC link, and Network Load Balancer for the application
    /// proxy inside your account.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        private ApiGatewayProxyInput _apiGatewayProxy;
        private string _clientToken;
        private string _environmentIdentifier;
        private string _name;
        private ProxyType _proxyType;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ApiGatewayProxy. 
        /// <para>
        /// A wrapper object holding the API Gateway endpoint type and stage name for the proxy.
        /// 
        /// </para>
        /// </summary>
        public ApiGatewayProxyInput ApiGatewayProxy
        {
            get { return this._apiGatewayProxy; }
            set { this._apiGatewayProxy = value; }
        }

        // Check to see if ApiGatewayProxy property is set
        internal bool IsSetApiGatewayProxy()
        {
            return this._apiGatewayProxy != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The unique identifier of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to use for the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyType. 
        /// <para>
        /// The proxy type of the proxy created within the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProxyType ProxyType
        {
            get { return this._proxyType; }
            set { this._proxyType = value; }
        }

        // Check to see if ProxyType property is set
        internal bool IsSetProxyType()
        {
            return this._proxyType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the application. A tag is a label that you assign to an Amazon
        /// Web Services resource. Each tag consists of a key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=21)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}