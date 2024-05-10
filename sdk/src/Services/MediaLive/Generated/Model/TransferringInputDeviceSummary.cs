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
    /// Details about the input device that is being transferred.
    /// </summary>
    public partial class TransferringInputDeviceSummary
    {
        private string _id;
        private string _message;
        private string _targetCustomerId;
        private InputDeviceTransferType _transferType;

        /// <summary>
        /// Gets and sets the property Id. The unique ID of the input device.
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
        /// Gets and sets the property Message. The optional message that the sender has attached
        /// to the transfer.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCustomerId. The AWS account ID for the recipient
        /// of the input device transfer.
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
        /// Gets and sets the property TransferType. The type (direction) of the input device
        /// transfer.
        /// </summary>
        public InputDeviceTransferType TransferType
        {
            get { return this._transferType; }
            set { this._transferType = value; }
        }

        // Check to see if TransferType property is set
        internal bool IsSetTransferType()
        {
            return this._transferType != null;
        }

    }
}