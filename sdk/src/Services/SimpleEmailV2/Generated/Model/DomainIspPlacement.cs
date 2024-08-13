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
    /// An object that contains inbox placement data for email sent from one of your email
    /// domains to a specific email provider.
    /// </summary>
    public partial class DomainIspPlacement
    {
        private double? _inboxPercentage;
        private long? _inboxRawCount;
        private string _ispName;
        private double? _spamPercentage;
        private long? _spamRawCount;

        /// <summary>
        /// Gets and sets the property InboxPercentage. 
        /// <para>
        /// The percentage of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' inboxes.
        /// </para>
        /// </summary>
        public double? InboxPercentage
        {
            get { return this._inboxPercentage; }
            set { this._inboxPercentage = value; }
        }

        // Check to see if InboxPercentage property is set
        internal bool IsSetInboxPercentage()
        {
            return this._inboxPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InboxRawCount. 
        /// <para>
        /// The total number of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' inboxes.
        /// </para>
        /// </summary>
        public long? InboxRawCount
        {
            get { return this._inboxRawCount; }
            set { this._inboxRawCount = value; }
        }

        // Check to see if InboxRawCount property is set
        internal bool IsSetInboxRawCount()
        {
            return this._inboxRawCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IspName. 
        /// <para>
        /// The name of the email provider that the inbox placement data applies to.
        /// </para>
        /// </summary>
        public string IspName
        {
            get { return this._ispName; }
            set { this._ispName = value; }
        }

        // Check to see if IspName property is set
        internal bool IsSetIspName()
        {
            return this._ispName != null;
        }

        /// <summary>
        /// Gets and sets the property SpamPercentage. 
        /// <para>
        /// The percentage of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' spam or junk mail folders.
        /// </para>
        /// </summary>
        public double? SpamPercentage
        {
            get { return this._spamPercentage; }
            set { this._spamPercentage = value; }
        }

        // Check to see if SpamPercentage property is set
        internal bool IsSetSpamPercentage()
        {
            return this._spamPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpamRawCount. 
        /// <para>
        /// The total number of messages that were sent from the selected domain to the specified
        /// email provider that arrived in recipients' spam or junk mail folders.
        /// </para>
        /// </summary>
        public long? SpamRawCount
        {
            get { return this._spamRawCount; }
            set { this._spamRawCount = value; }
        }

        // Check to see if SpamRawCount property is set
        internal bool IsSetSpamRawCount()
        {
            return this._spamRawCount.HasValue; 
        }

    }
}