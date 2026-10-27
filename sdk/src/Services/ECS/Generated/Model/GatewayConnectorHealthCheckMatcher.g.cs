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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The codes that indicate a successful health check response from a target.
    /// </summary>
    public partial class GatewayConnectorHealthCheckMatcher
    {
        /// <summary>
        /// Gets and sets the property GrpcCode. 
        /// <para>
        /// The gRPC codes that indicate a successful response from a target.
        /// </para>
        /// </summary>
        public string GrpcCode { get; set; }

        /// <summary>
        /// Checks to see if the GrpcCode property is set.
        /// </summary>
        internal bool IsSetGrpcCode() => this.GrpcCode != null;

        /// <summary>
        /// Gets and sets the property HttpCode. 
        /// <para>
        /// The HTTP codes that indicate a successful response from a target.
        /// </para>
        /// </summary>
        public string HttpCode { get; set; }

        /// <summary>
        /// Checks to see if the HttpCode property is set.
        /// </summary>
        internal bool IsSetHttpCode() => this.HttpCode != null;
    }
}
