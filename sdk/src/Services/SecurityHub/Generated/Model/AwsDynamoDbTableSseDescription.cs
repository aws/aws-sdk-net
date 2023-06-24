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
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
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