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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private double? _actualValue;
        private DateTime? _date;
        private InclusionAnnotationValue _inclusionAnnotation;
        private double? _lowerBound;
        private double? _predictedValue;
        private double? _upperBound;

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The actual value.
        /// </para>
        /// </summary>
        public double? ActualValue
        {
            get { return this._actualValue; }
            set { this._actualValue = value; }
        }

        // Check to see if ActualValue property is set
        internal bool IsSetActualValue()
        {
            return this._actualValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date.
        /// </para>
        /// </summary>
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InclusionAnnotation. 
        /// <para>
        /// The inclusion annotation.
        /// </para>
        /// </summary>
        public InclusionAnnotationValue InclusionAnnotation
        {
            get { return this._inclusionAnnotation; }
            set { this._inclusionAnnotation = value; }
        }

        // Check to see if InclusionAnnotation property is set
        internal bool IsSetInclusionAnnotation()
        {
            return this._inclusionAnnotation != null;
        }

        /// <summary>
        /// Gets and sets the property LowerBound. 
        /// <para>
        /// The lower bound.
        /// </para>
        /// </summary>
        public double? LowerBound
        {
            get { return this._lowerBound; }
            set { this._lowerBound = value; }
        }

        // Check to see if LowerBound property is set
        internal bool IsSetLowerBound()
        {
            return this._lowerBound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictedValue. 
        /// <para>
        /// The predicted value.
        /// </para>
        /// </summary>
        public double? PredictedValue
        {
            get { return this._predictedValue; }
            set { this._predictedValue = value; }
        }

        // Check to see if PredictedValue property is set
        internal bool IsSetPredictedValue()
        {
            return this._predictedValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpperBound. 
        /// <para>
        /// The upper bound.
        /// </para>
        /// </summary>
        public double? UpperBound
        {
            get { return this._upperBound; }
            set { this._upperBound = value; }
        }

        // Check to see if UpperBound property is set
        internal bool IsSetUpperBound()
        {
            return this._upperBound.HasValue; 
        }

    }
}