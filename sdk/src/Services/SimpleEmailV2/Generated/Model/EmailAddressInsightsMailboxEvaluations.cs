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
    /// Contains individual validation checks performed on an email address.
    /// </summary>
    public partial class EmailAddressInsightsMailboxEvaluations
    {
        private EmailAddressInsightsVerdict _hasValidDnsRecords;
        private EmailAddressInsightsVerdict _hasValidSyntax;
        private EmailAddressInsightsVerdict _isDisposable;
        private EmailAddressInsightsVerdict _isRandomInput;
        private EmailAddressInsightsVerdict _isRoleAddress;
        private EmailAddressInsightsVerdict _mailboxExists;

        /// <summary>
        /// Gets and sets the property HasValidDnsRecords. 
        /// <para>
        /// Checks that the domain exists, has valid DNS records, and is conﬁgured to receive
        /// email.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict HasValidDnsRecords
        {
            get { return this._hasValidDnsRecords; }
            set { this._hasValidDnsRecords = value; }
        }

        // Check to see if HasValidDnsRecords property is set
        internal bool IsSetHasValidDnsRecords()
        {
            return this._hasValidDnsRecords != null;
        }

        /// <summary>
        /// Gets and sets the property HasValidSyntax. 
        /// <para>
        /// Checks that the email address follows proper RFC standards and contains valid characters
        /// in the correct format.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict HasValidSyntax
        {
            get { return this._hasValidSyntax; }
            set { this._hasValidSyntax = value; }
        }

        // Check to see if HasValidSyntax property is set
        internal bool IsSetHasValidSyntax()
        {
            return this._hasValidSyntax != null;
        }

        /// <summary>
        /// Gets and sets the property IsDisposable. 
        /// <para>
        /// Checks disposable or temporary email addresses that could negatively impact your sender
        /// reputation.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict IsDisposable
        {
            get { return this._isDisposable; }
            set { this._isDisposable = value; }
        }

        // Check to see if IsDisposable property is set
        internal bool IsSetIsDisposable()
        {
            return this._isDisposable != null;
        }

        /// <summary>
        /// Gets and sets the property IsRandomInput. 
        /// <para>
        /// Checks if the input appears to be random text.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict IsRandomInput
        {
            get { return this._isRandomInput; }
            set { this._isRandomInput = value; }
        }

        // Check to see if IsRandomInput property is set
        internal bool IsSetIsRandomInput()
        {
            return this._isRandomInput != null;
        }

        /// <summary>
        /// Gets and sets the property IsRoleAddress. 
        /// <para>
        /// Identiﬁes role-based addresses (such as admin@, support@, or info@) that may have
        /// lower engagement rates.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict IsRoleAddress
        {
            get { return this._isRoleAddress; }
            set { this._isRoleAddress = value; }
        }

        // Check to see if IsRoleAddress property is set
        internal bool IsSetIsRoleAddress()
        {
            return this._isRoleAddress != null;
        }

        /// <summary>
        /// Gets and sets the property MailboxExists. 
        /// <para>
        /// Checks that the mailbox exists and can receive messages without actually sending an
        /// email.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict MailboxExists
        {
            get { return this._mailboxExists; }
            set { this._mailboxExists = value; }
        }

        // Check to see if MailboxExists property is set
        internal bool IsSetMailboxExists()
        {
            return this._mailboxExists != null;
        }

    }
}