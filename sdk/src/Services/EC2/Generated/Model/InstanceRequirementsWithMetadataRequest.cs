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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The architecture type, virtualization type, and other attributes for the instance
    /// types. When you specify instance attributes, Amazon EC2 will identify instance types
    /// with those attributes.
    /// 
    ///  
    /// <para>
    /// If you specify <code>InstanceRequirementsWithMetadataRequest</code>, you can't specify
    /// <code>InstanceTypes</code>.
    /// </para>
    /// </summary>
    public partial class InstanceRequirementsWithMetadataRequest
    {
        private List<string> _architectureTypes = new List<string>();
        private InstanceRequirementsRequest _instanceRequirements;
        private List<string> _virtualizationTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property ArchitectureTypes. 
        /// <para>
        /// The architecture type.
        /// </para>
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
            return this._architectureTypes != null && this._architectureTypes.Count > 0; 
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
            return this._virtualizationTypes != null && this._virtualizationTypes.Count > 0; 
        }

    }
}