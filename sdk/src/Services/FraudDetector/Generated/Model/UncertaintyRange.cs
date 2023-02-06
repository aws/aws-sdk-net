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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Range of area under curve (auc) expected from the model. A range greater than 0.1
    /// indicates higher model uncertainity. A range is the difference between upper and lower
    /// bound of auc.
    /// </summary>
    public partial class UncertaintyRange
    {
        private float? _lowerBoundValue;
        private float? _upperBoundValue;

        /// <summary>
        /// Gets and sets the property LowerBoundValue. 
        /// <para>
        ///  The lower bound value of the area under curve (auc). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float LowerBoundValue
        {
            get { return this._lowerBoundValue.GetValueOrDefault(); }
            set { this._lowerBoundValue = value; }
        }

        // Check to see if LowerBoundValue property is set
        internal bool IsSetLowerBoundValue()
        {
            return this._lowerBoundValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpperBoundValue. 
        /// <para>
        ///  The lower bound value of the area under curve (auc). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float UpperBoundValue
        {
            get { return this._upperBoundValue.GetValueOrDefault(); }
            set { this._upperBoundValue = value; }
        }

        // Check to see if UpperBoundValue property is set
        internal bool IsSetUpperBoundValue()
        {
            return this._upperBoundValue.HasValue; 
        }

    }
}