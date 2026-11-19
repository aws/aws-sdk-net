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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// Summary of a social connection returned by ListSocialConnections. Carries no ARN (owner
    /// ruling 2026-10-05): a connection is addressed by its `Id`. Social connections are
    /// not taggable, and every social operation authorizes on its action rather than on a
    /// resource ARN.
    /// </summary>
    public partial class SocialConnectionSummary
    {
        /// <summary>
        /// Gets and sets the property AccountName. Display name of the account behind this connection.
        /// Absent when the execution backend reports none.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property ConnectedAt. When the account was last authorized. Advances
        /// on every re-authorization.
        /// </summary>
        public DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedAt property is set.
        /// </summary>
        internal bool IsSetConnectedAt() => this.ConnectedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. When the authorization lapses. Absent where
        /// the platform reports no expiry (X never does). A connection past this time reads EXPIRED
        /// only once the backend notices, so treat this as a warning date, not a status.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. Identifier of the social connection.
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 16)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PageName. The Facebook Page this connection publishes to.
        /// Absent where no Page applies.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PageName { get; set; }

        /// <summary>
        /// Checks to see if the PageName property is set.
        /// </summary>
        internal bool IsSetPageName() => this.PageName != null;

        /// <summary>
        /// Gets and sets the property Platform. Social platform this connection authorizes.
        /// </summary>
        [AWSProperty(Required = true)]
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Status. Authorization state.
        /// </summary>
        [AWSProperty(Required = true)]
        public SocialConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
