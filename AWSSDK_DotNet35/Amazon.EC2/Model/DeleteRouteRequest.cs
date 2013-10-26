/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRoute operation.
    /// <para> Deletes a route from a route table in a VPC. For more information about route tables, go to <a
    /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the Amazon Virtual Private
    /// Cloud User Guide. </para>
    /// </summary>
    public partial class DeleteRouteRequest : AmazonEC2Request
    {
        private string routeTableId;
        private string destinationCidrBlock;


        /// <summary>
        /// The ID of the route table where the route will be deleted.
        ///  
        /// </summary>
        public string RouteTableId
        {
            get { return this.routeTableId; }
            set { this.routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this.routeTableId != null;
        }

        /// <summary>
        /// The CIDR range for the route you want to delete. The value you specify must exactly match the CIDR for the route you want to delete.
        ///  
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlock; }
            set { this.destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this.destinationCidrBlock != null;
        }

    }
}
    
