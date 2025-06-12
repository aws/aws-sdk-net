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
    /// Container for the parameters to the DetectFaces operation.
    /// Detects faces within an image that is provided as input.
    /// 
    ///  
    /// <para>
    ///  <c>DetectFaces</c> detects the 100 largest faces in the image. For each face detected,
    /// the operation returns face details. These details include a bounding box of the face,
    /// a confidence value (that the bounding box contains a face), and a fixed set of attributes
    /// such as facial landmarks (for example, coordinates of eye and mouth), pose, presence
    /// of facial occlusion, and so on.
    /// </para>
    ///  
    /// <para>
    /// The face-detection algorithm is most effective on frontal faces. For non-frontal or
    /// obscured faces, the algorithm might not detect the faces or might detect faces with
    /// lower confidence. 
    /// </para>
    ///  
    /// <para>
    /// You pass the input image either as base64-encoded image bytes or as a reference to
    /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
    /// operations, passing image bytes is not supported. The image must be either a PNG or
    /// JPEG formatted file. 
    /// </para>
    ///  <note> 
    /// <para>
    /// This is a stateless API operation. That is, the operation does not persist any data.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:DetectFaces</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DetectFacesRequest : AmazonRekognitionRequest
    {
        private List<string> _attributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Image _image;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// An array of facial attributes you want to be returned. A <c>DEFAULT</c> subset of
        /// facial attributes - <c>BoundingBox</c>, <c>Confidence</c>, <c>Pose</c>, <c>Quality</c>,
        /// and <c>Landmarks</c> - will always be returned. You can request for specific facial
        /// attributes (in addition to the default list) - by using [<c>"DEFAULT", "FACE_OCCLUDED"</c>]
        /// or just [<c>"FACE_OCCLUDED"</c>]. You can request for all facial attributes by using
        /// [<c>"ALL"]</c>. Requesting more attributes may increase response time.
        /// </para>
        ///  
        /// <para>
        /// If you provide both, <c>["ALL", "DEFAULT"]</c>, the service uses a logical "AND" operator
        /// to determine which attributes to return (in this case, all attributes). 
        /// </para>
        ///  
        /// <para>
        /// Note that while the FaceOccluded and EyeDirection attributes are supported when using
        /// <c>DetectFaces</c>, they aren't supported when analyzing videos with <c>StartFaceDetection</c>
        /// and <c>GetFaceDetection</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing base64-encoded image bytes is not supported.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you are using an AWS SDK to call Amazon Rekognition, you might not need to base64-encode
        /// image bytes passed using the <c>Bytes</c> field. For more information, see Images
        /// in the Amazon Rekognition developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

    }
}