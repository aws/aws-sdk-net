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
    /// A wrapper object holding the Amazon API Gateway endpoint input.
    /// </summary>
    public partial class ApiGatewayProxyInput
    {
        private ApiGatewayEndpointType _endpointType;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint to use for the API Gateway proxy. If no value is specified in
        /// the request, the value is set to <c>REGIONAL</c> by default.
        /// </para>
        ///  
        /// <para>
        /// If the value is set to <c>PRIVATE</c> in the request, this creates a private API endpoint
        /// that is isolated from the public internet. The private endpoint can only be accessed
        /// by using Amazon Virtual Private Cloud (Amazon VPC) interface endpoints for the Amazon
        /// API Gateway that has been granted access. For more information about creating a private
        /// connection with Refactor Spaces and interface endpoint (Amazon Web Services PrivateLink)
        /// availability, see <a href="https://docs.aws.amazon.com/migrationhub-refactor-spaces/latest/userguide/vpc-interface-endpoints.html">Access
        /// Refactor Spaces using an interface endpoint (Amazon Web Services PrivateLink)</a>.
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

    }
}