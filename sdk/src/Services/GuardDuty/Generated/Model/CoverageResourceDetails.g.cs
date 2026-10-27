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
    /// Information about the resource for each individual EKS cluster.
    /// </summary>
    public partial class CoverageResourceDetails
    {
        /// <summary>
        /// Gets and sets the property Ec2InstanceDetails. 
        /// <para>
        /// Information about the Amazon EC2 instance assessed for runtime coverage.
        /// </para>
        /// </summary>
        public CoverageEc2InstanceDetails Ec2InstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceDetails property is set.
        /// </summary>
        internal bool IsSetEc2InstanceDetails() => this.Ec2InstanceDetails != null;

        /// <summary>
        /// Gets and sets the property EcsClusterDetails. 
        /// <para>
        /// Information about the Amazon ECS cluster that is assessed for runtime coverage.
        /// </para>
        /// </summary>
        public CoverageEcsClusterDetails EcsClusterDetails { get; set; }

        /// <summary>
        /// Checks to see if the EcsClusterDetails property is set.
        /// </summary>
        internal bool IsSetEcsClusterDetails() => this.EcsClusterDetails != null;

        /// <summary>
        /// Gets and sets the property EksClusterDetails. 
        /// <para>
        /// EKS cluster details involved in the coverage statistics.
        /// </para>
        /// </summary>
        public CoverageEksClusterDetails EksClusterDetails { get; set; }

        /// <summary>
        /// Checks to see if the EksClusterDetails property is set.
        /// </summary>
        internal bool IsSetEksClusterDetails() => this.EksClusterDetails != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
