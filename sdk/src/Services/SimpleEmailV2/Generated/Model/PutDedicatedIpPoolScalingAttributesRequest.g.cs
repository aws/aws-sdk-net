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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutDedicatedIpPoolScalingAttributes operation.
    /// Used to convert a dedicated IP pool to a different scaling mode. <note> <para> <c>MANAGED</c>
    /// pools cannot be converted to <c>STANDARD</c> scaling mode. </para> </note>
    /// </summary>
    public partial class PutDedicatedIpPoolScalingAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the dedicated IP pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PoolName { get; set; }

        /// <summary>
        /// Checks to see if the PoolName property is set.
        /// </summary>
        internal bool IsSetPoolName() => this.PoolName != null;

        /// <summary>
        /// Gets and sets the property ScalingMode. 
        /// <para>
        /// The scaling mode to apply to the dedicated IP pool.
        /// </para>
        ///  <note> 
        /// <para>
        /// Changing the scaling mode from <c>MANAGED</c> to <c>STANDARD</c> is not supported.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalingMode ScalingMode { get; set; }

        /// <summary>
        /// Checks to see if the ScalingMode property is set.
        /// </summary>
        internal bool IsSetScalingMode() => this.ScalingMode != null;
    }
}
