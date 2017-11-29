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
    /// Container for the parameters to the RecognizeCelebrities operation.
    /// Returns an array of celebrities recognized in the input image. For more information,
    /// see <a>celebrities</a>. 
    /// 
    ///  
    /// <para>
    ///  <code>RecognizeCelebrities</code> returns the 100 largest faces in the image. It
    /// lists recognized celebrities in the <code>CelebrityFaces</code> array and unrecognized
    /// faces in the <code>UnrecognizedFaces</code> array. <code>RecognizeCelebrities</code>
    /// doesn't return celebrities whose faces are not amongst the largest 100 faces in the
    /// image.
    /// </para>
    ///  
    /// <para>
    /// For each celebrity recognized, the <code>RecognizeCelebrities</code> returns a <code>Celebrity</code>
    /// object. The <code>Celebrity</code> object contains the celebrity name, ID, URL links
    /// to additional information, match confidence, and a <code>ComparedFace</code> object
    /// that you can use to locate the celebrity's face on the image.
    /// </para>
    ///  
    /// <para>
    /// Rekognition does not retain information about which images a celebrity has been recognized
    /// in. Your application must store this information and use the <code>Celebrity</code>
    /// ID property as a unique identifier for the celebrity. If you don't store the celebrity
    /// name or additional information URLs returned by <code>RecognizeCelebrities</code>,
    /// you will need the ID to identify the celebrity in a call to the operation.
    /// </para>
    ///  
    /// <para>
    /// You pass the imput image either as base64-encoded image bytes or as a reference to
    /// an image in an Amazon S3 bucket. If you use the Amazon CLI to call Amazon Rekognition
    /// operations, passing image bytes is not supported. The image must be either a PNG or
    /// JPEG formatted file. 
    /// </para>
    ///  
    /// <para>
    /// For an example, see <a>celebrities-procedure-image</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:RecognizeCelebrities</code>
    /// operation.
    /// </para>
    /// </summary>
    public partial class RecognizeCelebritiesRequest : AmazonRekognitionRequest
    {
        private Image _image;

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