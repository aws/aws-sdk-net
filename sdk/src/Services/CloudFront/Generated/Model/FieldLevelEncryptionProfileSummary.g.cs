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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The field-level encryption profile summary.
    /// </summary>
    public partial class FieldLevelEncryptionProfileSummary
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment for the field-level encryption profile summary. The comment cannot
        /// be longer than 128 characters.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property EncryptionEntities. 
        /// <para>
        /// A complex data type of encryption entities for the field-level encryption profile
        /// that include the public key ID, provider, and field patterns for specifying which
        /// fields to encrypt with this key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionEntities EncryptionEntities { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionEntities property is set.
        /// </summary>
        internal bool IsSetEncryptionEntities() => this.EncryptionEntities != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID for the field-level encryption profile summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the field-level encryption profile summary was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the field-level encryption profile summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
