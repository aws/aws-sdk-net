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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The VPC Lattice configuration for your service that holds the information for the
    /// target group(s) Amazon ECS tasks will be registered to.
    /// </summary>
    public partial class VpcLatticeConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdvancedConfiguration.
        /// </summary>
        public VpcLatticeAdvancedConfiguration AdvancedConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedConfiguration property is set.
        /// </summary>
        internal bool IsSetAdvancedConfiguration() => this.AdvancedConfiguration != null;

        /// <summary>
        /// Gets and sets the property PortName. 
        /// <para>
        /// The name of the port mapping to register in the VPC Lattice target group. This is
        /// the name of the <c>portMapping</c> you defined in your task definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PortName { get; set; }

        /// <summary>
        /// Checks to see if the PortName property is set.
        /// </summary>
        internal bool IsSetPortName() => this.PortName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role to associate with this VPC Lattice configuration. This is
        /// the Amazon ECS infrastructure IAM role that is used to manage your VPC Lattice infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the target group or groups associated with
        /// the VPC Lattice configuration that the Amazon ECS tasks will be registered to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupArn property is set.
        /// </summary>
        internal bool IsSetTargetGroupArn() => this.TargetGroupArn != null;
    }
}
