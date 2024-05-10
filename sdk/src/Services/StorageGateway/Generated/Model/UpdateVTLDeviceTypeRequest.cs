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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVTLDeviceType operation.
    /// Updates the type of medium changer in a tape gateway. When you activate a tape gateway,
    /// you select a medium changer type for the tape gateway. This operation enables you
    /// to select a different type of medium changer after a tape gateway is activated. This
    /// operation is only supported in the tape gateway type.
    /// </summary>
    public partial class UpdateVTLDeviceTypeRequest : AmazonStorageGatewayRequest
    {
        private string _deviceType;
        private string _vtlDeviceARN;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The type of medium changer you want to select.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>STK-L700</c> | <c>AWS-Gateway-VTL</c> | <c>IBM-03584L32-0402</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the medium changer you want to select.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string VTLDeviceARN
        {
            get { return this._vtlDeviceARN; }
            set { this._vtlDeviceARN = value; }
        }

        // Check to see if VTLDeviceARN property is set
        internal bool IsSetVTLDeviceARN()
        {
            return this._vtlDeviceARN != null;
        }

    }
}