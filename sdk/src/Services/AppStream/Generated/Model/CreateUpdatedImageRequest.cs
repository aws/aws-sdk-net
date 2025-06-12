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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUpdatedImage operation.
    /// Creates a new image with the latest Windows operating system updates, driver updates,
    /// and AppStream 2.0 agent software.
    /// 
    ///  
    /// <para>
    /// For more information, see the "Update an Image by Using Managed AppStream 2.0 Image
    /// Updates" section in <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/administer-images.html">Administer
    /// Your AppStream 2.0 Images</a>, in the <i>Amazon AppStream 2.0 Administration Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateUpdatedImageRequest : AmazonAppStreamRequest
    {
        private bool? _dryRun;
        private string _existingImageName;
        private string _newImageDescription;
        private string _newImageDisplayName;
        private string _newImageName;
        private Dictionary<string, string> _newImageTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Indicates whether to display the status of image update availability before AppStream
        /// 2.0 initiates the process of creating a new updated image. If this value is set to
        /// <c>true</c>, AppStream 2.0 displays whether image updates are available. If this value
        /// is set to <c>false</c>, AppStream 2.0 initiates the process of creating a new updated
        /// image without displaying whether image updates are available.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExistingImageName. 
        /// <para>
        /// The name of the image to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExistingImageName
        {
            get { return this._existingImageName; }
            set { this._existingImageName = value; }
        }

        // Check to see if ExistingImageName property is set
        internal bool IsSetExistingImageName()
        {
            return this._existingImageName != null;
        }

        /// <summary>
        /// Gets and sets the property NewImageDescription. 
        /// <para>
        /// The description to display for the new image.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string NewImageDescription
        {
            get { return this._newImageDescription; }
            set { this._newImageDescription = value; }
        }

        // Check to see if NewImageDescription property is set
        internal bool IsSetNewImageDescription()
        {
            return this._newImageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property NewImageDisplayName. 
        /// <para>
        /// The name to display for the new image.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string NewImageDisplayName
        {
            get { return this._newImageDisplayName; }
            set { this._newImageDisplayName = value; }
        }

        // Check to see if NewImageDisplayName property is set
        internal bool IsSetNewImageDisplayName()
        {
            return this._newImageDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property NewImageName. 
        /// <para>
        /// The name of the new image. The name must be unique within the AWS account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NewImageName
        {
            get { return this._newImageName; }
            set { this._newImageName = value; }
        }

        // Check to see if NewImageName property is set
        internal bool IsSetNewImageName()
        {
            return this._newImageName != null;
        }

        /// <summary>
        /// Gets and sets the property NewImageTags. 
        /// <para>
        /// The tags to associate with the new image. A tag is a key-value pair, and the value
        /// is optional. For example, Environment=Test. If you do not specify a value, Environment=.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Generally allowed characters are: letters, numbers, and spaces representable in UTF-8,
        /// and the following special characters: 
        /// </para>
        ///  
        /// <para>
        /// _ . : / = + \ - @
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the value is set to an empty string.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> NewImageTags
        {
            get { return this._newImageTags; }
            set { this._newImageTags = value; }
        }

        // Check to see if NewImageTags property is set
        internal bool IsSetNewImageTags()
        {
            return this._newImageTags != null && (this._newImageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}