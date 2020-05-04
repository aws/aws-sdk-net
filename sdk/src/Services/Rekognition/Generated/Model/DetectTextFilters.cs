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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// A set of optional parameters that you can use to set the criteria that the text must
    /// meet to be included in your response. <code>WordFilter</code> looks at a word’s height,
    /// width, and minimum confidence. <code>RegionOfInterest</code> lets you set a specific
    /// region of the image to look for text in.
    /// </summary>
    public partial class DetectTextFilters
    {
        private List<RegionOfInterest> _regionsOfInterest = new List<RegionOfInterest>();
        private DetectionFilter _wordFilter;

        /// <summary>
        /// Gets and sets the property RegionsOfInterest. 
        /// <para>
        ///  A Filter focusing on a certain area of the image. Uses a <code>BoundingBox</code>
        /// object to set the region of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RegionOfInterest> RegionsOfInterest
        {
            get { return this._regionsOfInterest; }
            set { this._regionsOfInterest = value; }
        }

        // Check to see if RegionsOfInterest property is set
        internal bool IsSetRegionsOfInterest()
        {
            return this._regionsOfInterest != null && this._regionsOfInterest.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WordFilter.
        /// </summary>
        public DetectionFilter WordFilter
        {
            get { return this._wordFilter; }
            set { this._wordFilter = value; }
        }

        // Check to see if WordFilter property is set
        internal bool IsSetWordFilter()
        {
            return this._wordFilter != null;
        }

    }
}