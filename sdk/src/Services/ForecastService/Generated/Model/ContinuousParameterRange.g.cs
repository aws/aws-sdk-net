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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Specifies a continuous hyperparameter and it's range of tunable values. This object
    /// is part of the <a>ParameterRanges</a> object.
    /// </summary>
    public partial class ContinuousParameterRange
    {
        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum tunable value of the hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum tunable value of the hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hyperparameter to tune.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScalingType. 
        /// <para>
        /// The scale that hyperparameter tuning uses to search the hyperparameter range. Valid
        /// values:
        /// </para>
        ///  <dl> <dt>Auto</dt> <dd> 
        /// <para>
        /// Amazon Forecast hyperparameter tuning chooses the best scale for the hyperparameter.
        /// </para>
        ///  </dd> <dt>Linear</dt> <dd> 
        /// <para>
        /// Hyperparameter tuning searches the values in the hyperparameter range by using a linear
        /// scale.
        /// </para>
        ///  </dd> <dt>Logarithmic</dt> <dd> 
        /// <para>
        /// Hyperparameter tuning searches the values in the hyperparameter range by using a logarithmic
        /// scale.
        /// </para>
        ///  
        /// <para>
        /// Logarithmic scaling works only for ranges that have values greater than 0.
        /// </para>
        ///  </dd> <dt>ReverseLogarithmic</dt> <dd> 
        /// <para>
        /// hyperparameter tuning searches the values in the hyperparameter range by using a reverse
        /// logarithmic scale.
        /// </para>
        ///  
        /// <para>
        /// Reverse logarithmic scaling works only for ranges that are entirely within the range
        /// 0 &lt;= x &lt; 1.0.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For information about choosing a hyperparameter scale, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-ranges.html#scaling-type">Hyperparameter
        /// Scaling</a>. One of the following values:
        /// </para>
        /// </summary>
        public ScalingType ScalingType { get; set; }

        /// <summary>
        /// Checks to see if the ScalingType property is set.
        /// </summary>
        internal bool IsSetScalingType() => this.ScalingType != null;
    }
}
