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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The architecture type, virtualization type, and other attributes for the instance
    /// types. When you specify instance attributes, Amazon EC2 will identify instance types
    /// with those attributes.
    /// 
    ///  
    /// <para>
    /// If you specify <c>InstanceRequirementsWithMetadataRequest</c>, you can't specify <c>InstanceTypes</c>.
    /// </para>
    /// </summary>
    public partial class InstanceRequirementsWithMetadataRequest
    {
        private List<string> _architectureTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InstanceRequirementsRequest _instanceRequirements;
        private List<string> _virtualizationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ArchitectureTypes. 
        /// <para>
        /// The architecture type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> ArchitectureTypes
        {
            get { return this._architectureTypes; }
            set { this._architectureTypes = value; }
        }

        // Check to see if ArchitectureTypes property is set
        internal bool IsSetArchitectureTypes()
        {
            return this._architectureTypes != null && (this._architectureTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with those attributes.
        /// </para>
        /// </summary>
        public InstanceRequirementsRequest InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualizationTypes. 
        /// <para>
        /// The virtualization type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> VirtualizationTypes
        {
            get { return this._virtualizationTypes; }
            set { this._virtualizationTypes = value; }
        }

        // Check to see if VirtualizationTypes property is set
        internal bool IsSetVirtualizationTypes()
        {
            return this._virtualizationTypes != null && (this._virtualizationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}