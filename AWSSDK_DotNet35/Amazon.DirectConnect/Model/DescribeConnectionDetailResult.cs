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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para> Additional information about connection order steps. </para>
    /// </summary>
    public partial class DescribeConnectionDetailResult : AmazonWebServiceResponse
    {
        
        private string connectionId;
        private string connectionName;
        private ConnectionState connectionState;
        private string region;
        private string location;
        private string bandwidth;
        private List<ConnectionCost> connectionCosts = new List<ConnectionCost>();
        private List<ConnectionOrderStep> orderSteps = new List<ConnectionOrderStep>();

        /// <summary>
        /// ID of the connection. Example: dxcon-fg5678gh Default: None
        ///  
        /// </summary>
        public string ConnectionId
        {
            get { return this.connectionId; }
            set { this.connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;
        }

        /// <summary>
        /// The name of the connection. Example: "<i>1G Connection to AWS</i>" Default: None
        ///  
        /// </summary>
        public string ConnectionName
        {
            get { return this.connectionName; }
            set { this.connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this.connectionName != null;
        }

        /// <summary>
        /// State of the connection. <ul> <li><b>Requested</b>: The initial state of connection immediately after creation. The connection stays in the
        /// requested state until the Letter of Authorization (LOA) is sent to the customer.</li> <li><b>Pending</b>: A connection is pending after the
        /// customer receives the LOA and remains pending until the completion of the partner circuit.</li> <li><b>Available</b>: A connection that is
        /// completed and ready for use. A connection must be available before virtual interfaces can be created.</li> <li><b>Deleted</b>: A connection
        /// that has been deleted.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>requested, pending, available, deleted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ConnectionState ConnectionState
        {
            get { return this.connectionState; }
            set { this.connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this.connectionState != null;
        }

        /// <summary>
        /// The AWS region where the offering is located. Example: us-east-1 Default: None
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// Where the AWS Direct Connect offering is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// Bandwidth of the connection. Example: 1Gbps Default: None
        ///  
        /// </summary>
        public string Bandwidth
        {
            get { return this.bandwidth; }
            set { this.bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this.bandwidth != null;
        }

        /// <summary>
        /// A list of connection costs.
        ///  
        /// </summary>
        public List<ConnectionCost> ConnectionCosts
        {
            get { return this.connectionCosts; }
            set { this.connectionCosts = value; }
        }

        // Check to see if ConnectionCosts property is set
        internal bool IsSetConnectionCosts()
        {
            return this.connectionCosts.Count > 0;
        }

        /// <summary>
        /// A list of connection order steps.
        ///  
        /// </summary>
        public List<ConnectionOrderStep> OrderSteps
        {
            get { return this.orderSteps; }
            set { this.orderSteps = value; }
        }

        // Check to see if OrderSteps property is set
        internal bool IsSetOrderSteps()
        {
            return this.orderSteps.Count > 0;
        }
    }
}
