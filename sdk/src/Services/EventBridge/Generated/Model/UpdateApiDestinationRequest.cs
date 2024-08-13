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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApiDestination operation.
    /// Updates an API destination.
    /// </summary>
    public partial class UpdateApiDestinationRequest : AmazonEventBridgeRequest
    {
        private string _connectionArn;
        private string _description;
        private ApiDestinationHttpMethod _httpMethod;
        private string _invocationEndpoint;
        private int? _invocationRateLimitPerSecond;
        private string _name;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The ARN of the connection to use for the API destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The name of the API destination to update.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The method to use for the API destination.
        /// </para>
        /// </summary>
        public ApiDestinationHttpMethod HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationEndpoint. 
        /// <para>
        /// The URL to the endpoint to use for the API destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string InvocationEndpoint
        {
            get { return this._invocationEndpoint; }
            set { this._invocationEndpoint = value; }
        }

        // Check to see if InvocationEndpoint property is set
        internal bool IsSetInvocationEndpoint()
        {
            return this._invocationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationRateLimitPerSecond. 
        /// <para>
        /// The maximum number of invocations per second to send to the API destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? InvocationRateLimitPerSecond
        {
            get { return this._invocationRateLimitPerSecond; }
            set { this._invocationRateLimitPerSecond = value; }
        }

        // Check to see if InvocationRateLimitPerSecond property is set
        internal bool IsSetInvocationRateLimitPerSecond()
        {
            return this._invocationRateLimitPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API destination to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}