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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about the metadata associate with the content to ingest into
    /// a knowledge base. Choose a <c>type</c> and include the field that corresponds to it.
    /// </summary>
    public partial class DocumentMetadata
    {
        /// <summary>
        /// Gets and sets the property AccessControlList. 
        /// <para>
        /// Access control list for the document. Used when metadata type is IN_LINE_ATTRIBUTE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<DocumentAccessControlEntry> AccessControlList { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentAccessControlEntry>() : null;

        /// <summary>
        /// Checks to see if the AccessControlList property is set.
        /// </summary>
        internal bool IsSetAccessControlList() => this.AccessControlList != null && (this.AccessControlList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InlineAttributes. 
        /// <para>
        /// An array of objects, each of which defines a metadata attribute to associate with
        /// the content to ingest. You define the attributes inline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<MetadataAttribute> InlineAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<MetadataAttribute>() : null;

        /// <summary>
        /// Checks to see if the InlineAttributes property is set.
        /// </summary>
        internal bool IsSetInlineAttributes() => this.InlineAttributes != null && (this.InlineAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The Amazon S3 location of the file containing metadata to associate with the content
        /// to ingest.
        /// </para>
        /// </summary>
        public CustomS3Location S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the source source from which to add metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetadataSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
