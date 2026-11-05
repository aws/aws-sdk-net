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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// An alert on a channel
    /// </summary>
    public partial class ChannelAlert
    {
        /// <summary>
        /// Gets and sets the property AlertType. The type of the alert
        /// </summary>
        public string AlertType { get; set; }

        /// <summary>
        /// Checks to see if the AlertType property is set.
        /// </summary>
        internal bool IsSetAlertType() => this.AlertType != null;

        /// <summary>
        /// Gets and sets the property ClearedTimestamp. The time when the alert was cleared
        /// </summary>
        public DateTime? ClearedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ClearedTimestamp property is set.
        /// </summary>
        internal bool IsSetClearedTimestamp() => this.ClearedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Id. The unique ID for this alert instance
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Message. The user facing alert message which can have more
        /// context
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property PipelineId. The ID of the pipeline this alert is associated
        /// with
        /// </summary>
        public string PipelineId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineId property is set.
        /// </summary>
        internal bool IsSetPipelineId() => this.PipelineId != null;

        /// <summary>
        /// Gets and sets the property SetTimestamp. The time when the alert was set
        /// </summary>
        public DateTime? SetTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SetTimestamp property is set.
        /// </summary>
        internal bool IsSetSetTimestamp() => this.SetTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property State. The state of the alert
        /// </summary>
        public ChannelAlertState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
