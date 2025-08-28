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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Use a container registry map to specify mappings between the ECR private repository
    /// and one or more upstream registries. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-ecr.html">Container
    /// images</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </summary>
    public partial class ContainerRegistryMap
    {
        private List<ImageMapping> _imageMappings = AWSConfigs.InitializeCollections ? new List<ImageMapping>() : null;
        private List<RegistryMapping> _registryMappings = AWSConfigs.InitializeCollections ? new List<RegistryMapping>() : null;

        /// <summary>
        /// Gets and sets the property ImageMappings. 
        /// <para>
        /// Image mappings specify path mappings between the ECR private repository and their
        /// corresponding external repositories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageMapping> ImageMappings
        {
            get { return this._imageMappings; }
            set { this._imageMappings = value; }
        }

        // Check to see if ImageMappings property is set
        internal bool IsSetImageMappings()
        {
            return this._imageMappings != null && (this._imageMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegistryMappings. 
        /// <para>
        /// Mapping that provides the ECR repository path where upstream container images are
        /// pulled and synchronized.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegistryMapping> RegistryMappings
        {
            get { return this._registryMappings; }
            set { this._registryMappings = value; }
        }

        // Check to see if RegistryMappings property is set
        internal bool IsSetRegistryMappings()
        {
            return this._registryMappings != null && (this._registryMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}