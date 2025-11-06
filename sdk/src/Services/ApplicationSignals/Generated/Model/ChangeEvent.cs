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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Represents a change event that occurred in the system, such as deployments, configuration
    /// changes, or other operational events that may impact service performance.
    /// </summary>
    public partial class ChangeEvent
    {
        private string _accountId;
        private ChangeEventType _changeEventType;
        private Dictionary<string, string> _entity = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _eventId;
        private string _eventName;
        private string _region;
        private DateTime? _timestamp;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID where the change event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeEventType. 
        /// <para>
        /// The type of change that occurred, such as "Deployment", "Configuration", or "Infrastructure".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeEventType ChangeEventType
        {
            get { return this._changeEventType; }
            set { this._changeEventType = value; }
        }

        // Check to see if ChangeEventType property is set
        internal bool IsSetChangeEventType()
        {
            return this._changeEventType != null;
        }

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The entity or resource that was changed, such as a service, deployment, or configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> Entity
        {
            get { return this._entity; }
            set { this._entity = value; }
        }

        // Check to see if Entity property is set
        internal bool IsSetEntity()
        {
            return this._entity != null && (this._entity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier for the change event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A descriptive name for the change event that provides context about what changed.
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS region where the change event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp when the change event occurred, expressed as the number of milliseconds
        /// since January 1, 1970, 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user or system that initiated the change event.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}