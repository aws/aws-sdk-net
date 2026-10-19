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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes a version of a document.
    /// </summary>
    public partial class DocumentVersionMetadata
    {
        /// <summary>
        /// Gets and sets the property ContentCreatedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was originally created.
        /// </para>
        /// </summary>
        public DateTime? ContentCreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ContentCreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetContentCreatedTimestamp() => this.ContentCreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ContentModifiedTimestamp. 
        /// <para>
        /// The timestamp when the content of the document was modified.
        /// </para>
        /// </summary>
        public DateTime? ContentModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ContentModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetContentModifiedTimestamp() => this.ContentModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp when the document was first uploaded.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorId. 
        /// <para>
        /// The ID of the creator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CreatorId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorId property is set.
        /// </summary>
        internal bool IsSetCreatorId() => this.CreatorId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The timestamp when the document was last uploaded.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetModifiedTimestamp() => this.ModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The signature of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Signature { get; set; }

        /// <summary>
        /// Checks to see if the Signature property is set.
        /// </summary>
        internal bool IsSetSignature() => this.Signature != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the document, in bytes.
        /// </para>
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Source { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null && (this.Source.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the document.
        /// </para>
        /// </summary>
        public DocumentStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Thumbnail. 
        /// <para>
        /// The thumbnail of the document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Thumbnail { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Thumbnail property is set.
        /// </summary>
        internal bool IsSetThumbnail() => this.Thumbnail != null && (this.Thumbnail.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
