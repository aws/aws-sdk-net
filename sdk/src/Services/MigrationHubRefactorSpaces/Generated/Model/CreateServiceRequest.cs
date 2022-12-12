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
    /// Container for the parameters to the CreateService operation.
    /// Creates an Amazon Web Services Migration Hub Refactor Spaces service. The account
    /// owner of the service is always the environment owner, regardless of which account
    /// in the environment creates the service. Services have either a URL endpoint in a virtual
    /// private cloud (VPC), or a Lambda function endpoint.
    /// 
    ///  <important> 
    /// <para>
    /// If an Amazon Web Services resource is launched in a service VPC, and you want it to
    /// be accessible to all of an environment’s services with VPCs and routes, apply the
    /// <code>RefactorSpacesSecurityGroup</code> to the resource. Alternatively, to add more
    /// cross-account constraints, apply your own security group.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateServiceRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        private string _applicationIdentifier;
        private string _clientToken;
        private string _description;
        private ServiceEndpointType _endpointType;
        private string _environmentIdentifier;
        private LambdaEndpointInput _lambdaEndpoint;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private UrlEndpointInput _urlEndpoint;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The ID of the application which the service is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint to use for the service. The type can be a URL in a VPC or an
        /// Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceEndpointType EndpointType
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
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment in which the service is created.
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
        /// Gets and sets the property LambdaEndpoint. 
        /// <para>
        /// The configuration for the Lambda endpoint type.
        /// </para>
        /// </summary>
        public LambdaEndpointInput LambdaEndpoint
        {
            get { return this._lambdaEndpoint; }
            set { this._lambdaEndpoint = value; }
        }

        // Check to see if LambdaEndpoint property is set
        internal bool IsSetLambdaEndpoint()
        {
            return this._lambdaEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the service. A tag is a label that you assign to an Amazon Web
        /// Services resource. Each tag consists of a key-value pair.. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property UrlEndpoint. 
        /// <para>
        /// The configuration for the URL endpoint type. When creating a route to a service, Refactor
        /// Spaces automatically resolves the address in the <code>UrlEndpointInput</code> object
        /// URL when the Domain Name System (DNS) time-to-live (TTL) expires, or every 60 seconds
        /// for TTLs less than 60 seconds.
        /// </para>
        /// </summary>
        public UrlEndpointInput UrlEndpoint
        {
            get { return this._urlEndpoint; }
            set { this._urlEndpoint = value; }
        }

        // Check to see if UrlEndpoint property is set
        internal bool IsSetUrlEndpoint()
        {
            return this._urlEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
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