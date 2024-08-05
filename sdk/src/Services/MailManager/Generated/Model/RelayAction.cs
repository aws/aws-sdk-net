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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The action relays the email via SMTP to another specific SMTP server.
    /// </summary>
    public partial class RelayAction
    {
        private ActionFailurePolicy _actionFailurePolicy;
        private MailFrom _mailFrom;
        private string _relay;

        /// <summary>
        /// Gets and sets the property ActionFailurePolicy. 
        /// <para>
        /// A policy that states what to do in the case of failure. The action will fail if there
        /// are configuration errors. For example, the specified relay has been deleted.
        /// </para>
        /// </summary>
        public ActionFailurePolicy ActionFailurePolicy
        {
            get { return this._actionFailurePolicy; }
            set { this._actionFailurePolicy = value; }
        }

        // Check to see if ActionFailurePolicy property is set
        internal bool IsSetActionFailurePolicy()
        {
            return this._actionFailurePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property MailFrom. 
        /// <para>
        /// This action specifies whether to preserve or replace original mail from address while
        /// relaying received emails to a destination server.
        /// </para>
        /// </summary>
        public MailFrom MailFrom
        {
            get { return this._mailFrom; }
            set { this._mailFrom = value; }
        }

        // Check to see if MailFrom property is set
        internal bool IsSetMailFrom()
        {
            return this._mailFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Relay. 
        /// <para>
        /// The identifier of the relay resource to be used when relaying an email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Relay
        {
            get { return this._relay; }
            set { this._relay = value; }
        }

        // Check to see if Relay property is set
        internal bool IsSetRelay()
        {
            return this._relay != null;
        }

    }
}