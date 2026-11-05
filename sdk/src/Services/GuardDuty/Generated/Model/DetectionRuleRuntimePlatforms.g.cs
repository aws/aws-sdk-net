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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// The platforms on which a Runtime Monitoring custom detection rule can run. A member's
    /// presence is the support statement: when present, the rule runs on that platform and
    /// <c>minAgentVersion</c> is the minimum GuardDuty agent version required there. When
    /// absent, the rule cannot run on that platform at any agent version.
    /// </summary>
    public partial class DetectionRuleRuntimePlatforms
    {
        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// The requirements for running the rule on Amazon EC2.
        /// </para>
        /// </summary>
        public DetectionRuleEc2Requirements Ec2 { get; set; }

        /// <summary>
        /// Checks to see if the Ec2 property is set.
        /// </summary>
        internal bool IsSetEc2() => this.Ec2 != null;

        /// <summary>
        /// Gets and sets the property EcsFargate. 
        /// <para>
        /// The requirements for running the rule on Amazon ECS with the Fargate launch type.
        /// </para>
        /// </summary>
        public DetectionRuleEcsFargateRequirements EcsFargate { get; set; }

        /// <summary>
        /// Checks to see if the EcsFargate property is set.
        /// </summary>
        internal bool IsSetEcsFargate() => this.EcsFargate != null;

        /// <summary>
        /// Gets and sets the property Eks. 
        /// <para>
        /// The requirements for running the rule on Amazon EKS.
        /// </para>
        /// </summary>
        public DetectionRuleEksRequirements Eks { get; set; }

        /// <summary>
        /// Checks to see if the Eks property is set.
        /// </summary>
        internal bool IsSetEks() => this.Eks != null;
    }
}
