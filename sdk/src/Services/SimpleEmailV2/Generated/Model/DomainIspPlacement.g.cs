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
    /// An object that contains inbox placement data for email sent from one of your email
    /// domains to a specific email provider.
    /// </summary>
    public partial class DomainIspPlacement
    {
        /// <summary>
        /// Gets and sets the property InboxPercentage. 
        /// <para>
        /// The percentage of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' inboxes.
        /// </para>
        /// </summary>
        public double? InboxPercentage { get; set; }

        /// <summary>
        /// Checks to see if the InboxPercentage property is set.
        /// </summary>
        internal bool IsSetInboxPercentage() => this.InboxPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property InboxRawCount. 
        /// <para>
        /// The total number of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' inboxes.
        /// </para>
        /// </summary>
        public long? InboxRawCount { get; set; }

        /// <summary>
        /// Checks to see if the InboxRawCount property is set.
        /// </summary>
        internal bool IsSetInboxRawCount() => this.InboxRawCount.HasValue;

        /// <summary>
        /// Gets and sets the property IspName. 
        /// <para>
        /// The name of the email provider that the inbox placement data applies to.
        /// </para>
        /// </summary>
        public string IspName { get; set; }

        /// <summary>
        /// Checks to see if the IspName property is set.
        /// </summary>
        internal bool IsSetIspName() => this.IspName != null;

        /// <summary>
        /// Gets and sets the property SpamPercentage. 
        /// <para>
        /// The percentage of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' spam or junk mail folders.
        /// </para>
        /// </summary>
        public double? SpamPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SpamPercentage property is set.
        /// </summary>
        internal bool IsSetSpamPercentage() => this.SpamPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property SpamRawCount. 
        /// <para>
        /// The total number of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' spam or junk mail folders.
        /// </para>
        /// </summary>
        public long? SpamRawCount { get; set; }

        /// <summary>
        /// Checks to see if the SpamRawCount property is set.
        /// </summary>
        internal bool IsSetSpamRawCount() => this.SpamRawCount.HasValue;
    }
}
