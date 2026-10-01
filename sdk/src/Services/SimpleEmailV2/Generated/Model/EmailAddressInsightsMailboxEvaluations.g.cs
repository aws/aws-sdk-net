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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Contains individual validation checks performed on an email address.
    /// </summary>
    public partial class EmailAddressInsightsMailboxEvaluations
    {
        /// <summary>
        /// Gets and sets the property HasValidDnsRecords. 
        /// <para>
        /// Checks that the domain exists, has valid DNS records, and is conﬁgured to receive
        /// email.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict HasValidDnsRecords { get; set; }

        /// <summary>
        /// Checks to see if the HasValidDnsRecords property is set.
        /// </summary>
        internal bool IsSetHasValidDnsRecords() => this.HasValidDnsRecords != null;

        /// <summary>
        /// Gets and sets the property HasValidSyntax. 
        /// <para>
        /// Checks that the email address follows proper RFC standards and contains valid characters
        /// in the correct format.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict HasValidSyntax { get; set; }

        /// <summary>
        /// Checks to see if the HasValidSyntax property is set.
        /// </summary>
        internal bool IsSetHasValidSyntax() => this.HasValidSyntax != null;

        /// <summary>
        /// Gets and sets the property IsDisposable. 
        /// <para>
        /// Checks disposable or temporary email addresses that could negatively impact your sender
        /// reputation.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict IsDisposable { get; set; }

        /// <summary>
        /// Checks to see if the IsDisposable property is set.
        /// </summary>
        internal bool IsSetIsDisposable() => this.IsDisposable != null;

        /// <summary>
        /// Gets and sets the property IsRandomInput. 
        /// <para>
        /// Checks if the input appears to be random text.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict IsRandomInput { get; set; }

        /// <summary>
        /// Checks to see if the IsRandomInput property is set.
        /// </summary>
        internal bool IsSetIsRandomInput() => this.IsRandomInput != null;

        /// <summary>
        /// Gets and sets the property IsRoleAddress. 
        /// <para>
        /// Identiﬁes role-based addresses (such as admin@, support@, or info@) that may have
        /// lower engagement rates.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict IsRoleAddress { get; set; }

        /// <summary>
        /// Checks to see if the IsRoleAddress property is set.
        /// </summary>
        internal bool IsSetIsRoleAddress() => this.IsRoleAddress != null;

        /// <summary>
        /// Gets and sets the property MailboxExists. 
        /// <para>
        /// Checks that the mailbox exists and can receive messages without actually sending an
        /// email.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict MailboxExists { get; set; }

        /// <summary>
        /// Checks to see if the MailboxExists property is set.
        /// </summary>
        internal bool IsSetMailboxExists() => this.MailboxExists != null;
    }
}
