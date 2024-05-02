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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private CategoricalParameterRangeSpecification _categoricalParameterRangeSpecification;
        private ContinuousParameterRangeSpecification _continuousParameterRangeSpecification;
        private IntegerParameterRangeSpecification _integerParameterRangeSpecification;

        /// <summary>
        /// Gets and sets the property CategoricalParameterRangeSpecification. 
        /// <para>
        /// A <c>CategoricalParameterRangeSpecification</c> object that defines the possible values
        /// for a categorical hyperparameter.
        /// </para>
        /// </summary>
        public CategoricalParameterRangeSpecification CategoricalParameterRangeSpecification
        {
            get { return this._categoricalParameterRangeSpecification; }
            set { this._categoricalParameterRangeSpecification = value; }
        }

        // Check to see if CategoricalParameterRangeSpecification property is set
        internal bool IsSetCategoricalParameterRangeSpecification()
        {
            return this._categoricalParameterRangeSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuousParameterRangeSpecification. 
        /// <para>
        /// A <c>ContinuousParameterRangeSpecification</c> object that defines the possible values
        /// for a continuous hyperparameter.
        /// </para>
        /// </summary>
        public ContinuousParameterRangeSpecification ContinuousParameterRangeSpecification
        {
            get { return this._continuousParameterRangeSpecification; }
            set { this._continuousParameterRangeSpecification = value; }
        }

        // Check to see if ContinuousParameterRangeSpecification property is set
        internal bool IsSetContinuousParameterRangeSpecification()
        {
            return this._continuousParameterRangeSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerParameterRangeSpecification. 
        /// <para>
        /// A <c>IntegerParameterRangeSpecification</c> object that defines the possible values
        /// for an integer hyperparameter.
        /// </para>
        /// </summary>
        public IntegerParameterRangeSpecification IntegerParameterRangeSpecification
        {
            get { return this._integerParameterRangeSpecification; }
            set { this._integerParameterRangeSpecification = value; }
        }

        // Check to see if IntegerParameterRangeSpecification property is set
        internal bool IsSetIntegerParameterRangeSpecification()
        {
            return this._integerParameterRangeSpecification != null;
        }

    }
}