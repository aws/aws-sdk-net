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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUpdatedImage operation. Creates a new image
    /// with the latest Windows operating system updates, driver updates, and WorkSpaces Applications
    /// agent software. <para> For more information, see the "Update an Image by Using Managed
    /// WorkSpaces Applications Image Updates" section in <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/administer-images.html">Administer
    /// Your WorkSpaces Applications Images</a>, in the <i>Amazon WorkSpaces Applications
    /// Administration Guide</i>. </para>
    /// </summary>
    public partial class CreateUpdatedImageRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Indicates whether to display the status of image update availability before WorkSpaces
        /// Applications initiates the process of creating a new updated image. If this value
        /// is set to <c>true</c>, WorkSpaces Applications displays whether image updates are
        /// available. If this value is set to <c>false</c>, WorkSpaces Applications initiates
        /// the process of creating a new updated image without displaying whether image updates
        /// are available.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ExistingImageName. 
        /// <para>
        /// The name of the image to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExistingImageName { get; set; }

        /// <summary>
        /// Checks to see if the ExistingImageName property is set.
        /// </summary>
        internal bool IsSetExistingImageName() => this.ExistingImageName != null;

        /// <summary>
        /// Gets and sets the property NewImageDescription. 
        /// <para>
        /// The description to display for the new image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NewImageDescription { get; set; }

        /// <summary>
        /// Checks to see if the NewImageDescription property is set.
        /// </summary>
        internal bool IsSetNewImageDescription() => this.NewImageDescription != null;

        /// <summary>
        /// Gets and sets the property NewImageDisplayName. 
        /// <para>
        /// The name to display for the new image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string NewImageDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the NewImageDisplayName property is set.
        /// </summary>
        internal bool IsSetNewImageDisplayName() => this.NewImageDisplayName != null;

        /// <summary>
        /// Gets and sets the property NewImageName. 
        /// <para>
        /// The name of the new image. The name must be unique within the AWS account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NewImageName { get; set; }

        /// <summary>
        /// Checks to see if the NewImageName property is set.
        /// </summary>
        internal bool IsSetNewImageName() => this.NewImageName != null;

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
        /// Your Resources</a> in the <i>Amazon WorkSpaces Applications Administration Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> NewImageTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the NewImageTags property is set.
        /// </summary>
        internal bool IsSetNewImageTags() => this.NewImageTags != null && (this.NewImageTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
