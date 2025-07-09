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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
        private DateTime? _expiryDate;
        private DateTime? _initiationDate;
        private string _mpaSessionArn;
        private MpaRevokeSessionStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ExpiryDate. 
        /// <para>
        /// The date and time when the revoke request will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiryDate
        {
            get { return this._expiryDate; }
            set { this._expiryDate = value; }
        }

        // Check to see if ExpiryDate property is set
        internal bool IsSetExpiryDate()
        {
            return this._expiryDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitiationDate. 
        /// <para>
        /// The date and time when the revoke request was initiated.
        /// </para>
        /// </summary>
        public DateTime? InitiationDate
        {
            get { return this._initiationDate; }
            set { this._initiationDate = value; }
        }

        // Check to see if InitiationDate property is set
        internal bool IsSetInitiationDate()
        {
            return this._initiationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MpaSessionArn. 
        /// <para>
        /// The ARN of the MPA session associated with this revoke request.
        /// </para>
        /// </summary>
        public string MpaSessionArn
        {
            get { return this._mpaSessionArn; }
            set { this._mpaSessionArn = value; }
        }

        // Check to see if MpaSessionArn property is set
        internal bool IsSetMpaSessionArn()
        {
            return this._mpaSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the revoke request.
        /// </para>
        /// </summary>
        public MpaRevokeSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message describing the current status of the revoke request.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}