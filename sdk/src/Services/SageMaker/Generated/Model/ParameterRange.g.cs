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
    /// Defines the possible values for categorical, continuous, and integer hyperparameters
    /// to be used by an algorithm.
    /// </summary>
    public partial class ParameterRange
    {
        /// <summary>
        /// Gets and sets the property CategoricalParameterRangeSpecification. 
        /// <para>
        /// A <c>CategoricalParameterRangeSpecification</c> object that defines the possible values
        /// for a categorical hyperparameter.
        /// </para>
        /// </summary>
        public CategoricalParameterRangeSpecification CategoricalParameterRangeSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CategoricalParameterRangeSpecification property is set.
        /// </summary>
        internal bool IsSetCategoricalParameterRangeSpecification() => this.CategoricalParameterRangeSpecification != null;

        /// <summary>
        /// Gets and sets the property ContinuousParameterRangeSpecification. 
        /// <para>
        /// A <c>ContinuousParameterRangeSpecification</c> object that defines the possible values
        /// for a continuous hyperparameter.
        /// </para>
        /// </summary>
        public ContinuousParameterRangeSpecification ContinuousParameterRangeSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ContinuousParameterRangeSpecification property is set.
        /// </summary>
        internal bool IsSetContinuousParameterRangeSpecification() => this.ContinuousParameterRangeSpecification != null;

        /// <summary>
        /// Gets and sets the property IntegerParameterRangeSpecification. 
        /// <para>
        /// A <c>IntegerParameterRangeSpecification</c> object that defines the possible values
        /// for an integer hyperparameter.
        /// </para>
        /// </summary>
        public IntegerParameterRangeSpecification IntegerParameterRangeSpecification { get; set; }

        /// <summary>
        /// Checks to see if the IntegerParameterRangeSpecification property is set.
        /// </summary>
        internal bool IsSetIntegerParameterRangeSpecification() => this.IntegerParameterRangeSpecification != null;
    }
}
