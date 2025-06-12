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
    /// Container for the parameters to the CreateWorkspaceBundle operation.
    /// Creates the specified WorkSpace bundle. For more information about creating WorkSpace
    /// bundles, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/create-custom-bundle.html">
    /// Create a Custom WorkSpaces Image and Bundle</a>.
    /// </summary>
    public partial class CreateWorkspaceBundleRequest : AmazonWorkSpacesRequest
    {
        private string _bundleDescription;
        private string _bundleName;
        private ComputeType _computeType;
        private string _imageId;
        private RootStorage _rootStorage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private UserStorage _userStorage;

        /// <summary>
        /// Gets and sets the property BundleDescription. 
        /// <para>
        /// The description of the bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BundleDescription
        {
            get { return this._bundleDescription; }
            set { this._bundleDescription = value; }
        }

        // Check to see if BundleDescription property is set
        internal bool IsSetBundleDescription()
        {
            return this._bundleDescription != null;
        }

        /// <summary>
        /// Gets and sets the property BundleName. 
        /// <para>
        /// The name of the bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string BundleName
        {
            get { return this._bundleName; }
            set { this._bundleName = value; }
        }

        // Check to see if BundleName property is set
        internal bool IsSetBundleName()
        {
            return this._bundleName != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeType.
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the image that is used to create the bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property RootStorage.
        /// </summary>
        public RootStorage RootStorage
        {
            get { return this._rootStorage; }
            set { this._rootStorage = value; }
        }

        // Check to see if RootStorage property is set
        internal bool IsSetRootStorage()
        {
            return this._rootStorage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the bundle.
        /// </para>
        ///  <note> 
        /// <para>
        /// To add tags at the same time when you're creating the bundle, you must create an IAM
        /// policy that grants your IAM user permissions to use <c>workspaces:CreateTags</c>.
        /// 
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property UserStorage.
        /// </summary>
        [AWSProperty(Required=true)]
        public UserStorage UserStorage
        {
            get { return this._userStorage; }
            set { this._userStorage = value; }
        }

        // Check to see if UserStorage property is set
        internal bool IsSetUserStorage()
        {
            return this._userStorage != null;
        }

    }
}