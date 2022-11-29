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
    /// The logarithmic axis scale setup.
    /// </summary>
    public partial class AxisLogarithmicScale
    {
        private double? _base;

        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// The base setup of a logarithmic axis scale.
        /// </para>
        /// </summary>
        public double Base
        {
            get { return this._base.GetValueOrDefault(); }
            set { this._base = value; }
        }

        // Check to see if Base property is set
        internal bool IsSetBase()
        {
            return this._base.HasValue; 
        }

    }
}