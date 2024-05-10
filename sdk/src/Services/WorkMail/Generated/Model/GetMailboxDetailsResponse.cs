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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetMailboxDetails operation.
    /// </summary>
    public partial class GetMailboxDetailsResponse : AmazonWebServiceResponse
    {
        private int? _mailboxQuota;
        private double? _mailboxSize;

        /// <summary>
        /// Gets and sets the property MailboxQuota. 
        /// <para>
        /// The maximum allowed mailbox size, in MB, for the specified user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MailboxQuota
        {
            get { return this._mailboxQuota; }
            set { this._mailboxQuota = value; }
        }

        // Check to see if MailboxQuota property is set
        internal bool IsSetMailboxQuota()
        {
            return this._mailboxQuota.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MailboxSize. 
        /// <para>
        /// The current mailbox size, in MB, for the specified user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? MailboxSize
        {
            get { return this._mailboxSize; }
            set { this._mailboxSize = value; }
        }

        // Check to see if MailboxSize property is set
        internal bool IsSetMailboxSize()
        {
            return this._mailboxSize.HasValue; 
        }

    }
}