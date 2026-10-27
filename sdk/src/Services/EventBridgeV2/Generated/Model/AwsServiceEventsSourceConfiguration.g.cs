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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Configuration for forwarding a single AWS service's events from the account's default
    /// event bus.
    /// </summary>
    public partial class AwsServiceEventsSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property AwsService.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AwsService { get; set; }

        /// <summary>
        /// Checks to see if the AwsService property is set.
        /// </summary>
        internal bool IsSetAwsService() => this.AwsService != null;

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration. The destination for events that
        /// could not be forwarded.
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnFailureConfiguration property is set.
        /// </summary>
        internal bool IsSetOnFailureConfiguration() => this.OnFailureConfiguration != null;

        /// <summary>
        /// Gets and sets the property Pattern. A filter pattern, as a JSON string, that defines
        /// which of the service's events are forwarded to the event bus. Do not include source,
        /// account, or region as top-level fields. If no pattern is specified, all events from
        /// the service are forwarded.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 3753)]
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;
    }
}
