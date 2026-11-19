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
    /// A summary of a field-level encryption item.
    /// </summary>
    public partial class FieldLevelEncryptionSummary
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the field-level encryption item. The comment cannot be longer
        /// than 128 characters.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ContentTypeProfileConfig. 
        /// <para>
        /// A summary of a content type-profile mapping.
        /// </para>
        /// </summary>
        public ContentTypeProfileConfig ContentTypeProfileConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContentTypeProfileConfig property is set.
        /// </summary>
        internal bool IsSetContentTypeProfileConfig() => this.ContentTypeProfileConfig != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of a field-level encryption item.
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
        /// The last time that the summary of field-level encryption items was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property QueryArgProfileConfig. 
        /// <para>
        /// A summary of a query argument-profile mapping.
        /// </para>
        /// </summary>
        public QueryArgProfileConfig QueryArgProfileConfig { get; set; }

        /// <summary>
        /// Checks to see if the QueryArgProfileConfig property is set.
        /// </summary>
        internal bool IsSetQueryArgProfileConfig() => this.QueryArgProfileConfig != null;
    }
}
