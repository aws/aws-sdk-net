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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Contains the output from the DescribeReservedNodes action.</para>
    /// </summary>
    public partial class DescribeReservedNodesResult : AmazonWebServiceResponse
    {
        
        private string marker;
        private List<ReservedNode> reservedNodes = new List<ReservedNode>();


        /// <summary>
        /// A marker that can be used to retrieve paginated results.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// The list of reserved nodes.
        ///  
        /// </summary>
        public List<ReservedNode> ReservedNodes
        {
            get { return this.reservedNodes; }
            set { this.reservedNodes = value; }
        }

        // Check to see if ReservedNodes property is set
        internal bool IsSetReservedNodes()
        {
            return this.reservedNodes.Count > 0;
        }
    }
}
