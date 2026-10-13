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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
        private string _availabilityZoneId;
        private string _availabilityZoneName;
        private string _awsAccountId;
        private string _awsRegion;
        private string _containmentParentId;
        private string _identifier;
        private string _logicalResourceGroupId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the Availability Zone that hosts the resource, such as
        /// use1-az1. The Availability Zone ID is consistent across Amazon Web Services (AWS)
        /// accounts, unlike the Availability Zone name.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. 
        /// <para>
        /// The name of the Availability Zone that hosts the resource, such as us-west-2a.
        /// </para>
        /// </summary>
        public string AvailabilityZoneName
        {
            get { return this._availabilityZoneName; }
            set { this._availabilityZoneName = value; }
        }

        // Check to see if AvailabilityZoneName property is set
        internal bool IsSetAvailabilityZoneName()
        {
            return this._availabilityZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The AWS Region where the resource is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ContainmentParentId. 
        /// <para>
        /// The identifier of the single parent resource that contains this resource, used to
        /// represent containment relationships in the resource topology. A resource has at most
        /// one containment parent.
        /// </para>
        /// </summary>
        public string ContainmentParentId
        {
            get { return this._containmentParentId; }
            set { this._containmentParentId = value; }
        }

        // Check to see if ContainmentParentId property is set
        internal bool IsSetContainmentParentId()
        {
            return this._containmentParentId != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LogicalResourceGroupId. 
        /// <para>
        /// The identifier of the logical resource group that this resource belongs to. Resources
        /// that share this identifier are managed as a single unit.
        /// </para>
        /// </summary>
        public string LogicalResourceGroupId
        {
            get { return this._logicalResourceGroupId; }
            set { this._logicalResourceGroupId = value; }
        }

        // Check to see if LogicalResourceGroupId property is set
        internal bool IsSetLogicalResourceGroupId()
        {
            return this._logicalResourceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}