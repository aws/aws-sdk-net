/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Contains the output from the <a>DescribeReservedNodes</a> action.
    /// </summary>
    public partial class DescribeReservedNodesResult
    {
        private string _marker;
        private List<ReservedNode> _reservedNodes = new List<ReservedNode>();


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///            A value that indicates the starting point for the next set of response
        /// records in a subsequent request.            If a value is returned in a response,
        /// you can retrieve the next set of records by providing this returned            marker
        /// value in the <code>Marker</code> parameter and retrying the command. If the <code>Marker</code>
        /// field           is empty, all response records have been retrieved for the request.
        ///       
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodesResult WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property ReservedNodes. 
        /// <para>
        /// The list of reserved nodes.
        /// </para>
        /// </summary>
        public List<ReservedNode> ReservedNodes
        {
            get { return this._reservedNodes; }
            set { this._reservedNodes = value; }
        }

        /// <summary>
        /// Sets the ReservedNodes property
        /// </summary>
        /// <param name="reservedNodes">The values to add to the ReservedNodes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodesResult WithReservedNodes(params ReservedNode[] reservedNodes)
        {
            foreach (var element in reservedNodes)
            {
                this._reservedNodes.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ReservedNodes property
        /// </summary>
        /// <param name="reservedNodes">The values to add to the ReservedNodes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodesResult WithReservedNodes(IEnumerable<ReservedNode> reservedNodes)
        {
            foreach (var element in reservedNodes)
            {
                this._reservedNodes.Add(element);
            }
            return this;
        }
        // Check to see if ReservedNodes property is set
        internal bool IsSetReservedNodes()
        {
            return this._reservedNodes != null && this._reservedNodes.Count > 0; 
        }

    }
}