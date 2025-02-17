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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// In X12, the Interchange Control Header is the first segment of an EDI document and
    /// is part of the Interchange Envelope. It contains information about the sender and
    /// receiver, the date and time of transmission, and the X12 version being used. It also
    /// includes delivery information, such as the sender and receiver IDs.
    /// </summary>
    public partial class X12InterchangeControlHeaders
    {
        private string _acknowledgmentRequestedCode;
        private string _receiverId;
        private string _receiverIdQualifier;
        private string _repetitionSeparator;
        private string _senderId;
        private string _senderIdQualifier;
        private string _usageIndicatorCode;

        /// <summary>
        /// Gets and sets the property AcknowledgmentRequestedCode. 
        /// <para>
        /// Located at position ISA-14 in the header. The value "1" indicates that the sender
        /// is requesting an interchange acknowledgment at receipt of the interchange. The value
        /// "0" is used otherwise.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string AcknowledgmentRequestedCode
        {
            get { return this._acknowledgmentRequestedCode; }
            set { this._acknowledgmentRequestedCode = value; }
        }

        // Check to see if AcknowledgmentRequestedCode property is set
        internal bool IsSetAcknowledgmentRequestedCode()
        {
            return this._acknowledgmentRequestedCode != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverId. 
        /// <para>
        /// Located at position ISA-08 in the header. This value (along with the <c>receiverIdQualifier</c>)
        /// identifies the intended recipient of the interchange. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=15)]
        public string ReceiverId
        {
            get { return this._receiverId; }
            set { this._receiverId = value; }
        }

        // Check to see if ReceiverId property is set
        internal bool IsSetReceiverId()
        {
            return this._receiverId != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverIdQualifier. 
        /// <para>
        /// Located at position ISA-07 in the header. Qualifier for the receiver ID. Together,
        /// the ID and qualifier uniquely identify the receiving trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string ReceiverIdQualifier
        {
            get { return this._receiverIdQualifier; }
            set { this._receiverIdQualifier = value; }
        }

        // Check to see if ReceiverIdQualifier property is set
        internal bool IsSetReceiverIdQualifier()
        {
            return this._receiverIdQualifier != null;
        }

        /// <summary>
        /// Gets and sets the property RepetitionSeparator. 
        /// <para>
        /// Located at position ISA-11 in the header. This string makes it easier when you need
        /// to group similar adjacent element values together without using extra segments.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only honored for version greater than 401 (<c>VERSION_4010</c> and
        /// higher).
        /// </para>
        ///  
        /// <para>
        /// For versions less than 401, this field is called <a href="https://www.stedi.com/edi/x12-004010/segment/ISA#ISA-11">StandardsId</a>,
        /// in which case our service sets the value to <c>U</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string RepetitionSeparator
        {
            get { return this._repetitionSeparator; }
            set { this._repetitionSeparator = value; }
        }

        // Check to see if RepetitionSeparator property is set
        internal bool IsSetRepetitionSeparator()
        {
            return this._repetitionSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// Located at position ISA-06 in the header. This value (along with the <c>senderIdQualifier</c>)
        /// identifies the sender of the interchange. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=15)]
        public string SenderId
        {
            get { return this._senderId; }
            set { this._senderId = value; }
        }

        // Check to see if SenderId property is set
        internal bool IsSetSenderId()
        {
            return this._senderId != null;
        }

        /// <summary>
        /// Gets and sets the property SenderIdQualifier. 
        /// <para>
        /// Located at position ISA-05 in the header. Qualifier for the sender ID. Together, the
        /// ID and qualifier uniquely identify the sending trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string SenderIdQualifier
        {
            get { return this._senderIdQualifier; }
            set { this._senderIdQualifier = value; }
        }

        // Check to see if SenderIdQualifier property is set
        internal bool IsSetSenderIdQualifier()
        {
            return this._senderIdQualifier != null;
        }

        /// <summary>
        /// Gets and sets the property UsageIndicatorCode. 
        /// <para>
        /// Located at position ISA-15 in the header. Specifies how this interchange is being
        /// used:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>T</c> indicates this interchange is for testing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>P</c> indicates this interchange is for production.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>I</c> indicates this interchange is informational.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string UsageIndicatorCode
        {
            get { return this._usageIndicatorCode; }
            set { this._usageIndicatorCode = value; }
        }

        // Check to see if UsageIndicatorCode property is set
        internal bool IsSetUsageIndicatorCode()
        {
            return this._usageIndicatorCode != null;
        }

    }
}