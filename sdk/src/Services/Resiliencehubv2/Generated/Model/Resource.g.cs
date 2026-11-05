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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents an AWS resource discovered by Resilience Hub.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the Availability Zone that hosts the resource, such as
        /// use1-az1. The Availability Zone ID is consistent across Amazon Web Services (AWS)
        /// accounts, unlike the Availability Zone name.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. 
        /// <para>
        /// The name of the Availability Zone that hosts the resource, such as us-west-2a.
        /// </para>
        /// </summary>
        public string AvailabilityZoneName { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneName property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneName() => this.AvailabilityZoneName != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The AWS Region where the resource is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property ContainmentParentId. 
        /// <para>
        /// The identifier of the single parent resource that contains this resource, used to
        /// represent containment relationships in the resource topology. A resource has at most
        /// one containment parent.
        /// </para>
        /// </summary>
        public string ContainmentParentId { get; set; }

        /// <summary>
        /// Checks to see if the ContainmentParentId property is set.
        /// </summary>
        internal bool IsSetContainmentParentId() => this.ContainmentParentId != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LogicalResourceGroupId. 
        /// <para>
        /// The identifier of the logical resource group that this resource belongs to. Resources
        /// that share this identifier are managed as a single unit.
        /// </para>
        /// </summary>
        public string LogicalResourceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the LogicalResourceGroupId property is set.
        /// </summary>
        internal bool IsSetLogicalResourceGroupId() => this.LogicalResourceGroupId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
