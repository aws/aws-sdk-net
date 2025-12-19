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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a device where a user has logged into Wickr, containing information about
    /// the device's type, status, and login history.
    /// </summary>
    public partial class BasicDeviceObject
    {
        private string _appId;
        private string _created;
        private string _lastLogin;
        private string _statusText;
        private bool? _suspend;
        private string _type;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique application ID for the Wickr app on this device.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The timestamp when the device first appeared in the Wickr database.
        /// </para>
        /// </summary>
        public string Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created != null;
        }

        /// <summary>
        /// Gets and sets the property LastLogin. 
        /// <para>
        /// The timestamp when the device last successfully logged into Wickr. This is also used
        /// to determine SSO idle time.
        /// </para>
        /// </summary>
        public string LastLogin
        {
            get { return this._lastLogin; }
            set { this._lastLogin = value; }
        }

        // Check to see if LastLogin property is set
        internal bool IsSetLastLogin()
        {
            return this._lastLogin != null;
        }

        /// <summary>
        /// Gets and sets the property StatusText. 
        /// <para>
        /// The current status of the device, either 'Active' or 'Reset' depending on whether
        /// the device is currently active or has been marked for reset.
        /// </para>
        /// </summary>
        public string StatusText
        {
            get { return this._statusText; }
            set { this._statusText = value; }
        }

        // Check to see if StatusText property is set
        internal bool IsSetStatusText()
        {
            return this._statusText != null;
        }

        /// <summary>
        /// Gets and sets the property Suspend. 
        /// <para>
        /// Indicates whether the device is suspended.
        /// </para>
        /// </summary>
        public bool Suspend
        {
            get { return this._suspend.GetValueOrDefault(); }
            set { this._suspend = value; }
        }

        // Check to see if Suspend property is set
        internal bool IsSetSuspend()
        {
            return this._suspend.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The operating system of the device (e.g., 'MacOSX', 'Windows', 'iOS', 'Android').
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}