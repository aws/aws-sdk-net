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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a gRPC route type.
    /// </summary>
    public partial class GrpcRoute
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// An object that represents the action to take if a match is determined.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GrpcRouteAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// An object that represents the criteria for determining a request match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GrpcRouteMatch Match { get; set; }

        /// <summary>
        /// Checks to see if the Match property is set.
        /// </summary>
        internal bool IsSetMatch() => this.Match != null;

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// An object that represents a retry policy.
        /// </para>
        /// </summary>
        public GrpcRetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RetryPolicy property is set.
        /// </summary>
        internal bool IsSetRetryPolicy() => this.RetryPolicy != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// An object that represents types of timeouts. 
        /// </para>
        /// </summary>
        public GrpcTimeout Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout != null;
    }
}
