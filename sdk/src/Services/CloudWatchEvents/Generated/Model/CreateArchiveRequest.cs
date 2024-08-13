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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
    /// Container for the parameters to the CreateArchive operation.
    /// Creates an archive of events with the specified settings. When you create an archive,
    /// incoming events might not immediately start being sent to the archive. Allow a short
    /// period of time for changes to take effect. If you do not specify a pattern to filter
    /// events sent to the archive, all events are sent to the archive except replayed events.
    /// Replayed events are not sent to an archive.
    /// </summary>
    public partial class CreateArchiveRequest : AmazonCloudWatchEventsRequest
    {
        private string _archiveName;
        private string _description;
        private string _eventPattern;
        private string _eventSourceArn;
        private int? _retentionDays;

        /// <summary>
        /// Gets and sets the property ArchiveName. 
        /// <para>
        /// The name for the archive to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string ArchiveName
        {
            get { return this._archiveName; }
            set { this._archiveName = value; }
        }

        // Check to see if ArchiveName property is set
        internal bool IsSetArchiveName()
        {
            return this._archiveName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// An event pattern to use to filter events sent to the archive.
        /// </para>
        /// </summary>
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the event bus that sends events to the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string EventSourceArn
        {
            get { return this._eventSourceArn; }
            set { this._eventSourceArn = value; }
        }

        // Check to see if EventSourceArn property is set
        internal bool IsSetEventSourceArn()
        {
            return this._eventSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionDays. 
        /// <para>
        /// The number of days to retain events for. Default value is 0. If set to 0, events are
        /// retained indefinitely
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RetentionDays
        {
            get { return this._retentionDays; }
            set { this._retentionDays = value; }
        }

        // Check to see if RetentionDays property is set
        internal bool IsSetRetentionDays()
        {
            return this._retentionDays.HasValue; 
        }

    }
}