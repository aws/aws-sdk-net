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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition for a <c>TopicIRContributionAnalysis</c>.
    /// </summary>
    public partial class TopicIRContributionAnalysis
    {
        private ContributionAnalysisDirection _direction;
        private List<ContributionAnalysisFactor> _factors = AWSConfigs.InitializeCollections ? new List<ContributionAnalysisFactor>() : null;
        private ContributionAnalysisSortType _sortType;
        private ContributionAnalysisTimeRanges _timeRanges;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction for the <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// </summary>
        public ContributionAnalysisDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property Factors. 
        /// <para>
        /// The factors for a <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<ContributionAnalysisFactor> Factors
        {
            get { return this._factors; }
            set { this._factors = value; }
        }

        // Check to see if Factors property is set
        internal bool IsSetFactors()
        {
            return this._factors != null && (this._factors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SortType. 
        /// <para>
        /// The sort type for the <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// </summary>
        public ContributionAnalysisSortType SortType
        {
            get { return this._sortType; }
            set { this._sortType = value; }
        }

        // Check to see if SortType property is set
        internal bool IsSetSortType()
        {
            return this._sortType != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRanges. 
        /// <para>
        /// The time ranges for the <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// </summary>
        public ContributionAnalysisTimeRanges TimeRanges
        {
            get { return this._timeRanges; }
            set { this._timeRanges = value; }
        }

        // Check to see if TimeRanges property is set
        internal bool IsSetTimeRanges()
        {
            return this._timeRanges != null;
        }

    }
}