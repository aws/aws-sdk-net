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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that contains inbox placement data for an email provider.
    /// </summary>
    public partial class PlacementStatistics
    {
        /// <summary>
        /// Gets and sets the property DkimPercentage. 
        /// <para>
        /// The percentage of emails that were authenticated by using DomainKeys Identified Mail
        /// (DKIM) during the predictive inbox placement test.
        /// </para>
        /// </summary>
        public double? DkimPercentage { get; set; }

        /// <summary>
        /// Checks to see if the DkimPercentage property is set.
        /// </summary>
        internal bool IsSetDkimPercentage() => this.DkimPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property InboxPercentage. 
        /// <para>
        /// The percentage of emails that arrived in recipients' inboxes during the predictive
        /// inbox placement test.
        /// </para>
        /// </summary>
        public double? InboxPercentage { get; set; }

        /// <summary>
        /// Checks to see if the InboxPercentage property is set.
        /// </summary>
        internal bool IsSetInboxPercentage() => this.InboxPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property MissingPercentage. 
        /// <para>
        /// The percentage of emails that didn't arrive in recipients' inboxes at all during the
        /// predictive inbox placement test.
        /// </para>
        /// </summary>
        public double? MissingPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MissingPercentage property is set.
        /// </summary>
        internal bool IsSetMissingPercentage() => this.MissingPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property SpamPercentage. 
        /// <para>
        /// The percentage of emails that arrived in recipients' spam or junk mail folders during
        /// the predictive inbox placement test.
        /// </para>
        /// </summary>
        public double? SpamPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SpamPercentage property is set.
        /// </summary>
        internal bool IsSetSpamPercentage() => this.SpamPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property SpfPercentage. 
        /// <para>
        /// The percentage of emails that were authenticated by using Sender Policy Framework
        /// (SPF) during the predictive inbox placement test.
        /// </para>
        /// </summary>
        public double? SpfPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SpfPercentage property is set.
        /// </summary>
        internal bool IsSetSpfPercentage() => this.SpfPercentage.HasValue;
    }
}
