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
    /// This is the response object from the CompareFaces operation.
    /// </summary>
    public partial class CompareFacesResponse : AmazonWebServiceResponse
    {
        private List<CompareFacesMatch> _faceMatches = new List<CompareFacesMatch>();
        private ComparedSourceImageFace _sourceImageFace;

        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// Provides an array of <code>CompareFacesMatch</code> objects. Each object provides
        /// the bounding box, confidence that the bounding box contains a face, and the similarity
        /// between the face in the bounding box and the face in the source image.
        /// </para>
        /// </summary>
        public List<CompareFacesMatch> FaceMatches
        {
            get { return this._faceMatches; }
            set { this._faceMatches = value; }
        }

        // Check to see if FaceMatches property is set
        internal bool IsSetFaceMatches()
        {
            return this._faceMatches != null && this._faceMatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceImageFace. 
        /// <para>
        /// The face from the source image that was used for comparison.
        /// </para>
        /// </summary>
        public ComparedSourceImageFace SourceImageFace
        {
            get { return this._sourceImageFace; }
            set { this._sourceImageFace = value; }
        }

        // Check to see if SourceImageFace property is set
        internal bool IsSetSourceImageFace()
        {
            return this._sourceImageFace != null;
        }

    }
}