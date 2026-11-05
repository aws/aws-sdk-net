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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUpdatedWorkspaceImage operation. Creates
    /// a new updated WorkSpace image based on the specified source image. The new updated
    /// WorkSpace image has the latest drivers and other updates required by the Amazon WorkSpaces
    /// components. <para> To determine which WorkSpace images need to be updated with the
    /// latest Amazon WorkSpaces requirements, use <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImages.html">
    /// DescribeWorkspaceImages</a>. </para> <note> <ul> <li> <para> Only Windows 10, Windows
    /// Server 2016, and Windows Server 2019 WorkSpace images can be programmatically updated
    /// at this time. </para> </li> <li> <para> Microsoft Windows updates and other application
    /// updates are not included in the update process. </para> </li> <li> <para> The source
    /// WorkSpace image is not deleted. You can delete the source image after you've verified
    /// your new updated image and created a new bundle. </para> </li> </ul> </note>
    /// </summary>
    public partial class CreateUpdatedWorkspaceImageRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of whether updates for the WorkSpace image are available.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new updated WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SourceImageId. 
        /// <para>
        /// The identifier of the source WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceImageId { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageId property is set.
        /// </summary>
        internal bool IsSetSourceImageId() => this.SourceImageId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you want to add to the new updated WorkSpace image.
        /// </para>
        ///  <note> 
        /// <para>
        /// To add tags at the same time when you're creating the updated image, you must create
        /// an IAM policy that grants your IAM user permissions to use <c>workspaces:CreateTags</c>.
        /// 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
