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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetRouteServerAssociations operation.
    /// Gets information about the associations for the specified route server.
    /// 
    ///  
    /// <para>
    /// A route server association is the connection established between a route server and
    /// a VPC. This is a fundamental configuration step that enables the route server to work
    /// with appliances in your VPC.
    /// </para>
    ///  
    /// <para>
    /// For more information see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Dynamic
    /// routing in your VPC with VPC Route Server</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetRouteServerAssociationsRequest : AmazonEC2Request
    {
        private string _routeServerId;

        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server for which to get association information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteServerId
        {
            get { return this._routeServerId; }
            set { this._routeServerId = value; }
        }

        // Check to see if RouteServerId property is set
        internal bool IsSetRouteServerId()
        {
            return this._routeServerId != null;
        }

    }
}