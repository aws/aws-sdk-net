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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Returns the throttle settings.
    /// </summary>
    public partial class ThrottleSettings
    {
        private int? _burstLimit;
        private double? _rateLimit;

        /// <summary>
        /// Gets and sets the property BurstLimit. 
        /// <para>
        /// Returns the burstLimit when <b>ThrottleSettings</b> is called.
        /// </para>
        /// </summary>
        public int BurstLimit
        {
            get { return this._burstLimit.GetValueOrDefault(); }
            set { this._burstLimit = value; }
        }

        // Check to see if BurstLimit property is set
        internal bool IsSetBurstLimit()
        {
            return this._burstLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateLimit. 
        /// <para>
        /// Returns the rateLimit when <b>ThrottleSettings</b> is called.
        /// </para>
        /// </summary>
        public double RateLimit
        {
            get { return this._rateLimit.GetValueOrDefault(); }
            set { this._rateLimit = value; }
        }

        // Check to see if RateLimit property is set
        internal bool IsSetRateLimit()
        {
            return this._rateLimit.HasValue; 
        }

    }
}