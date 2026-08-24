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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Rate configuration for a metric (requests or tokens)
    /// </summary>
    public partial class RateConfig
    {
        private Period _period;
        private double? _rate;

        /// <summary>
        /// Gets and sets the property Period.
        /// </summary>
        [AWSProperty(Required=true)]
        public Period Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property Rate. 
        /// <para>
        /// The rate value for the limit. For request limits, this is the number of requests allowed
        /// per period. For token limits, this is the number of tokens allowed per period. For
        /// connection limits, this is the number of concurrent connections allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000000)]
        public double? Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }

        // Check to see if Rate property is set
        internal bool IsSetRate()
        {
            return this._rate.HasValue; 
        }

    }
}