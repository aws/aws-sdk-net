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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
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
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Contains usage information about the last time the KMS key was used for a successful
    /// cryptographic operation.
    /// </summary>
    public partial class KeyLastUsageData
    {
        private string _cloudTrailEventId;
        private string _kmsRequestId;
        private KeyLastUsageTrackingOperation _operation;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property CloudTrailEventId. 
        /// <para>
        /// The CloudTrail <c>eventId</c> associated with the last successful cryptographic operation.
        /// Absent if the key has not been used since KMS began tracking.
        /// </para>
        /// </summary>
        public string CloudTrailEventId
        {
            get { return this._cloudTrailEventId; }
            set { this._cloudTrailEventId = value; }
        }

        // Check to see if CloudTrailEventId property is set
        internal bool IsSetCloudTrailEventId()
        {
            return this._cloudTrailEventId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsRequestId. 
        /// <para>
        /// The KMS request ID associated with the last successful cryptographic operation. Absent
        /// if the key has not been used since KMS began tracking.
        /// </para>
        /// </summary>
        public string KmsRequestId
        {
            get { return this._kmsRequestId; }
            set { this._kmsRequestId = value; }
        }

        // Check to see if KmsRequestId property is set
        internal bool IsSetKmsRequestId()
        {
            return this._kmsRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The last successful cryptographic operation the KMS key was used for. Absent if the
        /// key has not been used since KMS began tracking.
        /// </para>
        /// </summary>
        public KeyLastUsageTrackingOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time when the KMS key was most recently used for a successful cryptographic
        /// operation. Absent if the key has not been used since KMS began tracking.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}