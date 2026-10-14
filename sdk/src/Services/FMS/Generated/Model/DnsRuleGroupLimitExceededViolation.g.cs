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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// The VPC that Firewall Manager was applying a DNS Fireall policy to reached the limit
    /// for associated DNS Firewall rule groups. Firewall Manager tried to associate another
    /// rule group with the VPC and failed due to the limit.
    /// </summary>
    public partial class DnsRuleGroupLimitExceededViolation
    {
        /// <summary>
        /// Gets and sets the property NumberOfRuleGroupsAlreadyAssociated. 
        /// <para>
        /// The number of rule groups currently associated with the VPC. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? NumberOfRuleGroupsAlreadyAssociated { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRuleGroupsAlreadyAssociated property is set.
        /// </summary>
        internal bool IsSetNumberOfRuleGroupsAlreadyAssociated() => this.NumberOfRuleGroupsAlreadyAssociated.HasValue;

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// Information about the VPC ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ViolationTarget { get; set; }

        /// <summary>
        /// Checks to see if the ViolationTarget property is set.
        /// </summary>
        internal bool IsSetViolationTarget() => this.ViolationTarget != null;

        /// <summary>
        /// Gets and sets the property ViolationTargetDescription. 
        /// <para>
        /// A description of the violation that specifies the rule group and VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ViolationTargetDescription { get; set; }

        /// <summary>
        /// Checks to see if the ViolationTargetDescription property is set.
        /// </summary>
        internal bool IsSetViolationTargetDescription() => this.ViolationTargetDescription != null;
    }
}
