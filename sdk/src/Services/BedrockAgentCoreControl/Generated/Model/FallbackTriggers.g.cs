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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The conditions that trigger a fallback to the next target. A fallback occurs if the
    /// response matches any of the specified status codes or errors.
    /// </summary>
    public partial class FallbackTriggers
    {
        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// The errors that trigger a fallback. You can specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONNECTION_ERROR</c> – The gateway couldn't connect to the target because the
        /// connection was refused, reset, or timed out. The request didn't reach the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIRST_BYTE_TIMEOUT</c> – The target accepted the connection but didn't return
        /// the first byte of the response within <c>firstByteTimeoutMilliseconds</c>. The gateway
        /// abandons the request before any of the response reaches you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNROUTABLE</c> – The gateway couldn't route the request to the target, for example
        /// because the target doesn't exist or doesn't support the request path. These errors
        /// don't count toward the circuit breaker.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatusCodes. 
        /// <para>
        /// The HTTP status codes returned by the target that trigger a fallback. You can specify
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An exact status code – A three-digit code, such as <c>429</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A class of status codes – The first digit followed by <c>XX</c>, such as <c>5XX</c>,
        /// which matches every code from 500 to 599.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only 4XX and 5XX codes are supported. Throttling by the gateway itself doesn't trigger
        /// a fallback.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> StatusCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusCodes property is set.
        /// </summary>
        internal bool IsSetStatusCodes() => this.StatusCodes != null && (this.StatusCodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
