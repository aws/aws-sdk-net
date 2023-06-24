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
    /// Container for the parameters to the DeleteVpcEndpointServiceConfigurations operation.
    /// Deletes the specified VPC endpoint service configurations. Before you can delete an
    /// endpoint service configuration, you must reject any <code>Available</code> or <code>PendingAcceptance</code>
    /// interface endpoint connections that are attached to the service.
    /// </summary>
    public partial class DeleteVpcEndpointServiceConfigurationsRequest : AmazonEC2Request
    {
        private List<string> _serviceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ServiceIds. 
        /// <para>
        /// The IDs of the services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ServiceIds
        {
            get { return this._serviceIds; }
            set { this._serviceIds = value; }
        }

        // Check to see if ServiceIds property is set
        internal bool IsSetServiceIds()
        {
            return this._serviceIds != null && this._serviceIds.Count > 0; 
        }

    }
}