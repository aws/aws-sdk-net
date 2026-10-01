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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLink operation. Updates the configuration
    /// of a link between gateways. <para> Allows you to modify settings and parameters for
    /// an existing link. </para>
    /// </summary>
    public partial class UpdateLinkRequest : AmazonRTBFabricRequest
    {
        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 32)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The unique identifier of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 30)]
        public string LinkId { get; set; }

        /// <summary>
        /// Checks to see if the LinkId property is set.
        /// </summary>
        internal bool IsSetLinkId() => this.LinkId != null;

        /// <summary>
        /// Gets and sets the property LogSettings. 
        /// <para>
        /// Settings for the application logs.
        /// </para>
        /// </summary>
        public LinkLogSettings LogSettings { get; set; }

        /// <summary>
        /// Checks to see if the LogSettings property is set.
        /// </summary>
        internal bool IsSetLogSettings() => this.LogSettings != null;

        /// <summary>
        /// Gets and sets the property TimeoutInMillis. 
        /// <para>
        /// The timeout value in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 5000)]
        public long? TimeoutInMillis { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMillis property is set.
        /// </summary>
        internal bool IsSetTimeoutInMillis() => this.TimeoutInMillis.HasValue;
    }
}
