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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the status and settings of the APNs (Apple Push Notification
    /// service) channel for an application.
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
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the APNs channel applies to.
        /// </para>
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the APNs channel was enabled.
        /// </para>
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
        /// Gets and sets the property DefaultAuthenticationMethod. 
        /// <para>
        /// The default authentication method that Amazon Pinpoint uses to authenticate with APNs
        /// for this channel, key or certificate.
        /// </para>
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the APNs channel is enabled for the application.
        /// </para>
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
        /// Gets and sets the property HasCredential. 
        /// <para>
        /// (Not used) This property is retained only for backward compatibility.
        /// </para>
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
        /// Gets and sets the property HasTokenKey. 
        /// <para>
        /// Specifies whether the APNs channel is configured to communicate with APNs by using
        /// APNs tokens. To provide an authentication key for APNs tokens, set the TokenKey property
        /// of the channel.
        /// </para>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// (Deprecated) An identifier for the APNs channel. This property is retained only for
        /// backward compatibility.
        /// </para>
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
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Specifies whether the APNs channel is archived.
        /// </para>
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
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The user who last modified the APNs channel.
        /// </para>
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the APNs channel was last modified.
        /// </para>
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
        /// Gets and sets the property Platform.  
        /// <para>
        /// The type of messaging or notification platform for the channel. For the APNs channel,
        /// this value is APNS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the APNs channel.
        /// </para>
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