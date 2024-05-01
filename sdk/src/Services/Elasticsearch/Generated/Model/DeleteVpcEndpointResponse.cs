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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for response parameters to the <c><a>DeleteVpcEndpoint</a></c> operation.
    /// Contains the summarized detail of the VPC Endpoint being deleted.
    /// </summary>
    public partial class DeleteVpcEndpointResponse : AmazonWebServiceResponse
    {
        private VpcEndpointSummary _vpcEndpointSummary;

        /// <summary>
        /// Gets and sets the property VpcEndpointSummary. 
        /// <para>
        /// Information about the deleted endpoint, including its current status (<c>DELETING</c>
        /// or <c>DELETE_FAILED</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VpcEndpointSummary VpcEndpointSummary
        {
            get { return this._vpcEndpointSummary; }
            set { this._vpcEndpointSummary = value; }
        }

        // Check to see if VpcEndpointSummary property is set
        internal bool IsSetVpcEndpointSummary()
        {
            return this._vpcEndpointSummary != null;
        }

    }
}