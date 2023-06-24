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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The liner axis scale setup.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class AxisLinearScale
    {
        private int? _stepCount;
        private double? _stepSize;

        /// <summary>
        /// Gets and sets the property StepCount. 
        /// <para>
        /// The step count setup of a linear axis.
        /// </para>
        /// </summary>
        public int StepCount
        {
            get { return this._stepCount.GetValueOrDefault(); }
            set { this._stepCount = value; }
        }

        // Check to see if StepCount property is set
        internal bool IsSetStepCount()
        {
            return this._stepCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepSize. 
        /// <para>
        /// The step size setup of a linear axis.
        /// </para>
        /// </summary>
        public double StepSize
        {
            get { return this._stepSize.GetValueOrDefault(); }
            set { this._stepSize = value; }
        }

        // Check to see if StepSize property is set
        internal bool IsSetStepSize()
        {
            return this._stepSize.HasValue; 
        }

    }
}