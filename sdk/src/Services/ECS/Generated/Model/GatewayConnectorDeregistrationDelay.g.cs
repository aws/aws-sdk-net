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
    /// The amount of time to allow in-flight requests to complete before a deregistering
    /// target is removed.
    /// </summary>
    public partial class GatewayConnectorDeregistrationDelay
    {
        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, to wait before a deregistering target is removed.
        /// A value of <c>0</c> removes the target immediately. The valid range is 0-3600 seconds.
        /// The default value is 300 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3600)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;
    }
}
