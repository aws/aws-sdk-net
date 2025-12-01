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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The response object containing network access configuration for the Argo CD capability's
    /// managed API server endpoint. If VPC endpoint IDs are present, public access is blocked
    /// and the Argo CD server is only accessible through the specified VPC endpoints.
    /// </summary>
    public partial class ArgoCdNetworkAccessConfigResponse
    {
        private List<string> _vpceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property VpceIds. 
        /// <para>
        /// The list of VPC endpoint IDs associated with the managed Argo CD API server endpoint.
        /// Each VPC endpoint provides private connectivity from a specific VPC to the Argo CD
        /// server.
        /// </para>
        /// </summary>
        public List<string> VpceIds
        {
            get { return this._vpceIds; }
            set { this._vpceIds = value; }
        }

        // Check to see if VpceIds property is set
        internal bool IsSetVpceIds()
        {
            return this._vpceIds != null && (this._vpceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}