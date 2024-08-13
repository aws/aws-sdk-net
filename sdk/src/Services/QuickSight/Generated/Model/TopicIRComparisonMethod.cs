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
    /// The definition of a <c>TopicIRComparisonMethod</c>.
    /// </summary>
    public partial class TopicIRComparisonMethod
    {
        private TopicTimeGranularity _period;
        private ComparisonMethodType _type;
        private int? _windowSize;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period for the <c>TopicIRComparisonMethod</c>.
        /// </para>
        /// </summary>
        public TopicTimeGranularity Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type for the <c>TopicIRComparisonMethod</c>.
        /// </para>
        /// </summary>
        public ComparisonMethodType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WindowSize. 
        /// <para>
        /// The window size for the <c>TopicIRComparisonMethod</c>.
        /// </para>
        /// </summary>
        public int? WindowSize
        {
            get { return this._windowSize; }
            set { this._windowSize = value; }
        }

        // Check to see if WindowSize property is set
        internal bool IsSetWindowSize()
        {
            return this._windowSize.HasValue; 
        }

    }
}