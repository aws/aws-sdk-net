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
    /// Defines a logical resource identifier.
    /// </summary>
    public partial class LogicalResourceId
    {
        /// <summary>
        /// Gets and sets the property EksSourceName. 
        /// <para>
        /// Name of the Amazon Elastic Kubernetes Service cluster and namespace this resource
        /// belongs to.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LogicalStackName. 
        /// <para>
        /// The name of the CloudFormation stack this resource belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogicalStackName { get; set; }

        /// <summary>
        /// Checks to see if the LogicalStackName property is set.
        /// </summary>
        internal bool IsSetLogicalStackName() => this.LogicalStackName != null;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group that this resource belongs to.
        /// </para>
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property TerraformSourceName. 
        /// <para>
        ///  The name of the Terraform S3 state file this resource belongs to. 
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
