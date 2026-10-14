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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An object where you specify the anticipated traffic pattern for an endpoint.
    /// </summary>
    public partial class ScalingPolicyObjective
    {
        /// <summary>
        /// Gets and sets the property MaxInvocationsPerMinute. 
        /// <para>
        /// The maximum number of expected requests to your endpoint per minute.
        /// </para>
        /// </summary>
        public int? MaxInvocationsPerMinute { get; set; }

        /// <summary>
        /// Checks to see if the MaxInvocationsPerMinute property is set.
        /// </summary>
        internal bool IsSetMaxInvocationsPerMinute() => this.MaxInvocationsPerMinute.HasValue;

        /// <summary>
        /// Gets and sets the property MinInvocationsPerMinute. 
        /// <para>
        /// The minimum number of expected requests to your endpoint per minute.
        /// </para>
        /// </summary>
        public int? MinInvocationsPerMinute { get; set; }

        /// <summary>
        /// Checks to see if the MinInvocationsPerMinute property is set.
        /// </summary>
        internal bool IsSetMinInvocationsPerMinute() => this.MinInvocationsPerMinute.HasValue;
    }
}
