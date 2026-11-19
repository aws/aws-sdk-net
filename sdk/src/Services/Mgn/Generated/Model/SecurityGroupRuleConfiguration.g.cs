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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Behavioral configuration for a security group rule construct.
    /// </summary>
    public partial class SecurityGroupRuleConfiguration
    {
        /// <summary>
        /// Gets and sets the property EnableReferencing. 
        /// <para>
        /// Whether automatic conversion of CIDR-based sources and destinations to security group
        /// references applies to this rule.
        /// </para>
        /// </summary>
        public bool? EnableReferencing { get; set; }

        /// <summary>
        /// Checks to see if the EnableReferencing property is set.
        /// </summary>
        internal bool IsSetEnableReferencing() => this.EnableReferencing.HasValue;
    }
}
