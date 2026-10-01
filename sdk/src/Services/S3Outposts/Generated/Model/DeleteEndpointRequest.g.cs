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

namespace Amazon.S3Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEndpoint operation. Deletes an endpoint.
    /// <note> <para> It can take up to 5 minutes for this action to finish. </para> </note>
    /// <para> </para> <para> Related actions include: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class DeleteEndpointRequest : AmazonS3OutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID of the Outposts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;
    }
}
