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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about a resource that contains a software package.
    /// </summary>
    public partial class SoftwareResourceResult
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account that recorded the resource data in Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that recorded the resource data in Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceCloudPartition. 
        /// <para>
        /// The cloud partition where the resource exists. For Amazon Web Services, valid values
        /// include <c>aws</c>, <c>aws-cn</c>, and <c>aws-us-gov</c>. This field isn't returned
        /// for cloud providers that don't use partitions.
        /// </para>
        /// </summary>
        public string ResourceCloudPartition { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCloudPartition property is set.
        /// </summary>
        internal bool IsSetResourceCloudPartition() => this.ResourceCloudPartition != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier for a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccountId. 
        /// <para>
        /// The identifier of the cloud account that owns the resource. For Amazon Web Services
        /// resources, this is the Amazon Web Services account ID. For Azure resources, this is
        /// the Azure subscription ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerAccountId() => this.ResourceOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerOrgId. 
        /// <para>
        /// The identifier of the cloud organization that owns the resource. For Amazon Web Services
        /// resources, this is the Organizations ID. For Azure resources, this is the Azure tenant
        /// ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerOrgId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerOrgId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerOrgId() => this.ResourceOwnerOrgId != null;

        /// <summary>
        /// Gets and sets the property ResourceProvider. 
        /// <para>
        /// The cloud provider where the resource exists. Valid values are <c>AWS</c> and <c>Azure</c>.
        /// </para>
        /// </summary>
        public string ResourceProvider { get; set; }

        /// <summary>
        /// Checks to see if the ResourceProvider property is set.
        /// </summary>
        internal bool IsSetResourceProvider() => this.ResourceProvider != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The native cloud region where the resource is located. For Amazon Web Services, this
        /// is an Amazon Web Services Region (for example, <c>us-east-1</c>). For Azure resources,
        /// this is the Azure region (for example, <c>westus2</c>).
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource, for example <c>AWS::EC2::Instance</c> or <c>AWS::Lambda::Function</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
