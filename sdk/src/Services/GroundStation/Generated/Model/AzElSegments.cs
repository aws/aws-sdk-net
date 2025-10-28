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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Azimuth elevation segment collection.
    /// 
    ///  
    /// <para>
    /// Contains five or more time-ordered segments that define antenna pointing angles over
    /// the ephemeris validity period.
    /// </para>
    /// </summary>
    public partial class AzElSegments
    {
        private AngleUnits _angleUnit;
        private List<AzElSegment> _azElSegmentList = AWSConfigs.InitializeCollections ? new List<AzElSegment>() : null;

        /// <summary>
        /// Gets and sets the property AngleUnit. 
        /// <para>
        /// The unit of measure for azimuth and elevation angles. All angles in all segments must
        /// use the same unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AngleUnits AngleUnit
        {
            get { return this._angleUnit; }
            set { this._angleUnit = value; }
        }

        // Check to see if AngleUnit property is set
        internal bool IsSetAngleUnit()
        {
            return this._angleUnit != null;
        }

        /// <summary>
        /// Gets and sets the property AzElSegmentList. 
        /// <para>
        /// List of azimuth elevation segments.
        /// </para>
        ///  
        /// <para>
        /// Must contain between 1 and 100 segments. Segments must be in chronological order with
        /// no overlaps.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<AzElSegment> AzElSegmentList
        {
            get { return this._azElSegmentList; }
            set { this._azElSegmentList = value; }
        }

        // Check to see if AzElSegmentList property is set
        internal bool IsSetAzElSegmentList()
        {
            return this._azElSegmentList != null && (this._azElSegmentList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}