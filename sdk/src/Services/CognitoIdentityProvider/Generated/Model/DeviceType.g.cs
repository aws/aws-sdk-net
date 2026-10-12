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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DeviceAttributes. 
        /// <para>
        /// Metadata about a user's device, like name and last-access source IP.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeType> DeviceAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeType>() : null;

        /// <summary>
        /// Checks to see if the DeviceAttributes property is set.
        /// </summary>
        internal bool IsSetDeviceAttributes() => this.DeviceAttributes != null && (this.DeviceAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeviceCreateDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? DeviceCreateDate { get; set; }

        /// <summary>
        /// Checks to see if the DeviceCreateDate property is set.
        /// </summary>
        internal bool IsSetDeviceCreateDate() => this.DeviceCreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceKey. 
        /// <para>
        /// The device key, for example <c>us-west-2_EXAMPLE-a1b2c3d4-5678-90ab-cdef-EXAMPLE22222</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// Checks to see if the DeviceKey property is set.
        /// </summary>
        internal bool IsSetDeviceKey() => this.DeviceKey != null;

        /// <summary>
        /// Gets and sets the property DeviceLastAuthenticatedDate. 
        /// <para>
        /// The date when the user last signed in with the device.
        /// </para>
        /// </summary>
        public DateTime? DeviceLastAuthenticatedDate { get; set; }

        /// <summary>
        /// Checks to see if the DeviceLastAuthenticatedDate property is set.
        /// </summary>
        internal bool IsSetDeviceLastAuthenticatedDate() => this.DeviceLastAuthenticatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceLastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? DeviceLastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the DeviceLastModifiedDate property is set.
        /// </summary>
        internal bool IsSetDeviceLastModifiedDate() => this.DeviceLastModifiedDate.HasValue;
    }
}
