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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDeviceUsageData operation.
    /// When this action is called for a specified shared device, it allows authorized users
    /// to delete the device's entire previous history of voice input data and associated
    /// response data. This action can be called once every 24 hours for a specific shared
    /// device.
    /// 
    ///  
    /// <para>
    /// When this action is called for a specified shared device, it allows authorized users
    /// to delete the device's entire previous history of voice input data. This action can
    /// be called once every 24 hours for a specific shared device. 
    /// </para>
    /// </summary>
    public partial class DeleteDeviceUsageDataRequest : AmazonAlexaForBusinessRequest
    {
        private string _deviceArn;
        private DeviceUsageType _deviceUsageType;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceUsageType. 
        /// <para>
        /// The type of usage data to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceUsageType DeviceUsageType
        {
            get { return this._deviceUsageType; }
            set { this._deviceUsageType = value; }
        }

        // Check to see if DeviceUsageType property is set
        internal bool IsSetDeviceUsageType()
        {
            return this._deviceUsageType != null;
        }

    }
}