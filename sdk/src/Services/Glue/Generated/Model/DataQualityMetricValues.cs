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
    /// Describes the data quality metric value according to the analysis of historical data.
    /// </summary>
    public partial class DataQualityMetricValues
    {
        private double? _actualValue;
        private double? _expectedValue;
        private double? _lowerLimit;
        private double? _upperLimit;

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The actual value of the data quality metric.
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
        /// Gets and sets the property ExpectedValue. 
        /// <para>
        /// The expected value of the data quality metric according to the analysis of historical
        /// data.
        /// </para>
        /// </summary>
        public double? ExpectedValue
        {
            get { return this._expectedValue; }
            set { this._expectedValue = value; }
        }

        // Check to see if ExpectedValue property is set
        internal bool IsSetExpectedValue()
        {
            return this._expectedValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LowerLimit. 
        /// <para>
        /// The lower limit of the data quality metric value according to the analysis of historical
        /// data.
        /// </para>
        /// </summary>
        public double? LowerLimit
        {
            get { return this._lowerLimit; }
            set { this._lowerLimit = value; }
        }

        // Check to see if LowerLimit property is set
        internal bool IsSetLowerLimit()
        {
            return this._lowerLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpperLimit. 
        /// <para>
        /// The upper limit of the data quality metric value according to the analysis of historical
        /// data.
        /// </para>
        /// </summary>
        public double? UpperLimit
        {
            get { return this._upperLimit; }
            set { this._upperLimit = value; }
        }

        // Check to see if UpperLimit property is set
        internal bool IsSetUpperLimit()
        {
            return this._upperLimit.HasValue; 
        }

    }
}