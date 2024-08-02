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
    /// The definition for the <c>ContributionAnalysisTimeRanges</c>.
    /// </summary>
    public partial class ContributionAnalysisTimeRanges
    {
        private TopicIRFilterOption _endRange;
        private TopicIRFilterOption _startRange;

        /// <summary>
        /// Gets and sets the property EndRange. 
        /// <para>
        /// The end range for the <c>ContributionAnalysisTimeRanges</c>.
        /// </para>
        /// </summary>
        public TopicIRFilterOption EndRange
        {
            get { return this._endRange; }
            set { this._endRange = value; }
        }

        // Check to see if EndRange property is set
        internal bool IsSetEndRange()
        {
            return this._endRange != null;
        }

        /// <summary>
        /// Gets and sets the property StartRange. 
        /// <para>
        /// The start range for the <c>ContributionAnalysisTimeRanges</c>.
        /// </para>
        /// </summary>
        public TopicIRFilterOption StartRange
        {
            get { return this._startRange; }
            set { this._startRange = value; }
        }

        // Check to see if StartRange property is set
        internal bool IsSetStartRange()
        {
            return this._startRange != null;
        }

    }
}