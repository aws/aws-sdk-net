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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Data used to transfer a certificate to an Amazon Web Services account.
    /// </summary>
    public partial class TransferData
    {
        /// <summary>
        /// Gets and sets the property AcceptDate. 
        /// <para>
        /// The date the transfer was accepted.
        /// </para>
        /// </summary>
        public DateTime? AcceptDate { get; set; }

        /// <summary>
        /// Checks to see if the AcceptDate property is set.
        /// </summary>
        internal bool IsSetAcceptDate() => this.AcceptDate.HasValue;

        /// <summary>
        /// Gets and sets the property RejectDate. 
        /// <para>
        /// The date the transfer was rejected.
        /// </para>
        /// </summary>
        public DateTime? RejectDate { get; set; }

        /// <summary>
        /// Checks to see if the RejectDate property is set.
        /// </summary>
        internal bool IsSetRejectDate() => this.RejectDate.HasValue;

        /// <summary>
        /// Gets and sets the property RejectReason. 
        /// <para>
        /// The reason why the transfer was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string RejectReason { get; set; }

        /// <summary>
        /// Checks to see if the RejectReason property is set.
        /// </summary>
        internal bool IsSetRejectReason() => this.RejectReason != null;

        /// <summary>
        /// Gets and sets the property TransferDate. 
        /// <para>
        /// The date the transfer took place.
        /// </para>
        /// </summary>
        public DateTime? TransferDate { get; set; }

        /// <summary>
        /// Checks to see if the TransferDate property is set.
        /// </summary>
        internal bool IsSetTransferDate() => this.TransferDate.HasValue;

        /// <summary>
        /// Gets and sets the property TransferMessage. 
        /// <para>
        /// The transfer message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TransferMessage { get; set; }

        /// <summary>
        /// Checks to see if the TransferMessage property is set.
        /// </summary>
        internal bool IsSetTransferMessage() => this.TransferMessage != null;
    }
}
