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
    /// Contains details that are specific to the type of a resource. The member that is set
    /// matches the <c>ResourceType</c> of the resource, except that <c>RdsDbInstance</c>
    /// and <c>RdsDbUser</c> can be set together.
    /// </summary>
    public partial class InvestigationResourceData
    {
        /// <summary>
        /// Gets and sets the property Ec2Instance. 
        /// <para>
        /// Details about an Amazon EC2 instance.
        /// </para>
        /// </summary>
        public InvestigationEc2Instance Ec2Instance { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Instance property is set.
        /// </summary>
        internal bool IsSetEc2Instance() => this.Ec2Instance != null;

        /// <summary>
        /// Gets and sets the property EcsCluster. 
        /// <para>
        /// Details about an Amazon ECS cluster.
        /// </para>
        /// </summary>
        public InvestigationEcsCluster EcsCluster { get; set; }

        /// <summary>
        /// Checks to see if the EcsCluster property is set.
        /// </summary>
        internal bool IsSetEcsCluster() => this.EcsCluster != null;

        /// <summary>
        /// Gets and sets the property EksCluster. 
        /// <para>
        /// Details about an Amazon EKS cluster.
        /// </para>
        /// </summary>
        public InvestigationEksCluster EksCluster { get; set; }

        /// <summary>
        /// Checks to see if the EksCluster property is set.
        /// </summary>
        internal bool IsSetEksCluster() => this.EksCluster != null;

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// Details about an Lambda function.
        /// </para>
        /// </summary>
        public LambdaFunction LambdaFunction { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunction property is set.
        /// </summary>
        internal bool IsSetLambdaFunction() => this.LambdaFunction != null;

        /// <summary>
        /// Gets and sets the property RdsDbInstance. 
        /// <para>
        /// Details about an Amazon RDS database instance.
        /// </para>
        /// </summary>
        public RdsDbInstance RdsDbInstance { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbInstance property is set.
        /// </summary>
        internal bool IsSetRdsDbInstance() => this.RdsDbInstance != null;

        /// <summary>
        /// Gets and sets the property RdsDbUser. 
        /// <para>
        /// Details about the user that logged in to an Amazon RDS database instance.
        /// </para>
        /// </summary>
        public RdsDbUser RdsDbUser { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbUser property is set.
        /// </summary>
        internal bool IsSetRdsDbUser() => this.RdsDbUser != null;
    }
}
