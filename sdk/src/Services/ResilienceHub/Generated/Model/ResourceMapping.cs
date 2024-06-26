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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
        private string _appRegistryAppName;
        private string _eksSourceName;
        private string _logicalStackName;
        private ResourceMappingType _mappingType;
        private PhysicalResourceId _physicalResourceId;
        private string _resourceGroupName;
        private string _resourceName;
        private string _terraformSourceName;

        /// <summary>
        /// Gets and sets the property AppRegistryAppName. 
        /// <para>
        /// Name of the application this resource is mapped to when the <c>mappingType</c> is
        /// <c>AppRegistryApp</c>.
        /// </para>
        /// </summary>
        public string AppRegistryAppName
        {
            get { return this._appRegistryAppName; }
            set { this._appRegistryAppName = value; }
        }

        // Check to see if AppRegistryAppName property is set
        internal bool IsSetAppRegistryAppName()
        {
            return this._appRegistryAppName != null;
        }

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
        [AWSProperty(Min=1, Max=255)]
        public string EksSourceName
        {
            get { return this._eksSourceName; }
            set { this._eksSourceName = value; }
        }

        // Check to see if EksSourceName property is set
        internal bool IsSetEksSourceName()
        {
            return this._eksSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property LogicalStackName. 
        /// <para>
        /// Name of the CloudFormation stack this resource is mapped to when the <c>mappingType</c>
        /// is <c>CfnStack</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LogicalStackName
        {
            get { return this._logicalStackName; }
            set { this._logicalStackName = value; }
        }

        // Check to see if LogicalStackName property is set
        internal bool IsSetLogicalStackName()
        {
            return this._logicalStackName != null;
        }

        /// <summary>
        /// Gets and sets the property MappingType. 
        /// <para>
        /// Specifies the type of resource mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceMappingType MappingType
        {
            get { return this._mappingType; }
            set { this._mappingType = value; }
        }

        // Check to see if MappingType property is set
        internal bool IsSetMappingType()
        {
            return this._mappingType != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// Identifier of the physical resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhysicalResourceId PhysicalResourceId
        {
            get { return this._physicalResourceId; }
            set { this._physicalResourceId = value; }
        }

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this._physicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// Name of the Resource Groups that this resource is mapped to when the <c>mappingType</c>
        /// is <c>ResourceGroup</c>.
        /// </para>
        /// </summary>
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// Name of the resource that this resource is mapped to when the <c>mappingType</c> is
        /// <c>Resource</c>.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property TerraformSourceName. 
        /// <para>
        /// Name of the Terraform source that this resource is mapped to when the <c>mappingType</c>
        /// is <c>Terraform</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TerraformSourceName
        {
            get { return this._terraformSourceName; }
            set { this._terraformSourceName = value; }
        }

        // Check to see if TerraformSourceName property is set
        internal bool IsSetTerraformSourceName()
        {
            return this._terraformSourceName != null;
        }

    }
}