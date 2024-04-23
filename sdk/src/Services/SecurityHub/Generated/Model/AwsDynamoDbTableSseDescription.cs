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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the server-side encryption for the table.
    /// </summary>
    public partial class AwsDynamoDbTableSseDescription
    {
        private string _inaccessibleEncryptionDateTime;
        private string _kmsMasterKeyArn;
        private string _sseType;
        private string _status;

        /// <summary>
        /// Gets and sets the property InaccessibleEncryptionDateTime. 
        /// <para>
        /// If the key is inaccessible, the date and time when DynamoDB detected that the key
        /// was inaccessible.
        /// </para>
        ///  
        /// <para>
        /// This field accepts only the specified formats. Timestamps can end with <c>Z</c> or
        /// <c>("+" / "-") time-hour [":" time-minute]</c>. The time-secfrac after seconds is
        /// limited to a maximum of 9 digits. The offset is bounded by +/-18:00. Here are valid
        /// timestamp formats with examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SSZ</c> (for example, <c>2019-01-31T23:00:00Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmmZ</c> (for example, <c>2019-01-31T23:00:00.123456789Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS+HH:MM</c> (for example, <c>2024-01-04T15:25:10+17:59</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS-HHMM</c> (for example, <c>2024-01-04T15:25:10-1759</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmm+HH:MM</c> (for example, <c>2024-01-04T15:25:10.123456789+17:59</c>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string InaccessibleEncryptionDateTime
        {
            get { return this._inaccessibleEncryptionDateTime; }
            set { this._inaccessibleEncryptionDateTime = value; }
        }

        // Check to see if InaccessibleEncryptionDateTime property is set
        internal bool IsSetInaccessibleEncryptionDateTime()
        {
            return this._inaccessibleEncryptionDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property KmsMasterKeyArn. 
        /// <para>
        /// The ARN of the KMS key that is used for the KMS encryption.
        /// </para>
        /// </summary>
        public string KmsMasterKeyArn
        {
            get { return this._kmsMasterKeyArn; }
            set { this._kmsMasterKeyArn = value; }
        }

        // Check to see if KmsMasterKeyArn property is set
        internal bool IsSetKmsMasterKeyArn()
        {
            return this._kmsMasterKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SseType. 
        /// <para>
        /// The type of server-side encryption.
        /// </para>
        /// </summary>
        public string SseType
        {
            get { return this._sseType; }
            set { this._sseType = value; }
        }

        // Check to see if SseType property is set
        internal bool IsSetSseType()
        {
            return this._sseType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the server-side encryption.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}