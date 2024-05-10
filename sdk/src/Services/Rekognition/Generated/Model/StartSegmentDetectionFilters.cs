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
    /// Filters applied to the technical cue or shot detection segments. For more information,
    /// see <a>StartSegmentDetection</a>.
    /// </summary>
    public partial class StartSegmentDetectionFilters
    {
        private StartShotDetectionFilter _shotFilter;
        private StartTechnicalCueDetectionFilter _technicalCueFilter;

        /// <summary>
        /// Gets and sets the property ShotFilter. 
        /// <para>
        /// Filters that are specific to shot detections.
        /// </para>
        /// </summary>
        public StartShotDetectionFilter ShotFilter
        {
            get { return this._shotFilter; }
            set { this._shotFilter = value; }
        }

        // Check to see if ShotFilter property is set
        internal bool IsSetShotFilter()
        {
            return this._shotFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TechnicalCueFilter. 
        /// <para>
        /// Filters that are specific to technical cues.
        /// </para>
        /// </summary>
        public StartTechnicalCueDetectionFilter TechnicalCueFilter
        {
            get { return this._technicalCueFilter; }
            set { this._technicalCueFilter = value; }
        }

        // Check to see if TechnicalCueFilter property is set
        internal bool IsSetTechnicalCueFilter()
        {
            return this._technicalCueFilter != null;
        }

    }
}