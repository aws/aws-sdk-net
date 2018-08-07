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
    /// Apple Distribution Push Notification Service channel definition.
    /// </summary>
    public partial class APNSChannelResponse
    {
        private string _applicationId;
        private string _creationDate;
        private string _defaultAuthenticationMethod;
        private bool? _enabled;
        private bool? _hasCredential;
        private bool? _hasTokenKey;
        private string _id;
        private bool? _isArchived;
        private string _lastModifiedBy;
        private string _lastModifiedDate;
        private string _platform;
        private int? _version;

        /// <summary>
        /// Gets and sets the property ApplicationId. The ID of the application that the channel
        /// applies to.
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
        /// Gets and sets the property CreationDate. The date and time when this channel was created.
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
        /// Gets and sets the property DefaultAuthenticationMethod. The default authentication
        /// method used for APNs.
        /// </summary>
        public string DefaultAuthenticationMethod
        {
            get { return this._defaultAuthenticationMethod; }
            set { this._defaultAuthenticationMethod = value; }
        }

        // Check to see if DefaultAuthenticationMethod property is set
        internal bool IsSetDefaultAuthenticationMethod()
        {
            return this._defaultAuthenticationMethod != null;
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
        /// Gets and sets the property HasTokenKey. Indicates whether the channel is configured
        /// with a key for APNs token authentication. Provide a token key by setting the TokenKey
        /// attribute.
        /// </summary>
        public bool HasTokenKey
        {
            get { return this._hasTokenKey.GetValueOrDefault(); }
            set { this._hasTokenKey = value; }
        }

        // Check to see if HasTokenKey property is set
        internal bool IsSetHasTokenKey()
        {
            return this._hasTokenKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. (Deprecated) An identifier for the channel. Retained
        /// for backwards compatibility.
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
        /// Gets and sets the property IsArchived. Indicates whether or not the channel is archived.
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
        /// Gets and sets the property LastModifiedBy. The user who last updated this channel.
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
        /// Gets and sets the property LastModifiedDate. The date and time when this channel was
        /// last modified.
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
        /// Gets and sets the property Platform. The platform type. For this channel, the value
        /// is always "ADM."
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
        /// Gets and sets the property Version. The channel version.
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