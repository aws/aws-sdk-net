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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the monthly data transfer in and out of your virtual private server (or
    /// <i>instance</i>).
    /// </summary>
    public partial class MonthlyTransfer
    {
        private int? _gbPerMonthAllocated;

        /// <summary>
        /// Gets and sets the property GbPerMonthAllocated. 
        /// <para>
        /// The amount allocated per month (in GB).
        /// </para>
        /// </summary>
        public int GbPerMonthAllocated
        {
            get { return this._gbPerMonthAllocated.GetValueOrDefault(); }
            set { this._gbPerMonthAllocated = value; }
        }

        // Check to see if GbPerMonthAllocated property is set
        internal bool IsSetGbPerMonthAllocated()
        {
            return this._gbPerMonthAllocated.HasValue; 
        }

    }
}