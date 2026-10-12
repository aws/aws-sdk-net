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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The throttling configuration for a web function endpoint.
    /// </summary>
    public partial class ThrottleConfig
    {
        private int? _rateLimit;

        /// <summary>
        /// Gets and sets the property RateLimit. 
        /// <para>
        /// The maximum request rate per second for the endpoint. The value must be one of the
        /// following supported values: <c>0</c>, <c>100</c>, <c>200</c>, <c>300</c>, <c>400</c>,
        /// <c>500</c>, <c>600</c>, <c>700</c>, <c>800</c>, <c>900</c>, <c>1000</c>, <c>2000</c>,
        /// <c>3000</c>, <c>4000</c>, <c>5000</c>, <c>6000</c>, <c>7000</c>, <c>8000</c>, <c>9000</c>,
        /// or <c>10000</c>. The maximum effective value is also bounded by your account-level
        /// maximum total rate limit. There is no default value. If you don't specify a value,
        /// the throttling configuration is absent from the response. On an update, omit <c>throttleConfig</c>
        /// to keep the current value, or specify an empty object to clear a previously set value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RateLimit
        {
            get { return this._rateLimit; }
            set { this._rateLimit = value; }
        }

        // Check to see if RateLimit property is set
        internal bool IsSetRateLimit()
        {
            return this._rateLimit.HasValue; 
        }

    }
}