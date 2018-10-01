/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DetectFaces operation.
    /// Detects faces within an image that is provided as input.
    /// 
    ///  
    /// <para>
    ///  <code>DetectFaces</code> detects the 100 largest faces in the image. For each face
    /// detected, the operation returns face details. These details include a bounding box
    /// of the face, a confidence value (that the bounding box contains a face), and a fixed
    /// set of attributes such as facial landmarks (for example, coordinates of eye and mouth),
    /// gender, presence of beard, sunglasses, and so on. 
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
    /// This operation requires permissions to perform the <code>rekognition:DetectFaces</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DetectFacesRequest : AmazonRekognitionRequest
    {
        private List<string> _attributes = new List<string>();
        private Image _image;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// An array of facial attributes you want to be returned. This can be the default list
        /// of attributes or all attributes. If you don't specify a value for <code>Attributes</code>
        /// or if you specify <code>["DEFAULT"]</code>, the API returns the following subset of
        /// facial attributes: <code>BoundingBox</code>, <code>Confidence</code>, <code>Pose</code>,
        /// <code>Quality</code>, and <code>Landmarks</code>. If you provide <code>["ALL"]</code>,
        /// all facial attributes are returned, but the operation takes longer to complete.
        /// </para>
        ///  
        /// <para>
        /// If you provide both, <code>["ALL", "DEFAULT"]</code>, the service uses a logical AND
        /// operator to determine which attributes to return (in this case, all attributes). 
        /// </para>
        /// </summary>
        public List<string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing base64-encoded image bytes is not supported.
        /// 
        /// </para>
        /// </summary>
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