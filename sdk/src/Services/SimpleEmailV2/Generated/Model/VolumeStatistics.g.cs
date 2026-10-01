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
    /// An object that contains information about the amount of email that was delivered to
    /// recipients.
    /// </summary>
    public partial class VolumeStatistics
    {
        /// <summary>
        /// Gets and sets the property InboxRawCount. 
        /// <para>
        /// The total number of emails that arrived in recipients' inboxes.
        /// </para>
        /// </summary>
        public long? InboxRawCount { get; set; }

        /// <summary>
        /// Checks to see if the InboxRawCount property is set.
        /// </summary>
        internal bool IsSetInboxRawCount() => this.InboxRawCount.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectedInbox. 
        /// <para>
        /// An estimate of the percentage of emails sent from the current domain that will arrive
        /// in recipients' inboxes.
        /// </para>
        /// </summary>
        public long? ProjectedInbox { get; set; }

        /// <summary>
        /// Checks to see if the ProjectedInbox property is set.
        /// </summary>
        internal bool IsSetProjectedInbox() => this.ProjectedInbox.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectedSpam. 
        /// <para>
        /// An estimate of the percentage of emails sent from the current domain that will arrive
        /// in recipients' spam or junk mail folders.
        /// </para>
        /// </summary>
        public long? ProjectedSpam { get; set; }

        /// <summary>
        /// Checks to see if the ProjectedSpam property is set.
        /// </summary>
        internal bool IsSetProjectedSpam() => this.ProjectedSpam.HasValue;

        /// <summary>
        /// Gets and sets the property SpamRawCount. 
        /// <para>
        /// The total number of emails that arrived in recipients' spam or junk mail folders.
        /// </para>
        /// </summary>
        public long? SpamRawCount { get; set; }

        /// <summary>
        /// Checks to see if the SpamRawCount property is set.
        /// </summary>
        internal bool IsSetSpamRawCount() => this.SpamRawCount.HasValue;
    }
}
