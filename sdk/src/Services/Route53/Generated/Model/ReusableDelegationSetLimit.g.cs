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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the type of limit that you specified in the request and
    /// the current value for that limit.
    /// </summary>
    public partial class ReusableDelegationSetLimit
    {
        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The limit that you requested: <c>MAX_ZONES_BY_REUSABLE_DELEGATION_SET</c>, the maximum
        /// number of hosted zones that you can associate with the specified reusable delegation
        /// set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReusableDelegationSetLimitType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current value for the <c>MAX_ZONES_BY_REUSABLE_DELEGATION_SET</c> limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
