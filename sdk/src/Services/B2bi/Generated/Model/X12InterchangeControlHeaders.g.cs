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
        /// <summary>
        /// Gets and sets the property AcknowledgmentRequestedCode. 
        /// <para>
        /// Located at position ISA-14 in the header. The value "1" indicates that the sender
        /// is requesting an interchange acknowledgment at receipt of the interchange. The value
        /// "0" is used otherwise.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string AcknowledgmentRequestedCode { get; set; }

        /// <summary>
        /// Checks to see if the AcknowledgmentRequestedCode property is set.
        /// </summary>
        internal bool IsSetAcknowledgmentRequestedCode() => this.AcknowledgmentRequestedCode != null;

        /// <summary>
        /// Gets and sets the property ReceiverId. 
        /// <para>
        /// Located at position ISA-08 in the header. This value (along with the <c>receiverIdQualifier</c>)
        /// identifies the intended recipient of the interchange. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 15)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverId property is set.
        /// </summary>
        internal bool IsSetReceiverId() => this.ReceiverId != null;

        /// <summary>
        /// Gets and sets the property ReceiverIdQualifier. 
        /// <para>
        /// Located at position ISA-07 in the header. Qualifier for the receiver ID. Together,
        /// the ID and qualifier uniquely identify the receiving trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string ReceiverIdQualifier { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverIdQualifier property is set.
        /// </summary>
        internal bool IsSetReceiverIdQualifier() => this.ReceiverIdQualifier != null;

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
        [AWSProperty(Min = 1, Max = 1)]
        public string RepetitionSeparator { get; set; }

        /// <summary>
        /// Checks to see if the RepetitionSeparator property is set.
        /// </summary>
        internal bool IsSetRepetitionSeparator() => this.RepetitionSeparator != null;

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// Located at position ISA-06 in the header. This value (along with the <c>senderIdQualifier</c>)
        /// identifies the sender of the interchange. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 15)]
        public string SenderId { get; set; }

        /// <summary>
        /// Checks to see if the SenderId property is set.
        /// </summary>
        internal bool IsSetSenderId() => this.SenderId != null;

        /// <summary>
        /// Gets and sets the property SenderIdQualifier. 
        /// <para>
        /// Located at position ISA-05 in the header. Qualifier for the sender ID. Together, the
        /// ID and qualifier uniquely identify the sending trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string SenderIdQualifier { get; set; }

        /// <summary>
        /// Checks to see if the SenderIdQualifier property is set.
        /// </summary>
        internal bool IsSetSenderIdQualifier() => this.SenderIdQualifier != null;

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
        [AWSProperty(Min = 1, Max = 1)]
        public string UsageIndicatorCode { get; set; }

        /// <summary>
        /// Checks to see if the UsageIndicatorCode property is set.
        /// </summary>
        internal bool IsSetUsageIndicatorCode() => this.UsageIndicatorCode != null;
    }
}
