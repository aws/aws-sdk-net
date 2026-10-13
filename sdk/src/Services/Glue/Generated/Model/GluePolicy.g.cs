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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure for returning a resource policy.
    /// </summary>
    public partial class GluePolicy
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time at which the policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyHash. 
        /// <para>
        /// Contains the hash value associated with this policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PolicyHash { get; set; }

        /// <summary>
        /// Checks to see if the PolicyHash property is set.
        /// </summary>
        internal bool IsSetPolicyHash() => this.PolicyHash != null;

        /// <summary>
        /// Gets and sets the property PolicyInJson. 
        /// <para>
        /// Contains the requested policy document, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2)]
        public string PolicyInJson { get; set; }

        /// <summary>
        /// Checks to see if the PolicyInJson property is set.
        /// </summary>
        internal bool IsSetPolicyInJson() => this.PolicyInJson != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The date and time at which the policy was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
