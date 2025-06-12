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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Describes the metadata for a source event.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-events-structure.html">Event
    /// structure reference</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SourceEventMetadata
    {
        private DateTime? _eventOccurrenceTime;
        private string _eventOriginRegion;
        private string _eventType;
        private string _eventTypeVersion;
        private string _relatedAccount;
        private List<Resource> _relatedResources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private string _source;
        private string _sourceEventId;

        /// <summary>
        /// Gets and sets the property EventOccurrenceTime. 
        /// <para>
        /// The date and time the source event occurred. This is based on the Source Event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventOccurrenceTime
        {
            get { return this._eventOccurrenceTime; }
            set { this._eventOccurrenceTime = value; }
        }

        // Check to see if EventOccurrenceTime property is set
        internal bool IsSetEventOccurrenceTime()
        {
            return this._eventOccurrenceTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventOriginRegion. 
        /// <para>
        /// The Region the event originated from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string EventOriginRegion
        {
            get { return this._eventOriginRegion; }
            set { this._eventOriginRegion = value; }
        }

        // Check to see if EventOriginRegion property is set
        internal bool IsSetEventOriginRegion()
        {
            return this._eventOriginRegion != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event. For example, an Amazon CloudWatch state change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeVersion. 
        /// <para>
        /// The version of the type of event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public string EventTypeVersion
        {
            get { return this._eventTypeVersion; }
            set { this._eventTypeVersion = value; }
        }

        // Check to see if EventTypeVersion property is set
        internal bool IsSetEventTypeVersion()
        {
            return this._eventTypeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedAccount. 
        /// <para>
        /// The primary Amazon Web Services account of <c>SourceEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelatedAccount
        {
            get { return this._relatedAccount; }
            set { this._relatedAccount = value; }
        }

        // Check to see if RelatedAccount property is set
        internal bool IsSetRelatedAccount()
        {
            return this._relatedAccount != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedResources. 
        /// <para>
        /// A list of resources related to this <c>NotificationEvent</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Resource> RelatedResources
        {
            get { return this._relatedResources; }
            set { this._relatedResources = value; }
        }

        // Check to see if RelatedResources property is set
        internal bool IsSetRelatedResources()
        {
            return this._relatedResources != null && (this._relatedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Web Services service the event originates from. For example <c>aws.cloudwatch</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEventId. 
        /// <para>
        /// The source event id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceEventId
        {
            get { return this._sourceEventId; }
            set { this._sourceEventId = value; }
        }

        // Check to see if SourceEventId property is set
        internal bool IsSetSourceEventId()
        {
            return this._sourceEventId != null;
        }

    }
}