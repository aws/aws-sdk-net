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

namespace Amazon.CloudTrailData.Model
{
    /// <summary>
    /// Container for the parameters to the PutAuditEvents operation. Ingests your application
    /// events into CloudTrail Lake. A required parameter, <c>auditEvents</c>, accepts the
    /// JSON records (also called <i>payload</i>) of events that you want CloudTrail to ingest.
    /// You can add up to 100 of these events (or up to 1 MB) per <c>PutAuditEvents</c> request.
    /// </summary>
    public partial class PutAuditEventsRequest : AmazonCloudTrailDataRequest
    {
        /// <summary>
        /// Gets and sets the property AuditEvents. 
        /// <para>
        /// The JSON payload of events that you want to ingest. You can also point to the JSON
        /// event payload in a file.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<AuditEvent> AuditEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditEvent>() : null;

        /// <summary>
        /// Checks to see if the AuditEvents property is set.
        /// </summary>
        internal bool IsSetAuditEvents() => this.AuditEvents != null && (this.AuditEvents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN or ID (the ARN suffix) of a channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// A unique identifier that is conditionally required when the channel's resource policy
        /// includes an external ID. This value can be any string, such as a passphrase or account
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 1224)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;
    }
}
