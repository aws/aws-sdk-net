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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEndpoint operation. Creates a new endpoint
    /// for an application or updates the settings and attributes of an existing endpoint
    /// for an application. You can also use this operation to define custom attributes for
    /// an endpoint. If an update includes one or more values for a custom attribute, Amazon
    /// Pinpoint replaces (overwrites) any existing values with the new values.
    /// </summary>
    public partial class UpdateEndpointRequest : AmazonPinpointRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The case insensitive unique identifier for the endpoint. The identifier can't contain
        /// <c>$</c>, <c>{</c> or <c>}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property EndpointRequest.
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointRequest EndpointRequest { get; set; }

        /// <summary>
        /// Checks to see if the EndpointRequest property is set.
        /// </summary>
        internal bool IsSetEndpointRequest() => this.EndpointRequest != null;
    }
}
