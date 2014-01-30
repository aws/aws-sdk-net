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
    /// Container for the parameters to the ReplaceRouteTableAssociation operation.
    /// <para>Changes the route table associated with a given subnet in a VPC. After the operation completes, the subnet uses the routes in the new
    /// route table it's associated with. For more information about route tables, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
    /// User Guide</i> .</para> <para>You can also use ReplaceRouteTableAssociation to change which table is the main route table in the VPC. You
    /// just specify the main route table's association ID and the route table to be the new main route table.</para>
    /// </summary>
    public partial class ReplaceRouteTableAssociationRequest : AmazonEC2Request
    {
        private string associationId;
        private string routeTableId;


        /// <summary>
        /// The association ID.
        ///  
        /// </summary>
        public string AssociationId
        {
            get { return this.associationId; }
            set { this.associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this.associationId != null;
        }

        /// <summary>
        /// The ID of the new route table to associate with the subnet.
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

    }
}
    
