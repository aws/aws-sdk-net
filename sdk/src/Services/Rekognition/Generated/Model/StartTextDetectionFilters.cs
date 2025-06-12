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
    /// Set of optional parameters that let you set the criteria text must meet to be included
    /// in your response. <c>WordFilter</c> looks at a word's height, width and minimum confidence.
    /// <c>RegionOfInterest</c> lets you set a specific region of the screen to look for text
    /// in.
    /// </summary>
    public partial class StartTextDetectionFilters
    {
        private List<RegionOfInterest> _regionsOfInterest = AWSConfigs.InitializeCollections ? new List<RegionOfInterest>() : null;
        private DetectionFilter _wordFilter;

        /// <summary>
        /// Gets and sets the property RegionsOfInterest. 
        /// <para>
        /// Filter focusing on a certain area of the frame. Uses a <c>BoundingBox</c> object to
        /// set the region of the screen.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._regionsOfInterest != null && (this._regionsOfInterest.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WordFilter. 
        /// <para>
        /// Filters focusing on qualities of the text, such as confidence or size.
        /// </para>
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