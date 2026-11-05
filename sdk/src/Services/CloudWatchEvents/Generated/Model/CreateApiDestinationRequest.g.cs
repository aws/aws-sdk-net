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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApiDestination operation. Creates an API
    /// destination, which is an HTTP invocation endpoint configured as a target for events.
    /// </summary>
    public partial class CreateApiDestinationRequest : AmazonCloudWatchEventsRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The ARN of the connection to use for the API destination. The destination endpoint
        /// must support the authorization type specified for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the API destination to create.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The method to use for the request to the HTTP invocation endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApiDestinationHttpMethod HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property InvocationEndpoint. 
        /// <para>
        /// The URL to the HTTP invocation endpoint for the API destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string InvocationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the InvocationEndpoint property is set.
        /// </summary>
        internal bool IsSetInvocationEndpoint() => this.InvocationEndpoint != null;

        /// <summary>
        /// Gets and sets the property InvocationRateLimitPerSecond. 
        /// <para>
        /// The maximum number of requests per second to send to the HTTP invocation endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? InvocationRateLimitPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the InvocationRateLimitPerSecond property is set.
        /// </summary>
        internal bool IsSetInvocationRateLimitPerSecond() => this.InvocationRateLimitPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the API destination to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
