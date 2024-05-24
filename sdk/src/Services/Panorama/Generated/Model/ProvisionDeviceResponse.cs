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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// This is the response object from the ProvisionDevice operation.
    /// </summary>
    public partial class ProvisionDeviceResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private MemoryStream _certificates;
        private string _deviceId;
        private string _iotThingName;
        private DeviceStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The device's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// The device's configuration bundle.
        /// </para>
        /// </summary>
        public MemoryStream Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property IotThingName. 
        /// <para>
        /// The device's IoT thing name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string IotThingName
        {
            get { return this._iotThingName; }
            set { this._iotThingName = value; }
        }

        // Check to see if IotThingName property is set
        internal bool IsSetIotThingName()
        {
            return this._iotThingName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The device's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}