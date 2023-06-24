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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Information regarding a detected signature on a page.
    /// </summary>
    public partial class SignatureDetection
    {
        private float? _confidence;
        private Geometry _geometry;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence, from 0 to 100, in the predicted values for a detected signature.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Geometry.
        /// </summary>
        public Geometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

    }
}