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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInvitations operation.
    /// Sends an Amazon Macie membership invitation to one or more accounts.
    /// </summary>
    public partial class CreateInvitationsRequest : AmazonMacie2Request
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _disableEmailNotification;
        private string _message;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// An array that lists Amazon Web Services account IDs, one for each account to send
        /// the invitation to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisableEmailNotification. 
        /// <para>
        /// Specifies whether to send the invitation as an email message. If this value is false,
        /// Amazon Macie sends the invitation (as an email message) to the email address that
        /// you specified for the recipient's account when you associated the account with your
        /// account. The default value is false.
        /// </para>
        /// </summary>
        public bool? DisableEmailNotification
        {
            get { return this._disableEmailNotification; }
            set { this._disableEmailNotification = value; }
        }

        // Check to see if DisableEmailNotification property is set
        internal bool IsSetDisableEmailNotification()
        {
            return this._disableEmailNotification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Custom text to include in the email message that contains the invitation. The text
        /// can contain as many as 80 alphanumeric characters.
        /// </para>
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

    }
}