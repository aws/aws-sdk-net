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
    /// Container for the parameters to the UpdateWorkspaceImagePermission operation.
    /// Shares or unshares an image with one account in the same Amazon Web Services Region
    /// by specifying whether that account has permission to copy the image. If the copy image
    /// permission is granted, the image is shared with that account. If the copy image permission
    /// is revoked, the image is unshared with the account.
    /// 
    ///  
    /// <para>
    /// After an image has been shared, the recipient account can copy the image to other
    /// Regions as needed.
    /// </para>
    ///  
    /// <para>
    /// In the China (Ningxia) Region, you can copy images only within the same Region.
    /// </para>
    ///  
    /// <para>
    /// In Amazon Web Services GovCloud (US), to copy images to and from other Regions, contact
    /// Amazon Web ServicesSupport.
    /// </para>
    ///  
    /// <para>
    /// For more information about sharing images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/share-custom-image.html">
    /// Share or Unshare a Custom WorkSpaces Image</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// To delete an image that has been shared, you must unshare the image before you delete
    /// it.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sharing Bring Your Own License (BYOL) images across Amazon Web Services accounts isn't
    /// supported at this time in Amazon Web Services GovCloud (US). To share BYOL images
    /// across accounts in Amazon Web Services GovCloud (US), contact Amazon Web ServicesSupport.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class UpdateWorkspaceImagePermissionRequest : AmazonWorkSpacesRequest
    {
        private bool? _allowCopyImage;
        private string _imageId;
        private string _sharedAccountId;

        /// <summary>
        /// Gets and sets the property AllowCopyImage. 
        /// <para>
        /// The permission to copy the image. This permission can be revoked only after an image
        /// has been shared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AllowCopyImage
        {
            get { return this._allowCopyImage; }
            set { this._allowCopyImage = value; }
        }

        // Check to see if AllowCopyImage property is set
        internal bool IsSetAllowCopyImage()
        {
            return this._allowCopyImage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the image.
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
        /// Gets and sets the property SharedAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account to share or unshare the image with.
        /// </para>
        ///  <important> 
        /// <para>
        /// Before sharing the image, confirm that you are sharing to the correct Amazon Web Services
        /// account ID.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SharedAccountId
        {
            get { return this._sharedAccountId; }
            set { this._sharedAccountId = value; }
        }

        // Check to see if SharedAccountId property is set
        internal bool IsSetSharedAccountId()
        {
            return this._sharedAccountId != null;
        }

    }
}