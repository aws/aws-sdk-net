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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// For a hyperparameter of the integer type, specifies the range that a hyperparameter
    /// tuning job searches.
    /// </summary>
    public partial class IntegerParameterRange
    {
        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum value of the hyperparameter to search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue != null;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum value of the hyperparameter to search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hyperparameter to search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScalingType. 
        /// <para>
        /// The scale that hyperparameter tuning uses to search the hyperparameter range. For
        /// information about choosing a hyperparameter scale, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-ranges.html#scaling-type">Hyperparameter
        /// Scaling</a>. One of the following values:
        /// </para>
        ///  <dl> <dt>Auto</dt> <dd> 
        /// <para>
        /// SageMaker hyperparameter tuning chooses the best scale for the hyperparameter.
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
        /// Logarithmic scaling works only for ranges that have only values greater than 0.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public HyperParameterScalingType ScalingType { get; set; }

        /// <summary>
        /// Checks to see if the ScalingType property is set.
        /// </summary>
        internal bool IsSetScalingType() => this.ScalingType != null;
    }
}
