/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// SMS Channel Response.
    /// </summary>
    public partial class SMSChannelResponse
    {
        private string _applicationId;
        private string _creationDate;
        private bool? _enabled;
        private bool? _hasCredential;
        private string _id;
        private bool? _isArchived;
        private string _lastModifiedBy;
        private string _lastModifiedDate;
        private string _platform;
        private int? _promotionalMessagesPerSecond;
        private string _senderId;
        private string _shortCode;
        private int? _transactionalMessagesPerSecond;
        private int? _version;

        /// <summary>
        /// Gets and sets the property ApplicationId. The unique ID of the application to which
        /// the SMS channel belongs.
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. The date that the settings were last updated
        /// in ISO 8601 format.
        /// </summary>
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. If the channel is enabled for sending messages.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HasCredential. Not used. Retained for backwards compatibility.
        /// </summary>
        public bool HasCredential
        {
            get { return this._hasCredential.GetValueOrDefault(); }
            set { this._hasCredential = value; }
        }

        // Check to see if HasCredential property is set
        internal bool IsSetHasCredential()
        {
            return this._hasCredential.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. Channel ID. Not used, only for backwards compatibility.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsArchived. Is this channel archived
        /// </summary>
        public bool IsArchived
        {
            get { return this._isArchived.GetValueOrDefault(); }
            set { this._isArchived = value; }
        }

        // Check to see if IsArchived property is set
        internal bool IsSetIsArchived()
        {
            return this._isArchived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. Who last updated this entry
        /// </summary>
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. Last date this was updated
        /// </summary>
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. Platform type. Will be "SMS"
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property PromotionalMessagesPerSecond. Promotional messages per
        /// second that can be sent
        /// </summary>
        public int PromotionalMessagesPerSecond
        {
            get { return this._promotionalMessagesPerSecond.GetValueOrDefault(); }
            set { this._promotionalMessagesPerSecond = value; }
        }

        // Check to see if PromotionalMessagesPerSecond property is set
        internal bool IsSetPromotionalMessagesPerSecond()
        {
            return this._promotionalMessagesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SenderId. Sender identifier of your messages.
        /// </summary>
        public string SenderId
        {
            get { return this._senderId; }
            set { this._senderId = value; }
        }

        // Check to see if SenderId property is set
        internal bool IsSetSenderId()
        {
            return this._senderId != null;
        }

        /// <summary>
        /// Gets and sets the property ShortCode. The short code registered with the phone provider.
        /// </summary>
        public string ShortCode
        {
            get { return this._shortCode; }
            set { this._shortCode = value; }
        }

        // Check to see if ShortCode property is set
        internal bool IsSetShortCode()
        {
            return this._shortCode != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionalMessagesPerSecond. Transactional messages
        /// per second that can be sent
        /// </summary>
        public int TransactionalMessagesPerSecond
        {
            get { return this._transactionalMessagesPerSecond.GetValueOrDefault(); }
            set { this._transactionalMessagesPerSecond = value; }
        }

        // Check to see if TransactionalMessagesPerSecond property is set
        internal bool IsSetTransactionalMessagesPerSecond()
        {
            return this._transactionalMessagesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. Version of channel
        /// </summary>
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}