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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Information about an API security event, returned by <a>ListEvents</a>, <a>ListEventsByWebACL</a>,
    /// and <a>GetEvent</a>.
    /// </summary>
    public partial class EventDetailSummary
    {
        /// <summary>
        /// Gets and sets the property ApiSecurityEventDetail. 
        /// <para>
        /// The API security details of the event, such as the label, category, confidence, API
        /// patterns, and event actors.
        /// </para>
        /// </summary>
        public ApiSecurityEventDetail ApiSecurityEventDetail { get; set; }

        /// <summary>
        /// Checks to see if the ApiSecurityEventDetail property is set.
        /// </summary>
        internal bool IsSetApiSecurityEventDetail() => this.ApiSecurityEventDetail != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the event ended. This is not populated while the event is ongoing.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventCategory. 
        /// <para>
        /// The category of the event. The only supported value is <c>API_SECURITY</c>.
        /// </para>
        /// </summary>
        public EventCategory EventCategory { get; set; }

        /// <summary>
        /// Checks to see if the EventCategory property is set.
        /// </summary>
        internal bool IsSetEventCategory() => this.EventCategory != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier of the event. You provide this to <a>GetEvent</a> to retrieve
        /// the details of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The current status of the event.
        /// </para>
        /// </summary>
        public EventStatus EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the event was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the protected resource that the event is associated
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the event started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL that the event is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;
    }
}
