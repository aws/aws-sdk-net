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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// This is the response object from the GetVersions operation.
    /// </summary>
    public partial class GetVersionsResponse : AmazonWebServiceResponse
    {
        private List<InstanceTypeEsxVersionsInfo> _instanceTypeEsxVersions = AWSConfigs.InitializeCollections ? new List<InstanceTypeEsxVersionsInfo>() : null;
        private List<VcfVersionInfo> _vcfVersions = AWSConfigs.InitializeCollections ? new List<VcfVersionInfo>() : null;

        /// <summary>
        /// Gets and sets the property InstanceTypeEsxVersions. 
        /// <para>
        /// A list of EC2 instance types and their available ESX versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InstanceTypeEsxVersionsInfo> InstanceTypeEsxVersions
        {
            get { return this._instanceTypeEsxVersions; }
            set { this._instanceTypeEsxVersions = value; }
        }

        // Check to see if InstanceTypeEsxVersions property is set
        internal bool IsSetInstanceTypeEsxVersions()
        {
            return this._instanceTypeEsxVersions != null && (this._instanceTypeEsxVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VcfVersions. 
        /// <para>
        /// A list of VCF versions with their availability status, default ESX version, and instance
        /// types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VcfVersionInfo> VcfVersions
        {
            get { return this._vcfVersions; }
            set { this._vcfVersions = value; }
        }

        // Check to see if VcfVersions property is set
        internal bool IsSetVcfVersions()
        {
            return this._vcfVersions != null && (this._vcfVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}