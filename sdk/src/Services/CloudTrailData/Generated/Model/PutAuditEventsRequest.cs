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
 * Do not modify this file. This file is generated from the cloudtrail-data-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrailData.Model
{
    /// <summary>
    /// Container for the parameters to the PutAuditEvents operation.
    /// Ingests your application events into CloudTrail Lake. A required parameter, <code>auditEvents</code>,
    /// accepts the JSON records (also called <i>payload</i>) of events that you want CloudTrail
    /// to ingest. You can add up to 100 of these events (or up to 1 MB) per <code>PutAuditEvents</code>
    /// request.
    /// </summary>
    public partial class PutAuditEventsRequest : AmazonCloudTrailDataRequest
    {
        private List<AuditEvent> _auditEvents = new List<AuditEvent>();
        private string _channelArn;
        private string _externalId;

        /// <summary>
        /// Gets and sets the property AuditEvents. 
        /// <para>
        /// The JSON payload of events that you want to ingest. You can also point to the JSON
        /// event payload in a file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<AuditEvent> AuditEvents
        {
            get { return this._auditEvents; }
            set { this._auditEvents = value; }
        }

        // Check to see if AuditEvents property is set
        internal bool IsSetAuditEvents()
        {
            return this._auditEvents != null && this._auditEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN or ID (the ARN suffix) of a channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// A unique identifier that is conditionally required when the channel's resource policy
        /// includes an external ID. This value can be any string, such as a passphrase or account
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=1224)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

    }
}