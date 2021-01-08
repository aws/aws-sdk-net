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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Specifies a location within the frame that Rekognition checks for text. Uses a <code>BoundingBox</code>
    /// object to set a region of the screen.
    /// 
    ///  
    /// <para>
    /// A word is included in the region if the word is more than half in that region. If
    /// there is more than one region, the word will be compared with all regions of the screen.
    /// Any word more than half in a region is kept in the results.
    /// </para>
    /// </summary>
    public partial class RegionOfInterest
    {
        private BoundingBox _boundingBox;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// The box representing a region of interest on screen.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null;
        }

    }
}