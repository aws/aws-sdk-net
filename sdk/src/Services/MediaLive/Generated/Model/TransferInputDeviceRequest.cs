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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the TransferInputDevice operation.
    /// Start an input device transfer to another AWS account. After you make the request,
    /// the other account must accept or reject the transfer.
    /// </summary>
    public partial class TransferInputDeviceRequest : AmazonMediaLiveRequest
    {
        private string _inputDeviceId;
        private string _targetCustomerId;
        private string _targetRegion;
        private string _transferMessage;

        /// <summary>
        /// Gets and sets the property InputDeviceId. The unique ID of this input device. For
        /// example, hd-123456789abcdef.
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputDeviceId
        {
            get { return this._inputDeviceId; }
            set { this._inputDeviceId = value; }
        }

        // Check to see if InputDeviceId property is set
        internal bool IsSetInputDeviceId()
        {
            return this._inputDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCustomerId. The AWS account ID (12 digits) for the
        /// recipient of the device transfer.
        /// </summary>
        public string TargetCustomerId
        {
            get { return this._targetCustomerId; }
            set { this._targetCustomerId = value; }
        }

        // Check to see if TargetCustomerId property is set
        internal bool IsSetTargetCustomerId()
        {
            return this._targetCustomerId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRegion. The target AWS region to transfer the device.
        /// </summary>
        public string TargetRegion
        {
            get { return this._targetRegion; }
            set { this._targetRegion = value; }
        }

        // Check to see if TargetRegion property is set
        internal bool IsSetTargetRegion()
        {
            return this._targetRegion != null;
        }

        /// <summary>
        /// Gets and sets the property TransferMessage. An optional message for the recipient.
        /// Maximum 280 characters.
        /// </summary>
        public string TransferMessage
        {
            get { return this._transferMessage; }
            set { this._transferMessage = value; }
        }

        // Check to see if TransferMessage property is set
        internal bool IsSetTransferMessage()
        {
            return this._transferMessage != null;
        }

    }
}