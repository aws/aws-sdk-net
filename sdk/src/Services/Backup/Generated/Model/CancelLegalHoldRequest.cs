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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the CancelLegalHold operation.
    /// This action removes the specified legal hold on a recovery point. This action can
    /// only be performed by a user with sufficient permissions.
    /// </summary>
    public partial class CancelLegalHoldRequest : AmazonBackupRequest
    {
        private string _cancelDescription;
        private string _legalHoldId;
        private long? _retainRecordInDays;

        /// <summary>
        /// Gets and sets the property CancelDescription. 
        /// <para>
        /// String describing the reason for removing the legal hold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CancelDescription
        {
            get { return this._cancelDescription; }
            set { this._cancelDescription = value; }
        }

        // Check to see if CancelDescription property is set
        internal bool IsSetCancelDescription()
        {
            return this._cancelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property LegalHoldId. 
        /// <para>
        /// Legal hold ID required to remove the specified legal hold on a recovery point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LegalHoldId
        {
            get { return this._legalHoldId; }
            set { this._legalHoldId = value; }
        }

        // Check to see if LegalHoldId property is set
        internal bool IsSetLegalHoldId()
        {
            return this._legalHoldId != null;
        }

        /// <summary>
        /// Gets and sets the property RetainRecordInDays. 
        /// <para>
        /// The integer amount in days specifying amount of days after this API operation to remove
        /// legal hold.
        /// </para>
        /// </summary>
        public long RetainRecordInDays
        {
            get { return this._retainRecordInDays.GetValueOrDefault(); }
            set { this._retainRecordInDays = value; }
        }

        // Check to see if RetainRecordInDays property is set
        internal bool IsSetRetainRecordInDays()
        {
            return this._retainRecordInDays.HasValue; 
        }

    }
}