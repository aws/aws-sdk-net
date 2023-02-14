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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeManagedEndpoint operation.
    /// Displays detailed information about a managed endpoint. A managed endpoint is a gateway
    /// that connects Amazon EMR Studio to Amazon EMR on EKS so that Amazon EMR Studio can
    /// communicate with your virtual cluster.
    /// </summary>
    public partial class DescribeManagedEndpointRequest : AmazonEMRContainersRequest
    {
        private string _id;
        private string _virtualClusterId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// This output displays ID of the managed endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualClusterId. 
        /// <para>
        /// The ID of the endpoint's virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string VirtualClusterId
        {
            get { return this._virtualClusterId; }
            set { this._virtualClusterId = value; }
        }

        // Check to see if VirtualClusterId property is set
        internal bool IsSetVirtualClusterId()
        {
            return this._virtualClusterId != null;
        }

    }
}