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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The field-level encryption profile summary.
    /// </summary>
    public partial class FieldLevelEncryptionProfileSummary
    {
        private string _comment;
        private EncryptionEntities _encryptionEntities;
        private string _id;
        private DateTime? _lastModifiedTime;
        private string _name;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment for the field-level encryption profile summary. The comment cannot
        /// be longer than 128 characters.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionEntities. 
        /// <para>
        /// A complex data type of encryption entities for the field-level encryption profile
        /// that include the public key ID, provider, and field patterns for specifying which
        /// fields to encrypt with this key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionEntities EncryptionEntities
        {
            get { return this._encryptionEntities; }
            set { this._encryptionEntities = value; }
        }

        // Check to see if EncryptionEntities property is set
        internal bool IsSetEncryptionEntities()
        {
            return this._encryptionEntities != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID for the field-level encryption profile summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the field-level encryption profile summary was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the field-level encryption profile summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}