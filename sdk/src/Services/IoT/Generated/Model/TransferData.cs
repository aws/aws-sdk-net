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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Data used to transfer a certificate to an Amazon Web Services account.
    /// </summary>
    public partial class TransferData
    {
        private DateTime? _acceptDate;
        private DateTime? _rejectDate;
        private string _rejectReason;
        private DateTime? _transferDate;
        private string _transferMessage;

        /// <summary>
        /// Gets and sets the property AcceptDate. 
        /// <para>
        /// The date the transfer was accepted.
        /// </para>
        /// </summary>
        public DateTime? AcceptDate
        {
            get { return this._acceptDate; }
            set { this._acceptDate = value; }
        }

        // Check to see if AcceptDate property is set
        internal bool IsSetAcceptDate()
        {
            return this._acceptDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RejectDate. 
        /// <para>
        /// The date the transfer was rejected.
        /// </para>
        /// </summary>
        public DateTime? RejectDate
        {
            get { return this._rejectDate; }
            set { this._rejectDate = value; }
        }

        // Check to see if RejectDate property is set
        internal bool IsSetRejectDate()
        {
            return this._rejectDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RejectReason. 
        /// <para>
        /// The reason why the transfer was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string RejectReason
        {
            get { return this._rejectReason; }
            set { this._rejectReason = value; }
        }

        // Check to see if RejectReason property is set
        internal bool IsSetRejectReason()
        {
            return this._rejectReason != null;
        }

        /// <summary>
        /// Gets and sets the property TransferDate. 
        /// <para>
        /// The date the transfer took place.
        /// </para>
        /// </summary>
        public DateTime? TransferDate
        {
            get { return this._transferDate; }
            set { this._transferDate = value; }
        }

        // Check to see if TransferDate property is set
        internal bool IsSetTransferDate()
        {
            return this._transferDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferMessage. 
        /// <para>
        /// The transfer message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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