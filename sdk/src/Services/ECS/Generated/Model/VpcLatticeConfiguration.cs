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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
        private string _portName;
        private string _roleArn;
        private string _targetGroupArn;

        /// <summary>
        /// Gets and sets the property PortName. 
        /// <para>
        /// The name of the port mapping to register in the VPC Lattice target group. This is
        /// the name of the <c>portMapping</c> you defined in your task definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PortName
        {
            get { return this._portName; }
            set { this._portName = value; }
        }

        // Check to see if PortName property is set
        internal bool IsSetPortName()
        {
            return this._portName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role to associate with this VPC Lattice configuration. This is
        /// the Amazon ECS&#x2028; infrastructure IAM role that is used to manage your VPC Lattice
        /// infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the target group or groups associated with
        /// the VPC Lattice configuration that the Amazon ECS tasks will be registered to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

    }
}