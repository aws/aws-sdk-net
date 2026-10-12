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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// This is the response object from the GetVersions operation.
    /// </summary>
    public partial class GetVersionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property InstanceTypeEsxVersions. 
        /// <para>
        /// A list of EC2 instance types and their available ESX versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InstanceTypeEsxVersionsInfo> InstanceTypeEsxVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceTypeEsxVersionsInfo>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypeEsxVersions property is set.
        /// </summary>
        internal bool IsSetInstanceTypeEsxVersions() => this.InstanceTypeEsxVersions != null && (this.InstanceTypeEsxVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VcfVersions. 
        /// <para>
        /// A list of VCF versions with their availability status, default ESX version, and instance
        /// types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<VcfVersionInfo> VcfVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<VcfVersionInfo>() : null;

        /// <summary>
        /// Checks to see if the VcfVersions property is set.
        /// </summary>
        internal bool IsSetVcfVersions() => this.VcfVersions != null && (this.VcfVersions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
