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
    /// Container for the parameters to the DetectProtectiveEquipment operation.
    /// Detects Personal Protective Equipment (PPE) worn by people detected in an image. Amazon
    /// Rekognition can detect the following types of PPE.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Face cover
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Hand cover
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Head cover
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You pass the input image as base64-encoded image bytes or as a reference to an image
    /// in an Amazon S3 bucket. The image must be either a PNG or JPG formatted file. 
    /// </para>
    ///  
    /// <para>
    ///  <c>DetectProtectiveEquipment</c> detects PPE worn by up to 15 persons detected in
    /// an image.
    /// </para>
    ///  
    /// <para>
    /// For each person detected in the image the API returns an array of body parts (face,
    /// head, left-hand, right-hand). For each body part, an array of detected items of PPE
    /// is returned, including an indicator of whether or not the PPE covers the body part.
    /// The API returns the confidence it has in each detection (person, PPE, body part and
    /// body part coverage). It also returns a bounding box (<a>BoundingBox</a>) for each
    /// detected person and each detected item of PPE. 
    /// </para>
    ///  
    /// <para>
    /// You can optionally request a summary of detected PPE items with the <c>SummarizationAttributes</c>
    /// input parameter. The summary provides the following information. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The persons detected as wearing all of the types of PPE that you specify.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The persons detected as not wearing all of the types PPE that you specify.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The persons detected where PPE adornment could not be determined. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This is a stateless API operation. That is, the operation does not persist any data.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:DetectProtectiveEquipment</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DetectProtectiveEquipmentRequest : AmazonRekognitionRequest
    {
        private Image _image;
        private ProtectiveEquipmentSummarizationAttributes _summarizationAttributes;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image in which you want to detect PPE on detected persons. The image can be passed
        /// as image bytes or you can reference an image stored in an Amazon S3 bucket. 
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

        /// <summary>
        /// Gets and sets the property SummarizationAttributes. 
        /// <para>
        /// An array of PPE types that you want to summarize.
        /// </para>
        /// </summary>
        public ProtectiveEquipmentSummarizationAttributes SummarizationAttributes
        {
            get { return this._summarizationAttributes; }
            set { this._summarizationAttributes = value; }
        }

        // Check to see if SummarizationAttributes property is set
        internal bool IsSetSummarizationAttributes()
        {
            return this._summarizationAttributes != null;
        }

    }
}