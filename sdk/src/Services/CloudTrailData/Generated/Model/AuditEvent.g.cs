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
    /// An event from a source outside of Amazon Web Services that you want CloudTrail to
    /// log.
    /// </summary>
    public partial class AuditEvent
    {
        /// <summary>
        /// Gets and sets the property EventData. 
        /// <para>
        /// The content of an audit event that comes from the event, such as <c>userIdentity</c>,
        /// <c>userAgent</c>, and <c>eventSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventData { get; set; }

        /// <summary>
        /// Checks to see if the EventData property is set.
        /// </summary>
        internal bool IsSetEventData() => this.EventData != null;

        /// <summary>
        /// Gets and sets the property EventDataChecksum. 
        /// <para>
        /// A checksum is a base64-SHA256 algorithm that helps you verify that CloudTrail receives
        /// the event that matches with the checksum. Calculate the checksum by running a command
        /// like the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>printf %s <i>$eventdata</i> | openssl dgst -binary -sha256 | base64</c> 
        /// </para>
        /// </summary>
        public string EventDataChecksum { get; set; }

        /// <summary>
        /// Checks to see if the EventDataChecksum property is set.
        /// </summary>
        internal bool IsSetEventDataChecksum() => this.EventDataChecksum != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The original event ID from the source event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
