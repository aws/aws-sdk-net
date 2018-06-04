/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of continuous hyperparameters to tune.
    /// </summary>
    public partial class ContinuousParameterRange
    {
        private string _maxValue;
        private string _minValue;
        private string _name;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum value for the hyperparameter. The tuning job uses floating-point values
        /// between <code>MinValue</code> value and this value for tuning.
        /// </para>
        /// </summary>
        public string MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue != null;
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum value for the hyperparameter. The tuning job uses floating-point values
        /// between this value and <code>MaxValue</code>for tuning.
        /// </para>
        /// </summary>
        public string MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the continuous hyperparameter to tune.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}