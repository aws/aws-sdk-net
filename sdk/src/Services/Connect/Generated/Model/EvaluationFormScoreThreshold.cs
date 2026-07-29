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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a score threshold for a performance category.
    /// </summary>
    public partial class EvaluationFormScoreThreshold
    {
        private double? _maxScorePercentage;
        private double? _minScorePercentage;
        private PerformanceCategoryName _performanceCategory;

        /// <summary>
        /// Gets and sets the property MaxScorePercentage. 
        /// <para>
        /// The maximum score percentage for the performance category.
        /// </para>
        /// </summary>
        public double? MaxScorePercentage
        {
            get { return this._maxScorePercentage; }
            set { this._maxScorePercentage = value; }
        }

        // Check to see if MaxScorePercentage property is set
        internal bool IsSetMaxScorePercentage()
        {
            return this._maxScorePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinScorePercentage. 
        /// <para>
        /// The minimum score percentage for the performance category.
        /// </para>
        /// </summary>
        public double? MinScorePercentage
        {
            get { return this._minScorePercentage; }
            set { this._minScorePercentage = value; }
        }

        // Check to see if MinScorePercentage property is set
        internal bool IsSetMinScorePercentage()
        {
            return this._minScorePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformanceCategory. 
        /// <para>
        /// The performance category name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PerformanceCategoryName PerformanceCategory
        {
            get { return this._performanceCategory; }
            set { this._performanceCategory = value; }
        }

        // Check to see if PerformanceCategory property is set
        internal bool IsSetPerformanceCategory()
        {
            return this._performanceCategory != null;
        }

    }
}