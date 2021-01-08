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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents information about free trial device minutes for an AWS account.
    /// </summary>
    public partial class TrialMinutes
    {
        private double? _remaining;
        private double? _total;

        /// <summary>
        /// Gets and sets the property Remaining. 
        /// <para>
        /// The number of free trial minutes remaining in the account.
        /// </para>
        /// </summary>
        public double Remaining
        {
            get { return this._remaining.GetValueOrDefault(); }
            set { this._remaining = value; }
        }

        // Check to see if Remaining property is set
        internal bool IsSetRemaining()
        {
            return this._remaining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of free trial minutes that the account started with.
        /// </para>
        /// </summary>
        public double Total
        {
            get { return this._total.GetValueOrDefault(); }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}