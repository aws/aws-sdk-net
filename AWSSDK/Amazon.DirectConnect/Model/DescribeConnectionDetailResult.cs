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
    /// <para> Additional information about connection order steps. </para>
    /// </summary>
    public class DescribeConnectionDetailResult  
    {
        
        private string connectionId;
        private string connectionName;
        private string connectionState;
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

        /// <summary>
        /// Sets the ConnectionId property
        /// </summary>
        /// <param name="connectionId">The value to set for the ConnectionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithConnectionId(string connectionId)
        {
            this.connectionId = connectionId;
            return this;
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

        /// <summary>
        /// Sets the ConnectionName property
        /// </summary>
        /// <param name="connectionName">The value to set for the ConnectionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithConnectionName(string connectionName)
        {
            this.connectionName = connectionName;
            return this;
        }
            

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this.connectionName != null;       
        }

        /// <summary>
        /// State of the connection. <ul> <li><b>Requested</b>: The initial state of connection immediately after creation. The connection stays in the
        /// requested state until the LOA is sent to the customer.</li> <li><b>Pending</b>: A connection is pending after the customer receives the LOA
        /// and remains pending until the completion of the partner circuit.</li> <li><b>Available</b>: A connection that has a completed partner
        /// circuit and is ready for use. A connection must be available before virtual interfaces can be created.</li> <li><b>Deleted</b>: A connection
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
        public string ConnectionState
        {
            get { return this.connectionState; }
            set { this.connectionState = value; }
        }

        /// <summary>
        /// Sets the ConnectionState property
        /// </summary>
        /// <param name="connectionState">The value to set for the ConnectionState property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithConnectionState(string connectionState)
        {
            this.connectionState = connectionState;
            return this;
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

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithRegion(string region)
        {
            this.region = region;
            return this;
        }
            

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;       
        }

        /// <summary>
        /// The AWS Direct Connect location where the offering is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        /// <summary>
        /// Sets the Location property
        /// </summary>
        /// <param name="location">The value to set for the Location property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithLocation(string location)
        {
            this.location = location;
            return this;
        }
            

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;       
        }

        /// <summary>
        /// Bandwidth of the connection. Example: 1Gpbs Default: None
        ///  
        /// </summary>
        public string Bandwidth
        {
            get { return this.bandwidth; }
            set { this.bandwidth = value; }
        }

        /// <summary>
        /// Sets the Bandwidth property
        /// </summary>
        /// <param name="bandwidth">The value to set for the Bandwidth property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithBandwidth(string bandwidth)
        {
            this.bandwidth = bandwidth;
            return this;
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
        /// <summary>
        /// Adds elements to the ConnectionCosts collection
        /// </summary>
        /// <param name="connectionCosts">The values to add to the ConnectionCosts collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithConnectionCosts(params ConnectionCost[] connectionCosts)
        {
            foreach (ConnectionCost element in connectionCosts)
            {
                this.connectionCosts.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ConnectionCosts collection
        /// </summary>
        /// <param name="connectionCosts">The values to add to the ConnectionCosts collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithConnectionCosts(IEnumerable<ConnectionCost> connectionCosts)
        {
            foreach (ConnectionCost element in connectionCosts)
            {
                this.connectionCosts.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the OrderSteps collection
        /// </summary>
        /// <param name="orderSteps">The values to add to the OrderSteps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithOrderSteps(params ConnectionOrderStep[] orderSteps)
        {
            foreach (ConnectionOrderStep element in orderSteps)
            {
                this.orderSteps.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the OrderSteps collection
        /// </summary>
        /// <param name="orderSteps">The values to add to the OrderSteps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConnectionDetailResult WithOrderSteps(IEnumerable<ConnectionOrderStep> orderSteps)
        {
            foreach (ConnectionOrderStep element in orderSteps)
            {
                this.orderSteps.Add(element);
            }

            return this;
        }

        // Check to see if OrderSteps property is set
        internal bool IsSetOrderSteps()
        {
            return this.orderSteps.Count > 0;       
        }
    }
}
