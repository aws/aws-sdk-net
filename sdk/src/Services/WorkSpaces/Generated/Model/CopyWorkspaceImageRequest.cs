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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
    /// Container for the parameters to the CopyWorkspaceImage operation.
    /// Copies the specified image from the specified Region to the current Region. For more
    /// information about copying images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/copy-custom-image.html">
    /// Copy a Custom WorkSpaces Image</a>.
    /// 
    ///  
    /// <para>
    /// In the China (Ningxia) Region, you can copy images only within the same Region.
    /// </para>
    ///  
    /// <para>
    /// In Amazon Web Services GovCloud (US), to copy images to and from other Regions, contact
    /// Amazon Web ServicesSupport.
    /// </para>
    ///  <important> 
    /// <para>
    /// Before copying a shared image, be sure to verify that it has been shared from the
    /// correct Amazon Web Services account. To determine if an image has been shared and
    /// to see the ID of the Amazon Web Services account that owns an image, use the <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImages.html">DescribeWorkSpaceImages</a>
    /// and <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImagePermissions.html">DescribeWorkspaceImagePermissions</a>
    /// API operations. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CopyWorkspaceImageRequest : AmazonWorkSpacesRequest
    {
        private string _description;
        private string _name;
        private string _sourceImageId;
        private string _sourceRegion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property SourceImageId. 
        /// <para>
        /// The identifier of the source image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceImageId
        {
            get { return this._sourceImageId; }
            set { this._sourceImageId = value; }
        }

        // Check to see if SourceImageId property is set
        internal bool IsSetSourceImageId()
        {
            return this._sourceImageId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The identifier of the source Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=31)]
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}