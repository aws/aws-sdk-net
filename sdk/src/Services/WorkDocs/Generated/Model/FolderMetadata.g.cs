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
    /// Describes a folder.
    /// </summary>
    public partial class FolderMetadata
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the folder was created.
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
        /// The ID of the folder.
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
        /// List of labels on the folder.
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
        /// Gets and sets the property LatestVersionSize. 
        /// <para>
        /// The size of the latest version of the folder metadata.
        /// </para>
        /// </summary>
        public long? LatestVersionSize { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionSize property is set.
        /// </summary>
        internal bool IsSetLatestVersionSize() => this.LatestVersionSize.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The time when the folder was updated.
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
        /// The name of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        /// The resource state of the folder.
        /// </para>
        /// </summary>
        public ResourceStateType ResourceState { get; set; }

        /// <summary>
        /// Checks to see if the ResourceState property is set.
        /// </summary>
        internal bool IsSetResourceState() => this.ResourceState != null;

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The unique identifier created from the subfolders and documents of the folder.
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
        /// The size of the folder metadata.
        /// </para>
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;
    }
}
