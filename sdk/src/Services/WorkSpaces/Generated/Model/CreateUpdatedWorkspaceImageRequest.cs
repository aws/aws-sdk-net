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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUpdatedWorkspaceImage operation.
    /// Creates a new updated WorkSpace image based on the specified source image. The new
    /// updated WorkSpace image has the latest drivers and other updates required by the Amazon
    /// WorkSpaces components.
    /// 
    ///  
    /// <para>
    /// To determine which WorkSpace images need to be updated with the latest Amazon WorkSpaces
    /// requirements, use <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImages.html">
    /// DescribeWorkspaceImages</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// Only Windows 10, Windows Server 2016, and Windows Server 2019 WorkSpace images can
    /// be programmatically updated at this time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Microsoft Windows updates and other application updates are not included in the update
    /// process.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The source WorkSpace image is not deleted. You can delete the source image after you've
    /// verified your new updated image and created a new bundle. 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateUpdatedWorkspaceImageRequest : AmazonWorkSpacesRequest
    {
        private string _description;
        private string _name;
        private string _sourceImageId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of whether updates for the WorkSpace image are available.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The name of the new updated WorkSpace image.
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
        /// The identifier of the source WorkSpace image.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you want to add to the new updated WorkSpace image.
        /// </para>
        ///  <note> 
        /// <para>
        /// To add tags at the same time when you're creating the updated image, you must create
        /// an IAM policy that grants your IAM user permissions to use <code>workspaces:CreateTags</code>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}