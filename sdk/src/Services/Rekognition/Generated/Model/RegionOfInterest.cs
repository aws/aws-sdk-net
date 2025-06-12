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
    /// Specifies a location within the frame that Rekognition checks for objects of interest
    /// such as text, labels, or faces. It uses a <c>BoundingBox</c> or <c>Polygon</c> to
    /// set a region of the screen.
    /// 
    ///  
    /// <para>
    /// A word, face, or label is included in the region if it is more than half in that region.
    /// If there is more than one region, the word, face, or label is compared with all regions
    /// of the screen. Any object of interest that is more than half in a region is kept in
    /// the results.
    /// </para>
    /// </summary>
    public partial class RegionOfInterest
    {
        private BoundingBox _boundingBox;
        private List<Point> _polygon = AWSConfigs.InitializeCollections ? new List<Point>() : null;

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

        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        ///  Specifies a shape made up of up to 10 <c>Point</c> objects to define a region of
        /// interest. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Point> Polygon
        {
            get { return this._polygon; }
            set { this._polygon = value; }
        }

        // Check to see if Polygon property is set
        internal bool IsSetPolygon()
        {
            return this._polygon != null && (this._polygon.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}