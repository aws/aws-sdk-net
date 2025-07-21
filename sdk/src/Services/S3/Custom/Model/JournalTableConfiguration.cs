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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The journal table configuration for an S3 Metadata configuration.
    /// </summary>
    public partial class JournalTableConfiguration
    {
        private MetadataTableEncryptionConfiguration _encryptionConfiguration;
        private RecordExpiration _recordExpiration;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        ///  The encryption configuration for the journal table. 
        /// </para>
        /// </summary>
        public MetadataTableEncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RecordExpiration. 
        /// <para>
        ///  The journal table record expiration settings for the journal table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordExpiration RecordExpiration
        {
            get { return this._recordExpiration; }
            set { this._recordExpiration = value; }
        }

        // Check to see if RecordExpiration property is set
        internal bool IsSetRecordExpiration()
        {
            return this._recordExpiration != null;
        }

    }
}