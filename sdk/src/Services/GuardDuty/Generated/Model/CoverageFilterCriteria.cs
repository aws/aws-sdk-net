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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Represents the criteria used in the filter.
    /// </summary>
    public partial class CoverageFilterCriteria
    {
        private List<CoverageFilterCriterion> _filterCriterion = new List<CoverageFilterCriterion>();

        /// <summary>
        /// Gets and sets the property FilterCriterion. 
        /// <para>
        /// Represents a condition that when matched will be added to the response of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<CoverageFilterCriterion> FilterCriterion
        {
            get { return this._filterCriterion; }
            set { this._filterCriterion = value; }
        }

        // Check to see if FilterCriterion property is set
        internal bool IsSetFilterCriterion()
        {
            return this._filterCriterion != null && this._filterCriterion.Count > 0; 
        }

    }
}