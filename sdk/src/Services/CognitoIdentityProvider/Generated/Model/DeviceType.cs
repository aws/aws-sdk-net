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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The device type.
    /// </summary>
    public partial class DeviceType
    {
        private List<AttributeType> _deviceAttributes = new List<AttributeType>();
        private DateTime? _deviceCreateDate;
        private string _deviceKey;
        private DateTime? _deviceLastAuthenticatedDate;
        private DateTime? _deviceLastModifiedDate;

        /// <summary>
        /// Gets and sets the property DeviceAttributes. 
        /// <para>
        /// The device attributes.
        /// </para>
        /// </summary>
        public List<AttributeType> DeviceAttributes
        {
            get { return this._deviceAttributes; }
            set { this._deviceAttributes = value; }
        }

        // Check to see if DeviceAttributes property is set
        internal bool IsSetDeviceAttributes()
        {
            return this._deviceAttributes != null && this._deviceAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceCreateDate. 
        /// <para>
        /// The creation date of the device.
        /// </para>
        /// </summary>
        public DateTime DeviceCreateDate
        {
            get { return this._deviceCreateDate.GetValueOrDefault(); }
            set { this._deviceCreateDate = value; }
        }

        // Check to see if DeviceCreateDate property is set
        internal bool IsSetDeviceCreateDate()
        {
            return this._deviceCreateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceKey. 
        /// <para>
        /// The device key.
        /// </para>
        /// </summary>
        public string DeviceKey
        {
            get { return this._deviceKey; }
            set { this._deviceKey = value; }
        }

        // Check to see if DeviceKey property is set
        internal bool IsSetDeviceKey()
        {
            return this._deviceKey != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceLastAuthenticatedDate. 
        /// <para>
        /// The date in which the device was last authenticated.
        /// </para>
        /// </summary>
        public DateTime DeviceLastAuthenticatedDate
        {
            get { return this._deviceLastAuthenticatedDate.GetValueOrDefault(); }
            set { this._deviceLastAuthenticatedDate = value; }
        }

        // Check to see if DeviceLastAuthenticatedDate property is set
        internal bool IsSetDeviceLastAuthenticatedDate()
        {
            return this._deviceLastAuthenticatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceLastModifiedDate. 
        /// <para>
        /// The last modified date of the device.
        /// </para>
        /// </summary>
        public DateTime DeviceLastModifiedDate
        {
            get { return this._deviceLastModifiedDate.GetValueOrDefault(); }
            set { this._deviceLastModifiedDate = value; }
        }

        // Check to see if DeviceLastModifiedDate property is set
        internal bool IsSetDeviceLastModifiedDate()
        {
            return this._deviceLastModifiedDate.HasValue; 
        }

    }
}