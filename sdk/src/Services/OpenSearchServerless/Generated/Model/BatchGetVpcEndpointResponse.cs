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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the BatchGetVpcEndpoint operation.
    /// </summary>
    public partial class BatchGetVpcEndpointResponse : AmazonWebServiceResponse
    {
        private List<VpcEndpointDetail> _vpcEndpointDetails = AWSConfigs.InitializeCollections ? new List<VpcEndpointDetail>() : null;
        private List<VpcEndpointErrorDetail> _vpcEndpointErrorDetails = AWSConfigs.InitializeCollections ? new List<VpcEndpointErrorDetail>() : null;

        /// <summary>
        /// Gets and sets the property VpcEndpointDetails. 
        /// <para>
        /// Details about the specified VPC endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcEndpointDetail> VpcEndpointDetails
        {
            get { return this._vpcEndpointDetails; }
            set { this._vpcEndpointDetails = value; }
        }

        // Check to see if VpcEndpointDetails property is set
        internal bool IsSetVpcEndpointDetails()
        {
            return this._vpcEndpointDetails != null && (this._vpcEndpointDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointErrorDetails. 
        /// <para>
        /// Error information for a failed request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcEndpointErrorDetail> VpcEndpointErrorDetails
        {
            get { return this._vpcEndpointErrorDetails; }
            set { this._vpcEndpointErrorDetails = value; }
        }

        // Check to see if VpcEndpointErrorDetails property is set
        internal bool IsSetVpcEndpointErrorDetails()
        {
            return this._vpcEndpointErrorDetails != null && (this._vpcEndpointErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}