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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
        private DetectLabelsImageProperties _imageProperties;
        private string _labelModelVersion;
        private List<Label> _labels = AWSConfigs.InitializeCollections ? new List<Label>() : null;
        private OrientationCorrection _orientationCorrection;

        /// <summary>
        /// Gets and sets the property ImageProperties. 
        /// <para>
        /// Information about the properties of the input image, such as brightness, sharpness,
        /// contrast, and dominant colors.
        /// </para>
        /// </summary>
        public DetectLabelsImageProperties ImageProperties
        {
            get { return this._imageProperties; }
            set { this._imageProperties = value; }
        }

        // Check to see if ImageProperties property is set
        internal bool IsSetImageProperties()
        {
            return this._imageProperties != null;
        }

        /// <summary>
        /// Gets and sets the property LabelModelVersion. 
        /// <para>
        /// Version number of the label detection model that was used to detect labels.
        /// </para>
        /// </summary>
        public string LabelModelVersion
        {
            get { return this._labelModelVersion; }
            set { this._labelModelVersion = value; }
        }

        // Check to see if LabelModelVersion property is set
        internal bool IsSetLabelModelVersion()
        {
            return this._labelModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// An array of labels for the real-world objects detected. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Label> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public OrientationCorrection OrientationCorrection
        {
            get { return this._orientationCorrection; }
            set { this._orientationCorrection = value; }
        }

        // Check to see if OrientationCorrection property is set
        internal bool IsSetOrientationCorrection()
        {
            return this._orientationCorrection != null;
        }

    }
}