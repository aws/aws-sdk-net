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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about each finding type associated with the <c>groupedByFindingType</c>
    /// statistics.
    /// </summary>
    public partial class FindingTypeStatistics
    {
        private string _findingType;
        private DateTime? _lastGeneratedAt;
        private int? _totalFindings;

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// Name of the finding type.
        /// </para>
        /// </summary>
        public string FindingType
        {
            get { return this._findingType; }
            set { this._findingType = value; }
        }

        // Check to see if FindingType property is set
        internal bool IsSetFindingType()
        {
            return this._findingType != null;
        }

        /// <summary>
        /// Gets and sets the property LastGeneratedAt. 
        /// <para>
        /// The timestamp at which this finding type was last generated in your environment.
        /// </para>
        /// </summary>
        public DateTime? LastGeneratedAt
        {
            get { return this._lastGeneratedAt; }
            set { this._lastGeneratedAt = value; }
        }

        // Check to see if LastGeneratedAt property is set
        internal bool IsSetLastGeneratedAt()
        {
            return this._lastGeneratedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings associated with generated for each distinct finding type.
        /// </para>
        /// </summary>
        public int? TotalFindings
        {
            get { return this._totalFindings; }
            set { this._totalFindings = value; }
        }

        // Check to see if TotalFindings property is set
        internal bool IsSetTotalFindings()
        {
            return this._totalFindings.HasValue; 
        }

    }
}