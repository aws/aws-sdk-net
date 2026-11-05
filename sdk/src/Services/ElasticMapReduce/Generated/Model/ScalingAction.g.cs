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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The type of adjustment the automatic scaling activity makes when triggered, and the
    /// periodicity of the adjustment.
    /// </summary>
    public partial class ScalingAction
    {
        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// Not available for instance groups. Instance groups use the market type specified for
        /// the group.
        /// </para>
        /// </summary>
        public MarketType Market { get; set; }

        /// <summary>
        /// Checks to see if the Market property is set.
        /// </summary>
        internal bool IsSetMarket() => this.Market != null;

        /// <summary>
        /// Gets and sets the property SimpleScalingPolicyConfiguration. 
        /// <para>
        /// The type of adjustment the automatic scaling activity makes when triggered, and the
        /// periodicity of the adjustment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SimpleScalingPolicyConfiguration SimpleScalingPolicyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SimpleScalingPolicyConfiguration property is set.
        /// </summary>
        internal bool IsSetSimpleScalingPolicyConfiguration() => this.SimpleScalingPolicyConfiguration != null;
    }
}
