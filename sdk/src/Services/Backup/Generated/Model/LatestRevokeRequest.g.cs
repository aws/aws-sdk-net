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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains information about the latest request to revoke access to a backup vault.
    /// </summary>
    public partial class LatestRevokeRequest
    {
        /// <summary>
        /// Gets and sets the property ExpiryDate. 
        /// <para>
        /// The date and time when the revoke request will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryDate property is set.
        /// </summary>
        internal bool IsSetExpiryDate() => this.ExpiryDate.HasValue;

        /// <summary>
        /// Gets and sets the property InitiationDate. 
        /// <para>
        /// The date and time when the revoke request was initiated.
        /// </para>
        /// </summary>
        public DateTime? InitiationDate { get; set; }

        /// <summary>
        /// Checks to see if the InitiationDate property is set.
        /// </summary>
        internal bool IsSetInitiationDate() => this.InitiationDate.HasValue;

        /// <summary>
        /// Gets and sets the property MpaSessionArn. 
        /// <para>
        /// The ARN of the MPA session associated with this revoke request.
        /// </para>
        /// </summary>
        public string MpaSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the MpaSessionArn property is set.
        /// </summary>
        internal bool IsSetMpaSessionArn() => this.MpaSessionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the revoke request.
        /// </para>
        /// </summary>
        public MpaRevokeSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message describing the current status of the revoke request.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
