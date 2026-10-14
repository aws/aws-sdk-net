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
    /// Configuration for forwarding a partner event source's events through a managed partner
    /// event bus.
    /// </summary>
    public partial class PartnerEventsSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property OnFailureConfiguration. The destination for events that
        /// could not be forwarded, covering both the forwarding target and the managed partner
        /// event bus.
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnFailureConfiguration property is set.
        /// </summary>
        internal bool IsSetOnFailureConfiguration() => this.OnFailureConfiguration != null;

        /// <summary>
        /// Gets and sets the property PartnerBusKmsKeyIdentifier.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PartnerBusKmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerBusKmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerBusKmsKeyIdentifier() => this.PartnerBusKmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property PartnerEventSourceArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string PartnerEventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the PartnerEventSourceArn property is set.
        /// </summary>
        internal bool IsSetPartnerEventSourceArn() => this.PartnerEventSourceArn != null;

        /// <summary>
        /// Gets and sets the property Pattern. A filter pattern, as a JSON string, that defines
        /// which of the partner event source's events are forwarded to the event bus. If no pattern
        /// is specified, all events from the partner event source are forwarded.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 3753)]
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;
    }
}
