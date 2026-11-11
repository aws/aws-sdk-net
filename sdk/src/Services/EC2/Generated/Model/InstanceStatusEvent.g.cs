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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a scheduled event for an instance.
    /// </summary>
    public partial class InstanceStatusEvent
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The event code.
        /// </para>
        /// </summary>
        public EventCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the event.
        /// </para>
        ///  
        /// <para>
        /// After a scheduled event is completed, it can still be described for up to a week.
        /// If the event has been completed, this description starts with the following text:
        /// [Completed].
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceEventId. 
        /// <para>
        /// The ID of the event.
        /// </para>
        /// </summary>
        public string InstanceEventId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceEventId property is set.
        /// </summary>
        internal bool IsSetInstanceEventId() => this.InstanceEventId != null;

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The latest scheduled end time for the event.
        /// </para>
        /// </summary>
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotAfter property is set.
        /// </summary>
        internal bool IsSetNotAfter() => this.NotAfter.HasValue;

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The earliest scheduled start time for the event.
        /// </para>
        /// </summary>
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotBefore property is set.
        /// </summary>
        internal bool IsSetNotBefore() => this.NotBefore.HasValue;

        /// <summary>
        /// Gets and sets the property NotBeforeDeadline. 
        /// <para>
        /// The deadline for starting the event.
        /// </para>
        /// </summary>
        public DateTime? NotBeforeDeadline { get; set; }

        /// <summary>
        /// Checks to see if the NotBeforeDeadline property is set.
        /// </summary>
        internal bool IsSetNotBeforeDeadline() => this.NotBeforeDeadline.HasValue;
    }
}
