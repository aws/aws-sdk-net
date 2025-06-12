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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Contains information about an event that was returned by a lookup request. The result
    /// includes a representation of a CloudTrail event.
    /// </summary>
    public partial class Event
    {
        private string _accessKeyId;
        private string _cloudTrailEvent;
        private string _eventId;
        private string _eventName;
        private string _eventSource;
        private DateTime? _eventTime;
        private string _readOnly;
        private List<Resource> _resources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private string _username;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The Amazon Web Services access key ID that was used to sign the request. If the request
        /// was made with temporary security credentials, this is the access key ID of the temporary
        /// credentials.
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudTrailEvent. 
        /// <para>
        /// A JSON string that contains a representation of the event returned.
        /// </para>
        /// </summary>
        public string CloudTrailEvent
        {
            get { return this._cloudTrailEvent; }
            set { this._cloudTrailEvent = value; }
        }

        // Check to see if CloudTrailEvent property is set
        internal bool IsSetCloudTrailEvent()
        {
            return this._cloudTrailEvent != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The CloudTrail ID of the event returned.
        /// </para>
        /// </summary>
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name of the event returned.
        /// </para>
        /// </summary>
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The Amazon Web Services service to which the request was made.
        /// </para>
        /// </summary>
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The date and time of the event returned.
        /// </para>
        /// </summary>
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Information about whether the event is a write event or a read event. 
        /// </para>
        /// </summary>
        public string ReadOnly
        {
            get { return this._readOnly; }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// A list of resources referenced by the event returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// A user name or role name of the requester that called the API in the event returned.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}