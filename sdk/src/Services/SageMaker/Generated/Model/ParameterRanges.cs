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
    /// Specifies ranges of integer, continuous, and categorical hyperparameters that a hyperparameter
    /// tuning job searches. The hyperparameter tuning job launches training jobs with hyperparameter
    /// values within these ranges to find the combination of values that result in the training
    /// job with the best performance as measured by the objective metric of the hyperparameter
    /// tuning job.
    /// 
    ///  <note> 
    /// <para>
    /// The maximum number of items specified for <c>Array Members</c> refers to the maximum
    /// number of hyperparameters for each range and also the maximum for the hyperparameter
    /// tuning job itself. That is, the sum of the number of hyperparameters for all the ranges
    /// can't exceed the maximum number specified.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ParameterRanges
    {
        private List<AutoParameter> _autoParameters = AWSConfigs.InitializeCollections ? new List<AutoParameter>() : null;
        private List<CategoricalParameterRange> _categoricalParameterRanges = AWSConfigs.InitializeCollections ? new List<CategoricalParameterRange>() : null;
        private List<ContinuousParameterRange> _continuousParameterRanges = AWSConfigs.InitializeCollections ? new List<ContinuousParameterRange>() : null;
        private List<IntegerParameterRange> _integerParameterRanges = AWSConfigs.InitializeCollections ? new List<IntegerParameterRange>() : null;

        /// <summary>
        /// Gets and sets the property AutoParameters. 
        /// <para>
        /// A list containing hyperparameter names and example values to be used by Autotune to
        /// determine optimal ranges for your tuning job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AutoParameter> AutoParameters
        {
            get { return this._autoParameters; }
            set { this._autoParameters = value; }
        }

        // Check to see if AutoParameters property is set
        internal bool IsSetAutoParameters()
        {
            return this._autoParameters != null && (this._autoParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CategoricalParameterRanges. 
        /// <para>
        /// The array of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CategoricalParameterRange.html">CategoricalParameterRange</a>
        /// objects that specify ranges of categorical hyperparameters that a hyperparameter tuning
        /// job searches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<CategoricalParameterRange> CategoricalParameterRanges
        {
            get { return this._categoricalParameterRanges; }
            set { this._categoricalParameterRanges = value; }
        }

        // Check to see if CategoricalParameterRanges property is set
        internal bool IsSetCategoricalParameterRanges()
        {
            return this._categoricalParameterRanges != null && (this._categoricalParameterRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContinuousParameterRanges. 
        /// <para>
        /// The array of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContinuousParameterRange.html">ContinuousParameterRange</a>
        /// objects that specify ranges of continuous hyperparameters that a hyperparameter tuning
        /// job searches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<ContinuousParameterRange> ContinuousParameterRanges
        {
            get { return this._continuousParameterRanges; }
            set { this._continuousParameterRanges = value; }
        }

        // Check to see if ContinuousParameterRanges property is set
        internal bool IsSetContinuousParameterRanges()
        {
            return this._continuousParameterRanges != null && (this._continuousParameterRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegerParameterRanges. 
        /// <para>
        /// The array of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_IntegerParameterRange.html">IntegerParameterRange</a>
        /// objects that specify ranges of integer hyperparameters that a hyperparameter tuning
        /// job searches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<IntegerParameterRange> IntegerParameterRanges
        {
            get { return this._integerParameterRanges; }
            set { this._integerParameterRanges = value; }
        }

        // Check to see if IntegerParameterRanges property is set
        internal bool IsSetIntegerParameterRanges()
        {
            return this._integerParameterRanges != null && (this._integerParameterRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}