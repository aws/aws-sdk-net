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
    /// Container for the parameters to the RemoveDraftAppVersionResourceMappings operation.
    /// Removes resource mappings from a draft application version.
    /// </summary>
    public partial class RemoveDraftAppVersionResourceMappingsRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private List<string> _appRegistryAppNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _eksSourceNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logicalStackNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _resourceGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _resourceNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _terraformSourceNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppRegistryAppNames. 
        /// <para>
        /// The names of the registered applications you want to remove from the resource mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AppRegistryAppNames
        {
            get { return this._appRegistryAppNames; }
            set { this._appRegistryAppNames = value; }
        }

        // Check to see if AppRegistryAppNames property is set
        internal bool IsSetAppRegistryAppNames()
        {
            return this._appRegistryAppNames != null && (this._appRegistryAppNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EksSourceNames. 
        /// <para>
        /// The names of the Amazon Elastic Kubernetes Service clusters and namespaces you want
        /// to remove from the resource mappings.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter accepts values in "eks-cluster/namespace" format.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EksSourceNames
        {
            get { return this._eksSourceNames; }
            set { this._eksSourceNames = value; }
        }

        // Check to see if EksSourceNames property is set
        internal bool IsSetEksSourceNames()
        {
            return this._eksSourceNames != null && (this._eksSourceNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogicalStackNames. 
        /// <para>
        /// The names of the CloudFormation stacks you want to remove from the resource mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogicalStackNames
        {
            get { return this._logicalStackNames; }
            set { this._logicalStackNames = value; }
        }

        // Check to see if LogicalStackNames property is set
        internal bool IsSetLogicalStackNames()
        {
            return this._logicalStackNames != null && (this._logicalStackNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupNames. 
        /// <para>
        /// The names of the resource groups you want to remove from the resource mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceGroupNames
        {
            get { return this._resourceGroupNames; }
            set { this._resourceGroupNames = value; }
        }

        // Check to see if ResourceGroupNames property is set
        internal bool IsSetResourceGroupNames()
        {
            return this._resourceGroupNames != null && (this._resourceGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceNames. 
        /// <para>
        /// The names of the resources you want to remove from the resource mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceNames
        {
            get { return this._resourceNames; }
            set { this._resourceNames = value; }
        }

        // Check to see if ResourceNames property is set
        internal bool IsSetResourceNames()
        {
            return this._resourceNames != null && (this._resourceNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TerraformSourceNames. 
        /// <para>
        /// The names of the Terraform sources you want to remove from the resource mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerraformSourceNames
        {
            get { return this._terraformSourceNames; }
            set { this._terraformSourceNames = value; }
        }

        // Check to see if TerraformSourceNames property is set
        internal bool IsSetTerraformSourceNames()
        {
            return this._terraformSourceNames != null && (this._terraformSourceNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}