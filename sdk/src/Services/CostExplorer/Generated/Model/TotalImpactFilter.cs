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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Filters cost anomalies based on the total impact.
    /// </summary>
    public partial class TotalImpactFilter
    {
        private double? _endValue;
        private NumericOperator _numericOperator;
        private double? _startValue;

        /// <summary>
        /// Gets and sets the property EndValue. 
        /// <para>
        /// The upper bound dollar value that's used in the filter. 
        /// </para>
        /// </summary>
        public double? EndValue
        {
            get { return this._endValue; }
            set { this._endValue = value; }
        }

        // Check to see if EndValue property is set
        internal bool IsSetEndValue()
        {
            return this._endValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumericOperator. 
        /// <para>
        /// The comparing value that's used in the filter. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NumericOperator NumericOperator
        {
            get { return this._numericOperator; }
            set { this._numericOperator = value; }
        }

        // Check to see if NumericOperator property is set
        internal bool IsSetNumericOperator()
        {
            return this._numericOperator != null;
        }

        /// <summary>
        /// Gets and sets the property StartValue. 
        /// <para>
        /// The lower bound dollar value that's used in the filter. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? StartValue
        {
            get { return this._startValue; }
            set { this._startValue = value; }
        }

        // Check to see if StartValue property is set
        internal bool IsSetStartValue()
        {
            return this._startValue.HasValue; 
        }

    }
}