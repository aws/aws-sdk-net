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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFolder operation. Creates an empty shared
    /// folder.
    /// </summary>
    public partial class CreateFolderRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account where you want to create the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property FolderId. 
        /// <para>
        /// The ID of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string FolderId { get; set; }

        /// <summary>
        /// Checks to see if the FolderId property is set.
        /// </summary>
        internal bool IsSetFolderId() => this.FolderId != null;

        /// <summary>
        /// Gets and sets the property FolderType. 
        /// <para>
        /// The type of folder. By default, <c>folderType</c> is <c>SHARED</c>.
        /// </para>
        /// </summary>
        public FolderType FolderType { get; set; }

        /// <summary>
        /// Checks to see if the FolderType property is set.
        /// </summary>
        internal bool IsSetFolderType() => this.FolderType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentFolderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the parent folder.
        /// </para>
        ///  
        /// <para>
        ///  <c>ParentFolderArn</c> can be null. An empty <c>parentFolderArn</c> creates a root-level
        /// folder.
        /// </para>
        /// </summary>
        public string ParentFolderArn { get; set; }

        /// <summary>
        /// Checks to see if the ParentFolderArn property is set.
        /// </summary>
        internal bool IsSetParentFolderArn() => this.ParentFolderArn != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A structure that describes the principals and the resource-level permissions of a
        /// folder.
        /// </para>
        ///  
        /// <para>
        /// To specify no permissions, omit <c>Permissions</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public List<ResourcePermission> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SharingModel. 
        /// <para>
        /// An optional parameter that determines the sharing scope of the folder. The default
        /// value for this parameter is <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        public SharingModel SharingModel { get; set; }

        /// <summary>
        /// Checks to see if the SharingModel property is set.
        /// </summary>
        internal bool IsSetSharingModel() => this.SharingModel != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the folder.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
