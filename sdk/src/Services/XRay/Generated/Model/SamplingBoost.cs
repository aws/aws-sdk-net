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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Temporary boost sampling rate. X-Ray calculates sampling boost for each service based
    /// on the recent sampling boost stats of all services that called <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingTargets.html">GetSamplingTargets</a>.
    /// </summary>
    public partial class SamplingBoost
    {
        private double? _boostRate;
        private DateTime? _boostRateTTL;

        /// <summary>
        /// Gets and sets the property BoostRate. 
        /// <para>
        /// The calculated sampling boost rate for this service 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? BoostRate
        {
            get { return this._boostRate; }
            set { this._boostRate = value; }
        }

        // Check to see if BoostRate property is set
        internal bool IsSetBoostRate()
        {
            return this._boostRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BoostRateTTL. 
        /// <para>
        /// When the sampling boost expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? BoostRateTTL
        {
            get { return this._boostRateTTL; }
            set { this._boostRateTTL = value; }
        }

        // Check to see if BoostRateTTL property is set
        internal bool IsSetBoostRateTTL()
        {
            return this._boostRateTTL.HasValue; 
        }

    }
}