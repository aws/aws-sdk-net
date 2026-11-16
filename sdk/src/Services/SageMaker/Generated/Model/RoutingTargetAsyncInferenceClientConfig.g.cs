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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// How the inference router submits asynchronous requests to the destinations of a routing
    /// target.
    /// </summary>
    public partial class RoutingTargetAsyncInferenceClientConfig
    {
        /// <summary>
        /// Gets and sets the property MaxTimeInBacklogSeconds. 
        /// <para>
        /// The maximum time, in seconds, that a request can wait at a destination before the
        /// inference router moves it to another destination. The default is 900 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 21600)]
        public int? MaxTimeInBacklogSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxTimeInBacklogSeconds property is set.
        /// </summary>
        internal bool IsSetMaxTimeInBacklogSeconds() => this.MaxTimeInBacklogSeconds.HasValue;
    }
}
