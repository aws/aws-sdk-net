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
    /// This is the response object from the DetectLabels operation.
    /// </summary>
    public partial class DetectLabelsResponse : AmazonWebServiceResponse
    {
        private List<Label> _labels = new List<Label>();
        private OrientationCorrection _orientationCorrection;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// An array of labels for the real-world objects detected. 
        /// </para>
        /// </summary>
        public List<Label> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrientationCorrection. 
        /// <para>
        ///  Amazon Rekognition returns the orientation of the input image that was detected (clockwise
        /// direction). If your application displays the image, you can use this value to correct
        /// the orientation. If Amazon Rekognition detects that the input image was rotated (for
        /// example, by 90 degrees), it first corrects the orientation before detecting the labels.
        /// 
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