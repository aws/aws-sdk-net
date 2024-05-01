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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Recipient-related information to include in the Delivery Status Notification (DSN)
    /// when an email that Amazon SES receives on your behalf bounces.
    /// 
    ///  
    /// <para>
    /// For information about receiving email through Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class BouncedRecipientInfo
    {
        private BounceType _bounceType;
        private string _recipient;
        private string _recipientArn;
        private RecipientDsnFields _recipientDsnFields;

        /// <summary>
        /// Gets and sets the property BounceType. 
        /// <para>
        /// The reason for the bounce. You must provide either this parameter or <c>RecipientDsnFields</c>.
        /// </para>
        /// </summary>
        public BounceType BounceType
        {
            get { return this._bounceType; }
            set { this._bounceType = value; }
        }

        // Check to see if BounceType property is set
        internal bool IsSetBounceType()
        {
            return this._bounceType != null;
        }

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// The email address of the recipient of the bounced email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Recipient
        {
            get { return this._recipient; }
            set { this._recipient = value; }
        }

        // Check to see if Recipient property is set
        internal bool IsSetRecipient()
        {
            return this._recipient != null;
        }

        /// <summary>
        /// Gets and sets the property RecipientArn. 
        /// <para>
        /// This parameter is used only for sending authorization. It is the ARN of the identity
        /// that is associated with the sending authorization policy that permits you to receive
        /// email for the recipient of the bounced email. For more information about sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        public string RecipientArn
        {
            get { return this._recipientArn; }
            set { this._recipientArn = value; }
        }

        // Check to see if RecipientArn property is set
        internal bool IsSetRecipientArn()
        {
            return this._recipientArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecipientDsnFields. 
        /// <para>
        /// Recipient-related DSN fields, most of which would normally be filled in automatically
        /// when provided with a <c>BounceType</c>. You must provide either this parameter or
        /// <c>BounceType</c>.
        /// </para>
        /// </summary>
        public RecipientDsnFields RecipientDsnFields
        {
            get { return this._recipientDsnFields; }
            set { this._recipientDsnFields = value; }
        }

        // Check to see if RecipientDsnFields property is set
        internal bool IsSetRecipientDsnFields()
        {
            return this._recipientDsnFields != null;
        }

    }
}