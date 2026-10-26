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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This is the response object from the DescribeArchive operation.
    /// </summary>
    public partial class DescribeArchiveResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ArchiveArn. 
        /// <para>
        /// The ARN of the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ArchiveArn { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveArn property is set.
        /// </summary>
        internal bool IsSetArchiveArn() => this.ArchiveArn != null;

        /// <summary>
        /// Gets and sets the property ArchiveName. 
        /// <para>
        /// The name of the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 48)]
        public string ArchiveName { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveName property is set.
        /// </summary>
        internal bool IsSetArchiveName() => this.ArchiveName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the archive was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// The number of events in the archive.
        /// </para>
        /// </summary>
        public long? EventCount { get; set; }

        /// <summary>
        /// Checks to see if the EventCount property is set.
        /// </summary>
        internal bool IsSetEventCount() => this.EventCount.HasValue;

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The event pattern used to filter events sent to the archive.
        /// </para>
        /// </summary>
        public string EventPattern { get; set; }

        /// <summary>
        /// Checks to see if the EventPattern property is set.
        /// </summary>
        internal bool IsSetEventPattern() => this.EventPattern != null;

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the event source associated with the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string EventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceArn property is set.
        /// </summary>
        internal bool IsSetEventSourceArn() => this.EventSourceArn != null;

        /// <summary>
        /// Gets and sets the property RetentionDays. 
        /// <para>
        /// The number of days to retain events for in the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionDays property is set.
        /// </summary>
        internal bool IsSetRetentionDays() => this.RetentionDays.HasValue;

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the archive in bytes.
        /// </para>
        /// </summary>
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeBytes property is set.
        /// </summary>
        internal bool IsSetSizeBytes() => this.SizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the archive.
        /// </para>
        /// </summary>
        public ArchiveState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason that the archive is in the state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
