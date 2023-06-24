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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The contribution analysis visual display for a line, pie, or bar chart.
    /// </summary>
    public partial class ContributionAnalysisDefault
    {
        private List<ColumnIdentifier> _contributorDimensions = new List<ColumnIdentifier>();
        private string _measureFieldId;

        /// <summary>
        /// Gets and sets the property ContributorDimensions. 
        /// <para>
        /// The dimensions columns that are used in the contribution analysis, usually a list
        /// of <code>ColumnIdentifiers</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<ColumnIdentifier> ContributorDimensions
        {
            get { return this._contributorDimensions; }
            set { this._contributorDimensions = value; }
        }

        // Check to see if ContributorDimensions property is set
        internal bool IsSetContributorDimensions()
        {
            return this._contributorDimensions != null && this._contributorDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MeasureFieldId. 
        /// <para>
        /// The measure field that is used in the contribution analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string MeasureFieldId
        {
            get { return this._measureFieldId; }
            set { this._measureFieldId = value; }
        }

        // Check to see if MeasureFieldId property is set
        internal bool IsSetMeasureFieldId()
        {
            return this._measureFieldId != null;
        }

    }
}