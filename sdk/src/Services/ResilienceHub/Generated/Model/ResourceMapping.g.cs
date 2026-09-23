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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a resource mapping.
    /// </summary>
    public partial class ResourceMapping
    {
        /// <summary>
        /// Gets and sets the property AppRegistryAppName. 
        /// <para>
        /// Name of the application this resource is mapped to when the <c>mappingType</c> is
        /// <c>AppRegistryApp</c>.
        /// </para>
        /// </summary>
        public string AppRegistryAppName { get; set; }

        /// <summary>
        /// Checks to see if the AppRegistryAppName property is set.
        /// </summary>
        internal bool IsSetAppRegistryAppName() => this.AppRegistryAppName != null;

        /// <summary>
        /// Gets and sets the property EksSourceName. 
        /// <para>
        /// Name of the Amazon Elastic Kubernetes Service cluster and namespace that this resource
        /// is mapped to when the <c>mappingType</c> is <c>EKS</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter accepts values in "eks-cluster/namespace" format.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EksSourceName { get; set; }

        /// <summary>
        /// Checks to see if the EksSourceName property is set.
        /// </summary>
        internal bool IsSetEksSourceName() => this.EksSourceName != null;

        /// <summary>
        /// Gets and sets the property LogicalStackName. 
        /// <para>
        /// Name of the CloudFormation stack this resource is mapped to when the <c>mappingType</c>
        /// is <c>CfnStack</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogicalStackName { get; set; }

        /// <summary>
        /// Checks to see if the LogicalStackName property is set.
        /// </summary>
        internal bool IsSetLogicalStackName() => this.LogicalStackName != null;

        /// <summary>
        /// Gets and sets the property MappingType. 
        /// <para>
        /// Specifies the type of resource mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceMappingType MappingType { get; set; }

        /// <summary>
        /// Checks to see if the MappingType property is set.
        /// </summary>
        internal bool IsSetMappingType() => this.MappingType != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// Identifier of the physical resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PhysicalResourceId PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// Name of the Resource Groups that this resource is mapped to when the <c>mappingType</c>
        /// is <c>ResourceGroup</c>.
        /// </para>
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// Name of the resource that this resource is mapped to when the <c>mappingType</c> is
        /// <c>Resource</c>.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property TerraformSourceName. 
        /// <para>
        /// Name of the Terraform source that this resource is mapped to when the <c>mappingType</c>
        /// is <c>Terraform</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TerraformSourceName { get; set; }

        /// <summary>
        /// Checks to see if the TerraformSourceName property is set.
        /// </summary>
        internal bool IsSetTerraformSourceName() => this.TerraformSourceName != null;
    }
}
