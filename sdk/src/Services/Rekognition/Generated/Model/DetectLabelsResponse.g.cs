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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the DetectLabels operation.
    /// </summary>
    public partial class DetectLabelsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ImageProperties. 
        /// <para>
        /// Information about the properties of the input image, such as brightness, sharpness,
        /// contrast, and dominant colors.
        /// </para>
        /// </summary>
        public DetectLabelsImageProperties ImageProperties { get; set; }

        /// <summary>
        /// Checks to see if the ImageProperties property is set.
        /// </summary>
        internal bool IsSetImageProperties() => this.ImageProperties != null;

        /// <summary>
        /// Gets and sets the property LabelModelVersion. 
        /// <para>
        /// Version number of the label detection model that was used to detect labels.
        /// </para>
        /// </summary>
        public string LabelModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the LabelModelVersion property is set.
        /// </summary>
        internal bool IsSetLabelModelVersion() => this.LabelModelVersion != null;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// An array of labels for the real-world objects detected. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Label> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<Label>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrientationCorrection. 
        /// <para>
        /// The value of <c>OrientationCorrection</c> is always null.
        /// </para>
        ///  
        /// <para>
        /// If the input image is in .jpeg format, it might contain exchangeable image file format
        /// (Exif) metadata that includes the image's orientation. Amazon Rekognition uses this
        /// orientation information to perform image correction. The bounding box coordinates
        /// are translated to represent object locations after the orientation information in
        /// the Exif metadata is used to correct the image orientation. Images in .png format
        /// don't contain Exif metadata.
        /// </para>
        ///  
        /// <para>
        /// Amazon Rekognition doesn’t perform image correction for images in .png format and
        /// .jpeg images without orientation information in the image Exif metadata. The bounding
        /// box coordinates aren't translated and represent the object locations before the image
        /// is rotated. 
        /// </para>
        /// </summary>
        public OrientationCorrection OrientationCorrection { get; set; }

        /// <summary>
        /// Checks to see if the OrientationCorrection property is set.
        /// </summary>
        internal bool IsSetOrientationCorrection() => this.OrientationCorrection != null;
    }
}
