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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para> A list of connections. </para>
    /// </summary>
    public class DescribeConnectionsResult  
    {
        
        private List<Connection> connections = new List<Connection>();

        /// <summary>
        /// A list of connections.
        ///  
        /// </summary>
        public List<Connection> Connections
        {
            get { return this.connections; }
            set { this.connections = value; }
        }
        /// <summary>
        /// Adds elements to the Connections collection
        /// </summary>
        /// <param name="connections">The values to add to the Connections collection </param>
        /// <returns>this instance</returns>
        public DescribeConnectionsResult WithConnections(params Connection[] connections)
        {
            foreach (Connection element in connections)
            {
                this.connections.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Connections collection
        /// </summary>
        /// <param name="connections">The values to add to the Connections collection </param>
        /// <returns>this instance</returns>
        public DescribeConnectionsResult WithConnections(IEnumerable<Connection> connections)
        {
            foreach (Connection element in connections)
            {
                this.connections.Add(element);
            }

            return this;
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this.connections.Count > 0;       
        }
    }
}
