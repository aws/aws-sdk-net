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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Information about a user's device that they've registered for device SRP authentication
    /// in your application. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-device-tracking.html">Working
    /// with user devices in your user pool</a>.
    /// </summary>
    public partial class DeviceType
    {
        private List<AttributeType> _deviceAttributes = AWSConfigs.InitializeCollections ? new List<AttributeType>() : null;
        private DateTime? _deviceCreateDate;
        private string _deviceKey;
        private DateTime? _deviceLastAuthenticatedDate;
        private DateTime? _deviceLastModifiedDate;

        /// <summary>
        /// Gets and sets the property DeviceAttributes. 
        /// <para>
        /// Metadata about a user's device, like name and last-access source IP.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeType> DeviceAttributes
        {
            get { return this._deviceAttributes; }
            set { this._deviceAttributes = value; }
        }

        // Check to see if DeviceAttributes property is set
        internal bool IsSetDeviceAttributes()
        {
            return this._deviceAttributes != null && (this._deviceAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeviceCreateDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? DeviceCreateDate
        {
            get { return this._deviceCreateDate; }
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
        /// The device key, for example <c>us-west-2_EXAMPLE-a1b2c3d4-5678-90ab-cdef-EXAMPLE22222</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
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
        /// The date when the user last signed in with the device.
        /// </para>
        /// </summary>
        public DateTime? DeviceLastAuthenticatedDate
        {
            get { return this._deviceLastAuthenticatedDate; }
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
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? DeviceLastModifiedDate
        {
            get { return this._deviceLastModifiedDate; }
            set { this._deviceLastModifiedDate = value; }
        }

        // Check to see if DeviceLastModifiedDate property is set
        internal bool IsSetDeviceLastModifiedDate()
        {
            return this._deviceLastModifiedDate.HasValue; 
        }

    }
}