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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about custom data identifiers that produced a sensitive data
    /// finding, and the number of occurrences of the data that they detected for the finding.
    /// </summary>
    public partial class CustomDataIdentifiers
    {
        private List<CustomDetection> _detections = new List<CustomDetection>();
        private long? _totalCount;

        /// <summary>
        /// Gets and sets the property Detections. 
        /// <para>
        /// The custom data identifiers that detected the data, and the number of occurrences
        /// of the data that each identifier detected.
        /// </para>
        /// </summary>
        public List<CustomDetection> Detections
        {
            get { return this._detections; }
            set { this._detections = value; }
        }

        // Check to see if Detections property is set
        internal bool IsSetDetections()
        {
            return this._detections != null && this._detections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of occurrences of the data that was detected by the custom data identifiers
        /// and produced the finding.
        /// </para>
        /// </summary>
        public long TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}