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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateEmailIdentityCertificate operation.
    /// Removes the association between an S/MIME certificate and an email identity. After
    /// the association is removed, Amazon SES API v2 stops adding an S/MIME signature to
    /// messages sent from that address.
    /// 
    ///  
    /// <para>
    /// If the email identity is a domain, specify the <c>FromAddress</c> whose certificate
    /// association you want to remove.
    /// </para>
    ///  
    /// <para>
    /// This operation is idempotent. If the specified email identity exists but there's no
    /// matching certificate association, the operation succeeds without making any changes.
    /// Amazon SES API v2 returns a <c>NotFoundException</c> only when the specified email
    /// identity doesn't exist.
    /// </para>
    /// </summary>
    public partial class DisassociateEmailIdentityCertificateRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _emailIdentity;
        private string _fromAddress;

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email identity whose certificate association you want to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string EmailIdentity
        {
            get { return this._emailIdentity; }
            set { this._emailIdentity = value; }
        }

        // Check to see if EmailIdentity property is set
        internal bool IsSetEmailIdentity()
        {
            return this._emailIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The email address whose certificate association you want to remove. This value is
        /// required when the email identity is a domain. When the email identity is an email
        /// address, this value is optional.
        /// </para>
        /// </summary>
        public string FromAddress
        {
            get { return this._fromAddress; }
            set { this._fromAddress = value; }
        }

        // Check to see if FromAddress property is set
        internal bool IsSetFromAddress()
        {
            return this._fromAddress != null;
        }

    }
}