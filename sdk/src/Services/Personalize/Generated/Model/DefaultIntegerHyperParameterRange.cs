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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Provides the name and default range of a integer-valued hyperparameter and whether
    /// the hyperparameter is tunable. A tunable hyperparameter can have its value determined
    /// during hyperparameter optimization (HPO).
    /// </summary>
    public partial class DefaultIntegerHyperParameterRange
    {
        private bool? _isTunable;
        private int? _maxValue;
        private int? _minValue;
        private string _name;

        /// <summary>
        /// Gets and sets the property IsTunable. 
        /// <para>
        /// Indicates whether the hyperparameter is tunable.
        /// </para>
        /// </summary>
        public bool? IsTunable
        {
            get { return this._isTunable; }
            set { this._isTunable = value; }
        }

        // Check to see if IsTunable property is set
        internal bool IsSetIsTunable()
        {
            return this._isTunable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum allowable value for the hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000000)]
        public int? MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum allowable value for the hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1000000)]
        public int? MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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