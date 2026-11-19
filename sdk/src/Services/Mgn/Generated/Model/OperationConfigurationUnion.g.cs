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
    /// Construct-type-specific behavioral configuration. The variant provided must match
    /// the construct type.
    /// </summary>
    public partial class OperationConfigurationUnion
    {
        /// <summary>
        /// Gets and sets the property SecurityGroup. 
        /// <para>
        /// Behavioral configuration for a security group construct.
        /// </para>
        /// </summary>
        public SecurityGroupConfiguration SecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroup property is set.
        /// </summary>
        internal bool IsSetSecurityGroup() => this.SecurityGroup != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupRule. 
        /// <para>
        /// Behavioral configuration for a security group rule construct.
        /// </para>
        /// </summary>
        public SecurityGroupRuleConfiguration SecurityGroupRule { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupRule property is set.
        /// </summary>
        internal bool IsSetSecurityGroupRule() => this.SecurityGroupRule != null;
    }
}
