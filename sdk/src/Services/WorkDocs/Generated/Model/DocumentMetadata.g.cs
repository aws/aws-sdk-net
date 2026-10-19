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
    /// Describes the document.
    /// </summary>
    public partial class DocumentMetadata
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the document was created.
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
        /// The ID of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// List of labels on the document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LatestVersionMetadata. 
        /// <para>
        /// The latest version of the document.
        /// </para>
        /// </summary>
        public DocumentVersionMetadata LatestVersionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionMetadata property is set.
        /// </summary>
        internal bool IsSetLatestVersionMetadata() => this.LatestVersionMetadata != null;

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The time when the document was updated.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetModifiedTimestamp() => this.ModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ParentFolderId. 
        /// <para>
        /// The ID of the parent folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Checks to see if the ParentFolderId property is set.
        /// </summary>
        internal bool IsSetParentFolderId() => this.ParentFolderId != null;

        /// <summary>
        /// Gets and sets the property ResourceState. 
        /// <para>
        /// The resource state.
        /// </para>
        /// </summary>
        public ResourceStateType ResourceState { get; set; }

        /// <summary>
        /// Checks to see if the ResourceState property is set.
        /// </summary>
        internal bool IsSetResourceState() => this.ResourceState != null;
    }
}
