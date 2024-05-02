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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Records events during an engagement.
    /// </summary>
    public partial class Receipt
    {
        private string _contactChannelArn;
        private string _receiptInfo;
        private DateTime? _receiptTime;
        private ReceiptType _receiptType;

        /// <summary>
        /// Gets and sets the property ContactChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact channel Incident Manager engaged.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ContactChannelArn
        {
            get { return this._contactChannelArn; }
            set { this._contactChannelArn = value; }
        }

        // Check to see if ContactChannelArn property is set
        internal bool IsSetContactChannelArn()
        {
            return this._contactChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiptInfo. 
        /// <para>
        /// Information provided during the page acknowledgement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ReceiptInfo
        {
            get { return this._receiptInfo; }
            set { this._receiptInfo = value; }
        }

        // Check to see if ReceiptInfo property is set
        internal bool IsSetReceiptInfo()
        {
            return this._receiptInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiptTime. 
        /// <para>
        /// The time receipt was <c>SENT</c>, <c>DELIVERED</c>, or <c>READ</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ReceiptTime
        {
            get { return this._receiptTime; }
            set { this._receiptTime = value; }
        }

        // Check to see if ReceiptTime property is set
        internal bool IsSetReceiptTime()
        {
            return this._receiptTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReceiptType. 
        /// <para>
        /// The type follows the engagement cycle, <c>SENT</c>, <c>DELIVERED</c>, and <c>READ</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReceiptType ReceiptType
        {
            get { return this._receiptType; }
            set { this._receiptType = value; }
        }

        // Check to see if ReceiptType property is set
        internal bool IsSetReceiptType()
        {
            return this._receiptType != null;
        }

    }
}