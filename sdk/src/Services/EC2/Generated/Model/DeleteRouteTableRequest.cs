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
    /// Container for the parameters to the DeleteRouteTable operation.
    /// Deletes the specified route table. You must disassociate the route table from any
    /// subnets before you can delete it. You can't delete the main route table.
    /// </summary>
    public partial class DeleteRouteTableRequest : AmazonEC2Request
    {
        private string _routeTableId;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteTableId
        {
            get { return this._routeTableId; }
            set { this._routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this._routeTableId != null;
        }

    }
}