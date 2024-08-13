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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
        private double? _dkimPercentage;
        private double? _inboxPercentage;
        private double? _missingPercentage;
        private double? _spamPercentage;
        private double? _spfPercentage;

        /// <summary>
        /// Gets and sets the property DkimPercentage. 
        /// <para>
        /// The percentage of emails that were authenticated by using DomainKeys Identified Mail
        /// (DKIM) during the predictive inbox placement test.
        /// </para>
        /// </summary>
        public double? DkimPercentage
        {
            get { return this._dkimPercentage; }
            set { this._dkimPercentage = value; }
        }

        // Check to see if DkimPercentage property is set
        internal bool IsSetDkimPercentage()
        {
            return this._dkimPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InboxPercentage. 
        /// <para>
        /// The percentage of emails that arrived in recipients' inboxes during the predictive
        /// inbox placement test.
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
        /// Gets and sets the property MissingPercentage. 
        /// <para>
        /// The percentage of emails that didn't arrive in recipients' inboxes at all during the
        /// predictive inbox placement test.
        /// </para>
        /// </summary>
        public double? MissingPercentage
        {
            get { return this._missingPercentage; }
            set { this._missingPercentage = value; }
        }

        // Check to see if MissingPercentage property is set
        internal bool IsSetMissingPercentage()
        {
            return this._missingPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpamPercentage. 
        /// <para>
        /// The percentage of emails that arrived in recipients' spam or junk mail folders during
        /// the predictive inbox placement test.
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
        /// Gets and sets the property SpfPercentage. 
        /// <para>
        /// The percentage of emails that were authenticated by using Sender Policy Framework
        /// (SPF) during the predictive inbox placement test.
        /// </para>
        /// </summary>
        public double? SpfPercentage
        {
            get { return this._spfPercentage; }
            set { this._spfPercentage = value; }
        }

        // Check to see if SpfPercentage property is set
        internal bool IsSetSpfPercentage()
        {
            return this._spfPercentage.HasValue; 
        }

    }
}