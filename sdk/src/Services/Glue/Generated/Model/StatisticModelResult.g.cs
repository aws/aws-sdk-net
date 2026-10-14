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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The statistic model result.
    /// </summary>
    public partial class StatisticModelResult
    {
        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The actual value.
        /// </para>
        /// </summary>
        public double? ActualValue { get; set; }

        /// <summary>
        /// Checks to see if the ActualValue property is set.
        /// </summary>
        internal bool IsSetActualValue() => this.ActualValue.HasValue;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date.
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property InclusionAnnotation. 
        /// <para>
        /// The inclusion annotation.
        /// </para>
        /// </summary>
        public InclusionAnnotationValue InclusionAnnotation { get; set; }

        /// <summary>
        /// Checks to see if the InclusionAnnotation property is set.
        /// </summary>
        internal bool IsSetInclusionAnnotation() => this.InclusionAnnotation != null;

        /// <summary>
        /// Gets and sets the property LowerBound. 
        /// <para>
        /// The lower bound.
        /// </para>
        /// </summary>
        public double? LowerBound { get; set; }

        /// <summary>
        /// Checks to see if the LowerBound property is set.
        /// </summary>
        internal bool IsSetLowerBound() => this.LowerBound.HasValue;

        /// <summary>
        /// Gets and sets the property PredictedValue. 
        /// <para>
        /// The predicted value.
        /// </para>
        /// </summary>
        public double? PredictedValue { get; set; }

        /// <summary>
        /// Checks to see if the PredictedValue property is set.
        /// </summary>
        internal bool IsSetPredictedValue() => this.PredictedValue.HasValue;

        /// <summary>
        /// Gets and sets the property UpperBound. 
        /// <para>
        /// The upper bound.
        /// </para>
        /// </summary>
        public double? UpperBound { get; set; }

        /// <summary>
        /// Checks to see if the UpperBound property is set.
        /// </summary>
        internal bool IsSetUpperBound() => this.UpperBound.HasValue;
    }
}
