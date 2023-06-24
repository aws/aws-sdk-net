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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains the percentage of traffic to send to a staging distribution.
    /// </summary>
    public partial class ContinuousDeploymentSingleWeightConfig
    {
        private SessionStickinessConfig _sessionStickinessConfig;
        private float? _weight;

        /// <summary>
        /// Gets and sets the property SessionStickinessConfig.
        /// </summary>
        public SessionStickinessConfig SessionStickinessConfig
        {
            get { return this._sessionStickinessConfig; }
            set { this._sessionStickinessConfig = value; }
        }

        // Check to see if SessionStickinessConfig property is set
        internal bool IsSetSessionStickinessConfig()
        {
            return this._sessionStickinessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The percentage of traffic to send to a staging distribution, expressed as a decimal
        /// number between 0 and .15.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}